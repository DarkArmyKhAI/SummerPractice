using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_tp
{
    public interface InterfaceCalculator
    {
        //а - первый аргумент, b - второй
        void Put_A(double a); //сохранить а

        double Multiplication(double b); // умножение

        double Division(double b); // деление

        double Sum(double b); // сложение

        double Subtraction(double b);  // вычитание

        double Square(); // квадрат числа (площадь)

        double Factorial(); // факториал числа

        double Pow(); // возведениие в степень 1/2

        double Sinus(); // синус числа

        double Cosinus(); // косинус числа

        double XDivision(); // 1/x
    }
}
