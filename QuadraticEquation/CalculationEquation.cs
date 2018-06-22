using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public class CalculationEquation
    {
        /// <summary>
        /// Метод для решения квадратного уравнения
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns>Список строк с ответами</returns>
        public List<string> CalcQuadraticEq(string A, string B, string C)
        {
            List<string> results = new List<string>();

            double a = Convert.ToDouble(A);
            double b = Convert.ToDouble(B);
            double c = Convert.ToDouble(C);

            double D = b * b - 4 * a * c;

            for (int i = 0; i < 3; i++)
                results.Add("***");

            if (D == 0) // Если дискриминант равен 0
            {
                double x = (-b / (2 * a));
                results[2] = String.Format("{0:F2}", D);
                results[0] = String.Format("{0:F2}", x);
            }
            else if(D>0) // Если дискриминант больше 0
            {
                double x1 = ((-b - Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(D)) / (2 * a));
                results[0] = String.Format("{0:F2}", x1);
                results[1] = String.Format("{0:F2}", x2);
                results[2] = String.Format("{0:F2}", D);
            }

            return results;
        }

        /// <summary>
        /// Метод для решения кубического уравнения
        /// </summary>
        /// <param name="AI"></param>
        /// <param name="BI"></param>
        /// <param name="CI"></param>
        /// <param name="DI"></param>
        /// <returns>Список строк с ответами</returns>
        /// Для решения используется метод Виета-Кардано
        public List<string> CalcCubicEq(string AI, string BI, string CI, string DI)
        {
            double d = Convert.ToDouble(AI);
            double h = Convert.ToDouble(BI);
            double g = Convert.ToDouble(CI);
            double f = Convert.ToDouble(DI);
            List<string> results = new List<string>();
            // Вычисление коэффициентов
            double a = h / d, b = g / d, c = f / d, t, x1, x2, x3;
            const double pi = 3.14;
            double Q = (Math.Pow(a, 2) - 3 * b) / 9;
            double R = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;

            for (int i = 0; i < 3; i++)
                results.Add("***");

            if (Math.Pow(R, 2) < Math.Pow(Q, 3))
            {
                t = Math.Acos(R / Math.Sqrt(Math.Pow(Q, 3))) / 3;
                x1 = -2 * Math.Sqrt(Q) * Math.Cos(t) - a / 3;
                x2 = -2 * Math.Sqrt(Q) * Math.Cos(t + (2 * pi / 3)) - a / 3;
                x3 = -2 * Math.Sqrt(Q) * Math.Cos(t - (2 * pi / 3)) - a / 3;
                results[0] = String.Format("{0:F2}", x1); 
                results[1] = String.Format("{0:F2}", x2);
                results[2] = String.Format("{0:F2}", x3);
            }
            else
            {
                double A, B, m, k, k1;
                A = -sign(R) * Math.Pow((double)(Math.Abs(R) + Math.Sqrt(Math.Pow(R, 2) - Math.Pow(Q, 3))), (double)1 / 3);
                B = sign(A) == 0 ? 0 : Q / A;
                x1 = (A + B) - a / 3;
                m = -(A + B) / 2 - a / 3;
                k = Math.Pow(3, 0.5) * (A - B) / 2;
                if (k < 0)
                {
                    k1 = -1 * k;
                    results[0] = String.Format("{0:F2}", x1);
                    results[1] = String.Format("{0:F2} - {1:F1}*i", m, k1);
                    results[2] = String.Format("{0:F2} + {1:F1}*i", m, k1);
                }
                else
                {
                    results[0] = String.Format("{0:F2}", x1);
                    results[1] = String.Format("{0:F2} + {1:F1}*i", m, k);
                    results[2] = String.Format("{0:F2} - {1:F1}*i", m, k);
                }
            }
            return results;
        }

        int sign(double ld)
        {
            if (Math.Abs(ld) < 0.00000000001) return 0;
            return (ld > 0) ? 1 : -1;
        }
    }
}
