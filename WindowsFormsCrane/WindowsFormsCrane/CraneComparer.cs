using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    public class CraneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is SuperCrane && y is SuperCrane)
            {
                return ComparerSuperCrane((SuperCrane)x, (SuperCrane)y);
            }
            if (x is SuperCrane && y is Crane)
            {
                return -1;
            }
            if (x is Crane && y is SuperCrane)
            {
                return 1;
            }
            if (x is Crane && y is Crane)
            {
                return ComparerCrane((Crane)x, (Crane)y);
            }
            return 0;
        }

        private int ComparerCrane(Crane x, Crane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerSuperCrane(SuperCrane x, SuperCrane y)
        {
            var res = ComparerCrane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.LiftingDevice != y.LiftingDevice)
            {
                return x.LiftingDevice.CompareTo(y.LiftingDevice);
            }
            if (x.CounterWeight != y.CounterWeight)
            {
                return x.CounterWeight.CompareTo(y.CounterWeight);
            }            
            return 0;
        }
    }
}