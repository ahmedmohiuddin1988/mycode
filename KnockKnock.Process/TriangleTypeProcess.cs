using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnock.Process
{
    public class TriangleTypeProcess
    {
        /// <summary>
        /// Get Triangle Type .
        /// </summary>
        /// <param a="a">a side.</param>
        /// /// <param b="b">b side</param>
        /// /// <param c="c">c side.</param>
        /// <returns>Triange type.</returns>
        public string GetTriangleType(int a ,int b, int c)
        {

          
            if (!this.IsExistentTriangle(a, b, c))
            {
                return (Triangle.Error.ToString());
            }
            else if (this.IsEquilateralTriangle(a, b, c))
            {
                return (Triangle.Equilateral.ToString());
            }
            else if (this.IsScaleneTriangle(a, b, c))
            {
                return (Triangle.Scalene.ToString());
            }
            else if (this.IsIsoscelesTriangle(a, b, c))
            {
                return (Triangle.Isosceles.ToString());
            }

            return Triangle.Error.ToString();
        }

        protected bool IsExistentTriangle(int a, int b, int c)
        {
            bool triangleExist = true;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                triangleExist = false;
            }
            else if (((long)a + b) <= c)
            {
                triangleExist = false;
            }
            else if (((long)a + c) <= b)
            {
                triangleExist = false;
            }
            else if (((long)b + c) <= a)
            {
                triangleExist = false;
            }

            return triangleExist;
        }

        // An equilateral triangle has all sides the same length. 
        // An equilateral triangle is also a regular polygon with all angles measuring 60°.
        protected bool IsEquilateralTriangle(int a, int b, int c)
        {
            return (a == b && a == c);
        }

        // An isosceles triangle has two sides of equal length.
        // An isosceles triangle also has two angles of the same measure.
        protected bool IsIsoscelesTriangle(int a, int b, int c)
        {
            return (a == b || a == c || b == c);
        }

        // A scalene triangle has all sides different lengths, or equivalently all angles are unequal.
        protected bool IsScaleneTriangle(int a, int b, int c)
        {
            return (a != b && a != c && b != c);
        }
    }
}
