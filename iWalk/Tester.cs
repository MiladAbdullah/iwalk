using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using System.Xml;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Threading;
using System.IO;
namespace iWalk
{
    public partial class Tester : Form
    {
        Arduino Mega;
        Record record;
        Detect detect;
        int clock;
        Queue<string> commands; 
        double commandRate;
        string commmand;
        public Tester()
        {
            InitializeComponent();
            commands = new Queue<string>();

            string [] ports = System.IO.Ports.SerialPort.GetPortNames();
            PortBox.Items.AddRange(ports);
            if (ports.Length>0)
                PortBox.SelectedIndex = 0;

            clock = 0;
            commmand = "0";


        }



        private void Start_Click(object sender, EventArgs e)
        {
            if (showTimer.Enabled)
            {
                record.Stop();
                Start.Text = "Start";
            }
            else
            {
                record = new Record(0);
                detect = new Detect("face//haarcascade_frontalface_alt.xml","face//ojoD.xml");
                record.detector = detect;
                Start.Text = "Stop";
                record.Start();
            }

            showTimer.Enabled = !showTimer.Enabled;
        }

        private void showTimer_Tick(object sender, EventArgs e)
        {
            Movie X = record.Last;
            if (X != null)
            {
                pBox.Image = X.Original.Bitmap;
                if (record.DetectFace && X.Faced !=null)
                {
                    faceBox.Image = X.Faced.Bitmap;
                    if (record.DetectEye && X.Eye != null)
                    {
                        eyeBox.Image = X.Eye.Bitmap;
                        if (record.DetectBall && X.EyeBall != null)
                        {
                            ballBox.Image = X.EyeBall.Bitmap;
                            this.BackColor = X.Decide;
                            string c = X.Decision.ToString();
                            if (c != "0")
                            {

                                Console.WriteLine(c);
                                commands.Enqueue(c);
                            }
                        }
                    }
                }
            }

        }

        private void Tester_Load(object sender, EventArgs e)
        {

        }

        private void Tester_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (showTimer.Enabled)
            {
                record.Stop();
                Start.Text = "Start";
            }

            if (Mega==null)
            {
                try
                {
                    Mega = new Arduino(PortBox.Items[PortBox.SelectedIndex].ToString());
                    Mega.Open();
                    Mega.Write("0");
                    Mega.Close();

                    if (Mega.IsOpen)
                    {
                        Mega.Write("0");
                        Mega.Close();
                        return;
                    }
                }
                catch
                {

                }
            }

            
         
        }

        private void pBox_Click(object sender, EventArgs e)
        {

        }

        private void faceDetectButton_Click(object sender, EventArgs e)
        {
            if (record.DetectFace)
                faceDetectButton.Text = "Stop Face Detect";
            else
                faceDetectButton.Text = "Start Face Detect";

            record.DetectFace = !record.DetectFace;
        }

        private void eyeDetectBtm_Click(object sender, EventArgs e)
        {
            
            if (record.DetectEye)
                eyeDetectBtm.Text = "Stop Eye Detect";
            else
                eyeDetectBtm.Text = "Start Eye Detect";

            record.DetectEye = !record.DetectEye;
        }

        private void eyeballDetectButton_Click(object sender, EventArgs e)
        {

         
            if (record.DetectBall)
                eyeballDetectButton.Text = "Stop EyeBall Detect";
            else
                eyeballDetectButton.Text = "Start EyeBall Detect";

            record.DetectBall = !record.DetectBall;
        }

        private void portConnector_Click(object sender, EventArgs e)
        {
            if (portConnector.Text == "Connect")
            {
                Mega = new Arduino(PortBox.Items[PortBox.SelectedIndex].ToString());
                Mega.Open();
                delayer.Enabled = true;
                portConnector.Text = "disconnect";
            }
            else
            {
                delayer.Enabled = false;
              
                Mega.Close();
                
                portConnector.Text = "Connect";
            }
            
            
           
        }

        private void delayer_Tick(object sender, EventArgs e)
        {


            if (clock ==0 || clock==1)
            {
                if (commands.Count > 0)
                {
                    string x = commands.Dequeue();
                    Mega.Write(x);
                }
            }

            if (clock == 3)
            {
                Mega.Write("0");
                

                clock = 0;
            }
            clock++;
        }

        private void stopBtm_MouseDown(object sender, MouseEventArgs e)
        {
            Mega.Write("0");
        }

        private void upButton_MouseDown(object sender, MouseEventArgs e)
        {
            Mega.Write("1");
            delayer.Enabled = false;
        }

        private void upButton_MouseUp(object sender, MouseEventArgs e)
        {
            Mega.Write("0");
            delayer.Enabled = true;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {

        }

        private void LeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            Mega.Write("0");
            delayer.Enabled = true;
        }

        private void LeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            delayer.Enabled = false;
            Mega.Write("2");
        }


        private void rightButton_MouseUp(object sender, MouseEventArgs e)
        {
            Mega.Write("0");
            delayer.Enabled = true;
        }

        private void rightButton_MouseDown(object sender, MouseEventArgs e)
        {
            delayer.Enabled = false;
            Mega.Write("3");
        }




    }
}
