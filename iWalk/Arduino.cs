using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace iWalk
{
    class Arduino :SerialPort
    {

        public Arduino(string portnumber) :
            base(portnumber)
        {
            PortName = portnumber;
        }

       
    }
}
