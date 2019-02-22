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
    class Detect
    {
        HaarCascade EyeCascade;
        HaarCascade FaceCascade;
        HAAR_DETECTION_TYPE detectType;

        public Detect(string faceFile, string eyeFile)
        {
            EyeCascade = new HaarCascade(eyeFile);
            FaceCascade = new HaarCascade(faceFile);
            detectType = HAAR_DETECTION_TYPE.DO_CANNY_PRUNING;

        }

        public Rectangle DetectFace(Image<Bgr, byte> nextFrame)
        {
            Image<Gray, byte> grayframe = nextFrame.Convert<Gray, byte>();
            var faces = grayframe.DetectHaarCascade(
                                             FaceCascade, 1.4, 3,
                                             detectType,
                                             new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                             )[0];

            

            foreach (var face in faces)
            {
                nextFrame.Draw(face.rect, new Bgr(Color.Red), 2);
                return face.rect;
            }

            return new Rectangle(0,0,nextFrame.Width,nextFrame.Height);
        }
        public Rectangle DetectEye(Image<Bgr, byte> nextFrame)
        {
            Image<Gray, byte> grayframe = nextFrame.Convert<Gray, byte>();
            var faces = grayframe.DetectHaarCascade(
                                             EyeCascade, 1.4, 3,
                                             detectType,
                                             new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                             )[0];



            foreach (var face in faces)
            {
                nextFrame.Draw(face.rect, new Bgr(Color.Blue), 1);
                return face.rect;
            }

            return new Rectangle(0, 0, nextFrame.Width, nextFrame.Height);
        }

        public int detectEyeBallF(Image<Gray, byte> img)
        {

            int y = img.Height;
            int x = img.Width;

            Range Left = new Range((x/2)-15, ( y /2) -5, (x / 2)-5, (y/2)+5);

            Range Right = new Range((x / 2) + 5, (y / 2) - 5, (x / 2) +15, (y / 2) + 5);

             Range Forward = new Range((x/2)-5,(y/2)-15,(x/2)+5,(y/2)-5);

             Range Stop = new Range((x / 2)-5, (y / 2)-5, (x / 2) + 5, (y/2)+5);

            Range[] ranges =
            {
                Stop, 
                Forward,
                Left,
                Right,
            };

            int max = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (i<((y/3)) || i>(2*(y/3)))
                        if ((j < ((x / 3) ) || j > (2* (x / 3))))
                        {
                            img[i, j] = new Gray(255);
                            continue;
                        }

                    if (img[i, j].Intensity > 50)
                        img[i, j] = new Gray(255);

                    double score = img[i, j].Intensity;
                    for (int k = 0; k < ranges.Length; k++)
                    {
                        if (ranges[k].isInRange(i, j))
                            if (img[i, j].Intensity < 50)
                                ranges[k].totalIntesity++;

                        if (ranges[k].totalIntesity > ranges[max].totalIntesity)
                            max = k;
                    }
                }
            }

            img.Draw(new LineSegment2D(
                        new Point(x / 2, 0),
                        new Point(x / 2, y)), new Gray(0), 1);

            img.Draw(new LineSegment2D(
                        new Point(0, y/2),
                        new Point(x, y/2)), new Gray(0), 1);

            return max;
        }

 

        struct Range
        {
            int firstX;
            int lastX;
            int firstY;
            int lastY;
            public double totalIntesity;
            public Range(int fx,int fy,int lx,int ly)
            {
                firstX = fx;
                lastX = lx;
                firstY = fy;
                lastY = ly;
                totalIntesity = 0;
            }
            public bool isInRange(int i , int  j)
            {
                return (i > firstY && i < lastY && j > firstX && j < lastX);
            }
        }

        

    }
}