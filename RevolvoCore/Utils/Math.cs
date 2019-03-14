using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Utils
{
    static class MathF
    {
        public static double random()
        {
            return (new Random()).NextDouble();
        }
    }
}
