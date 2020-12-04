using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    class CraneNotFoundException : Exception
    {
        public CraneNotFoundException(int i) : base("Не найден кран по месту " + i)
        { }
    }
}
