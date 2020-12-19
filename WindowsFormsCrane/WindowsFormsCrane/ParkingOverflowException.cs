using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("На аэродроме нет мест ")
        { }
    }
}
