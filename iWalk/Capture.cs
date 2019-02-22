using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using System.Xml;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Threading;
using System.IO;

namespace iWalk
{
    class Record
    {
        public bool DetectEye { get; set; }
        public bool DetectFace { get; set; }
        public bool DetectBall { get; set; }


        int height, width;
        Capture CapObject;
        Thread Recorder;
        public Detect detector;
        Queue<Movie> images;
        private void Run()
        {
            Image<Bgr, Byte> frame;


            while (true)
            {
                Movie FrameSet = new Movie();

                frame = CapObject.QueryFrame().Resize(height, width, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                FrameSet.Original = frame.Clone();
                if (DetectFace)
                {
                    Rectangle F = detector.DetectFace(frame);
                    FrameSet.Faced = frame.Clone();

                    if (DetectEye)
                    {
                        frame = Crop(FrameSet.Faced, F);
                        Rectangle E = detector.DetectEye(frame);

                        FrameSet.Eye = frame;

                        if (DetectBall)
                        {
                            
                            frame = Crop(frame, E);
                            FrameSet.EyeBall = frame.Clone().Convert<Gray, byte>();
                            int Decision = detector.detectEyeBallF(FrameSet.EyeBall);
                            FrameSet.Decision = Decision;
                        }

                    }
                }

                images.Enqueue(FrameSet);

                frame = null;
            }
        }
        public Movie Last
        {
            get
            {
                if (images.Count > 0)
                    return images.Dequeue();
                else
                    return null;
            }
        }
        public Record(int index, int h = 320, int w = 240)
        {
            height = h;
            width = w;
            CapObject = new Capture(index);
            Recorder = new Thread(new ThreadStart(Run));
            images = new Queue<Movie>();
            DetectBall = DetectEye = DetectFace = false;
        }

        public void Start()
        {
            Recorder.Start();
        }

        public void Stop()
        {
            Recorder.Abort();
            images.Clear();
            Recorder = new Thread(new ThreadStart(Run));
        }
        /// <summary>
        /// this method cuts the image through a smaller rectangle
        /// </summary>
        /// <param name="source"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        private Image<Bgr, byte> Crop(Image<Bgr, byte> source, Rectangle rect)
        {
            if (rect == null)
                return null;

            Image<Bgr, byte> output = new Image<Bgr, byte>(rect.Width, rect.Height);
            int sourceV = rect.Y;
            
            // copy from rectangle

            for (int i = 0; i < output.Height; i++)
            {
                int sourceH = rect.X;
                for (int j = 0; j < output.Width; j++)
                {
                    output[i, j] = source[sourceV, sourceH];
                    sourceH++;
                }

                sourceV++;
            }

            return output;
        }
    }
}
