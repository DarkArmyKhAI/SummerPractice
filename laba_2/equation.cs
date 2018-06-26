using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2
{
     public class equation
    {
        public double a=0, b=0, c=0, x1, x2, D;
        public static readonly double err = 999999;

        public void calculate()
        {
            if (0 == a && b != 0 && c != 0)
            {
                x1 = -c / b;
                x2 = err;
                D = err;
                MessageBox.Show("a = 0") ;
            }

            if (0 == b && a != 0 && c != 0)
            {
                //x2 = err;
                D = err;
                if((-c / a) < 0)
                {
                    x1 = Math.Sqrt((-c / a) * -1);
                    x2 = Math.Sqrt((-c / a) * -1) * -1;
                    MessageBox.Show("b = 0 \n" + "x1 = " + x1  + "i\n" + "x2 = " + x2 + "i"); 
                }
                else
                {
                    x1 = Math.Sqrt(-c / a);
                    x2 = x1 * (-1);
                    MessageBox.Show("b = 0");
                }
               
            }

            if (0 == c && a != 0 && b != 0)
            {
                x1 = -b / a;
                x2 = err;
                D = err;
                MessageBox.Show("с = 0"); 
            }

            if (a != 0 && b != 0 && c != 0)
            {
                D = (b * b) - (4 * a * c);

                if(D < 0)//дискриминант отрицательный
                {
                    negative();
                    MessageBox.Show("Отрицательный дискриминант");
                }
                else
                {
                    if(D == 0)//дискриминант равен нулю
                    {
                        x1 = x2 = -b / (2 * a);
                    }
                    else
                    {   //дискриминант положительный
                        x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                        x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    }
                }
            }
            
        }


        private void negative()
        {
            double m, n;
            m = -b / (2 * a);
            n = Math.Abs(Math.Sqrt(-D) / (2 * a));
            MessageBox.Show("\nx1 = " + m + " + i*" + n + "\nx2 = " + m + " -i*" + n);
        }


    }
}
