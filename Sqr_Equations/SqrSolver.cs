using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqr_Equations
{
    public class SqrSolver
    {
        private double a, b, c, x1,x2;// коэффициенты и корни
        private bool isComplex;// комплексное решение

        public SqrSolver(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            isComplex = false;
            
        }

        public bool Solve(out double x1, out double x2) // метод решения кв уравнения
        {
            double d = b*b - (4 * a * c);
 
            if (d < 0)
            {
                isComplex = true;
                d *= -1;

                x1 = -b / 2 * a;
                x2 = Math.Sqrt(d) / 2 * a;
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
            }

            return isComplex ? true : false;
        }
    }
}
