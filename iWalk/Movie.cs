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
    class Movie
    {
        public Image<Bgr, byte> Original { get; set; }
        public Image<Bgr, byte> Faced { get; set; }
        public Image<Bgr, byte> Eye { get; set; }
        public Image<Gray, byte> EyeBall { get; set; }

        public Movie()
            {
                Decision = 0;
            }

        public int Decision;

        public Color Decide
        {
            get
            {
               switch(Decision)
                {
                    case 0:
                        return Color.Blue;
                    case 1:
                        return Color.Red;
                    case 2:
                        return Color.White;
                    case 3:
                        return Color.Black;
                    case 4:
                        return Color.Yellow;

                }

                return Color.Yellow;
            }
        }

    }
}
