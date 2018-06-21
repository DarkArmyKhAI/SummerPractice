using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_tp
{
    public class Calculator : InterfaceCalculator
    {
        private double a = 0; // первый операнд

        public void Put_A(double a) // сохранить а
        {
            this.a = a;
        }

        public void Clear_A() // очистить а
        {
            a = 0;
        }

        public double Multiplication(double b) // умножение
        {
            return a * b;
        }

        public double Division(double b) // деление
        {
            return a / b;
        }

        public double Sum(double b) // сложение
        {
            return a + b;
        }

        public double Subtraction(double b)  // вычитание
        {
            return a - b;
        }

        public double Square() // квадрат числа (площадь)
        {
            return Math.Pow(a, 2.0);
        }

        public double Factorial() // факториал числа
        {
            double f = 1;

            for (int i = 1; i <= a; i++)
                f *= (double)i;

            return f;
        }

        public double Pow() // возведение степень 1/2
        {
            return Math.Pow(a, 0.5);
        }

        public double Sinus() // синус числа
        {
            return Math.Sin(a);
        }

        public double Cosinus() // косинус числа
        {
            return Math.Cos(a);
        }

        public double XDivision() // 1/х
        {
            return 1 / a;
        }
    }
}
