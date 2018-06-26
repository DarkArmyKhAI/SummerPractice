using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator {
    public class Calculator {
        public double acc = 0;
        public char op = '.';

        public double Calculate(double value) {
            switch (op){
                case '+':
                    return acc + value;
                case '-':
                    return acc - value;
                case '*':
                    return acc * value;
                case '/':
                    return acc / value;
                case 'p':
                    return Math.Pow(value, 0.5);
                case 's':
                    return Math.Sin(value);
                case 'q':
                    return value * value;
                default:
                    throw new Exception("Invalid operator");
            }
        }
    }
}
