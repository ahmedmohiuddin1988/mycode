using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnock.Process
{
    public class FibonacciProcess
    {
        public static int threshold = 92;

        public double NthFibonacciNumber(long n)
        {



            return (Math.Round(
                  (Math.Pow((GetRatio()), n) - Math.Pow((GetRatioNeg()), n)) / Math.Sqrt(5)
                  ));

        }

        private static double GetRatio()
        {
            return (1 + Math.Sqrt(5)) / 2;
        }

        private static double GetRatioNeg()
        {
            return (1 - Math.Sqrt(5)) / 2;
        }
        
    }
}
