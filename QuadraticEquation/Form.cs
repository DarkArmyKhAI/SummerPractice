using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Globalization;

namespace QuadraticEquation
{
    public partial class Form : System.Windows.Forms.Form
    {
        /// <summary>
        /// Поля для отображения ошибки
        /// </summary>
        private ErrorProvider errorProvider1, errorProvider2, errorProvider3; 

        public Form()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            errorProvider2 = new ErrorProvider();
            errorProvider3 = new ErrorProvider();
        }

        // Обработчик кнпоки Вычислить для квадратного уравнения
        private void CalcQ_Click(object sender, EventArgs e)
        {
            if (AInputQ.Text.Length == 0 || BInputQ.Text.Length == 0 || CInputQ.Text.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Error");
                return;
            }

            // Если коэфф. А равен 0
            if(Convert.ToDouble(AInputQ.Text) == 0)
            {
                // Отобразить сообщение о ошибке
                errorProvider1.SetError(AInputQ, "А не может быть равно 0!");
                AInputQ.Focus();
                return;
            }
            else
            {
                // Очистить сообщение о ошибке
                errorProvider1.SetError(AInputQ, "");
            }

            

            // Если выбран первый способ
            if (Mod1.Checked)
            {
                // Исходные данные 
                double a = Convert.ToDouble(AInputQ.Text);
                double b = Convert.ToDouble(BInputQ.Text);
                double c = Convert.ToDouble(CInputQ.Text);

                // Решение уравнения в обработчике
                double D = b * b - 4 * a * c;

                if (D < 0) // Если дискриминант меньше нуля
                {
                    MessageBox.Show("Дискриминант меньше нуля. Корней нет.", "Information");
                    X1ResultQ.Text = "***";
                    X2ResultQ.Text = "***";
                    DResultQ.Text = "***";
                }
                else if(D == 0) // Если равен 0
                {
                    double x = (-b / (2 * a));
                    DResultQ.Text = String.Format("{0:F2}", D);
                    X1ResultQ.Text = String.Format("{0:F2}", x);
                }
                else // Если больше 0
                {
                    double x1 = ((-b - Math.Sqrt(D)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(D)) / (2 * a));
                    X1ResultQ.Text = String.Format("{0:F2}", x1);
                    X2ResultQ.Text = String.Format("{0:F2}", x2);
                    DResultQ.Text = String.Format("{0:F2}", D);
                }
            }
            else if (Mod2.Checked) // Если выбран 2 способ
            {
                CalculationQuadraticEquation(); // Вызов метода для решения уравнения
            }
            else // Если выбран 3 способ
            {
                CalculationEquation Calc = new CalculationEquation(); // Создание объекта класа 
                List <string> results = Calc.CalcQuadraticEq(AInputQ.Text, BInputQ.Text, CInputQ.Text); // Вызов метода решения уравнения
                X1ResultQ.Text = results[0];
                X2ResultQ.Text = results[1];
                DResultQ.Text = results[2];
            }
        }

        // Обработчик кнпоки Вычислить для кубического уравнения
        private void CalcC_Click(object sender, EventArgs e)
        {
            if (AInputC.Text.Length == 0 || BInputC.Text.Length == 0 || CInputC.Text.Length == 0 || DInputC.Text.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Error");
                return;
            }

            // Проверка на А == 0
            if (Convert.ToDouble(AInputC.Text) == 0)
            {
                // Отобразить ошибку
                errorProvider2.SetError(AInputC, "А не может быть равно 0!");
                AInputC.Focus();
                return;
            }
            else
            {
                errorProvider2.SetError(AInputC, "");
            }
            
            // Если выбран 1 способ
            if (Mod1.Checked)
            { // Для решения используется метод Виета-Кардано
                // Исходные данные и вычисление коэффициентов
                double d = Convert.ToDouble(AInputC.Text), h = Convert.ToDouble(BInputC.Text), g = Convert.ToDouble(CInputC.Text), f = Convert.ToDouble(DInputC.Text);
                double a = h / d, b = g / d, c = f / d, t, x1, x2, x3;
                const double pi = 3.14;
                double Q = (Math.Pow(a, 2) - 3 * b) / 9;
                double R = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;
                if (Math.Pow(R, 2) < Math.Pow(Q, 3)) {
                    t = Math.Acos(R / Math.Sqrt(Math.Pow(Q, 3))) / 3;
                    x1 = -2 * Math.Sqrt(Q) * Math.Cos(t) - a / 3;
                    x2 = -2 * Math.Sqrt(Q) * Math.Cos(t + (2 * pi / 3)) - a / 3;
                    x3 = -2 * Math.Sqrt(Q) * Math.Cos(t - (2 * pi / 3)) - a / 3;
                    X1ResultC.Text = String.Format("{0:F2}", x1); 
                    X2ResultC.Text = String.Format("{0:F2}", x2);
                    X3ResultC.Text = String.Format("{0:F2}", x3);
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
                        X1ResultC.Text = String.Format("{0:F2}", x1);
                        X2ResultC.Text = String.Format("{0:F2} - {1:F1}*i", m, k1);
                        X3ResultC.Text = String.Format("{0:F2} + {1:F1}*i", m, k1);
                    }
                    else
                    {
                        X3ResultC.Text = String.Format("{0:F2}", x1);
                        X3ResultC.Text = String.Format("{0:F2} + {1:F1}*i", m, k);
                        X3ResultC.Text = String.Format("{0:F2} - {1:F1}*i", m, k);
                    }
                }
            }  
            else if (Mod2.Checked) // Если выбран второй способ
            {
                CalculationCubicEquation();
            }
            else
            {
                CalculationEquation Calc = new CalculationEquation(); // Создание объекта класса 
                List<string> results = Calc.CalcCubicEq(AInputC.Text, BInputC.Text, CInputC.Text, DInputC.Text); // Вызов метода для решения кубического уравнения
                // Если дискриминант меньше 0
                if(results[0] == "***") { MessageBox.Show("Дискриминант меньше нуля. Корней нет.", "Information"); return; } 
                X1ResultC.Text = results[0];
                X2ResultC.Text = results[1];
                X3ResultC.Text = results[2]; 
            }
        }

        int sign(double ld) // Дополнительные метод для решения кубического уравнения
        {
            if (Math.Abs(ld) < 0.00000000001) return 0;
            return (ld > 0) ? 1 : -1;
        }

        // Метод в форме для решения квадратного уравнения
        private void CalculationQuadraticEquation()
        {
            double a = Convert.ToDouble(AInputQ.Text);
            double b = Convert.ToDouble(BInputQ.Text);
            double c = Convert.ToDouble(CInputQ.Text);

            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                MessageBox.Show("Дискриминант меньше нуля. Корней нет.", "Information");
                X1ResultQ.Text = "***";
                X2ResultQ.Text = "***";
                DResultQ.Text = "***";
            }
            else if (D == 0)
            {
                double x = (-b / (2 * a));
                DResultQ.Text = D.ToString();
                X1ResultQ.Text = x.ToString();
            }
            else
            {
                double x1 = ((-b - Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(D)) / (2 * a));
                X1ResultQ.Text = x1.ToString();
                X2ResultQ.Text = x2.ToString();
                DResultQ.Text = D.ToString();
            }
        }
        // Метод для решения кубического уравнения в форме
        private void CalculationCubicEquation()
        {
            double d = Convert.ToDouble(AInputC.Text), h = Convert.ToDouble(BInputC.Text), g = Convert.ToDouble(CInputC.Text), f = Convert.ToDouble(DInputC.Text);
            double a = h / d, b = g / d, c = f / d, t, x1, x2, x3;
            const double pi = 3.14;
            double Q = (Math.Pow(a, 2) - 3 * b) / 9;
            double R = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;
            if (Math.Pow(R, 2) < Math.Pow(Q, 3))
            {
                t = Math.Acos(R / Math.Sqrt(Math.Pow(Q, 3))) / 3;
                x1 = -2 * Math.Sqrt(Q) * Math.Cos(t) - a / 3;
                x2 = -2 * Math.Sqrt(Q) * Math.Cos(t + (2 * pi / 3)) - a / 3;
                x3 = -2 * Math.Sqrt(Q) * Math.Cos(t - (2 * pi / 3)) - a / 3;
                X1ResultC.Text = String.Format("{0:F2}", x1);
                X2ResultC.Text = String.Format("{0:F2}", x2);
                X3ResultC.Text = String.Format("{0:F2}", x3);
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
                    X1ResultC.Text = String.Format("{0:F2}", x1);
                    X2ResultC.Text = String.Format("{0:F2} - {1:F1}*i", m, k1);
                    X3ResultC.Text = String.Format("{0:F2} + {1:F1}*i", m, k1);
                }
                else
                {
                    X3ResultC.Text = String.Format("{0:F2}", x1);
                    X3ResultC.Text = String.Format("{0:F2} + {1:F1}*i", m, k);
                    X3ResultC.Text = String.Format("{0:F2} - {1:F1}*i", m, k);
                }
            }
        }

        // Метод для ограничения ввода
        private void CheckCorrectInp(KeyPressEventArgs e, string Text)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.'))
            {

                if (Text.Length - Text.IndexOf('.') > 2 && Text.Contains('.'))
                    e.KeyChar = (char)Keys.None;
                switch (e.KeyChar)
                { // допустим знак '-' только в начале числа
                    case '-':
                        if (Text.Length != 0)
                            e.KeyChar = (char)Keys.None; break;
                    // допустим один символ '.'
                    case '.':
                        if (Text.IndexOf('.') != (-1))
                            e.KeyChar = (char)Keys.None; break;
                } // ввод остальных символов игнорируется
            }

            else e.KeyChar = (char)Keys.None;
        }

        private void AInputQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInp(e, AInputQ.Text);
        }

        private void BInputQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInp(e, BInputQ.Text);
        }

        private void CInputQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInp(e, CInputQ.Text);
        }

        private void AInputC_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInp(e, AInputC.Text);
        }

        private void BInputC_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInp(e, BInputC.Text);
        }

        private void CInputC_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInp(e, CInputC.Text);
        }

        private void DInputC_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInp(e, DInputC.Text);
        }

        // Обработчик кнопки Новое для очистки полей 
        private void ClearC_Click(object sender, EventArgs e)
        {
            AInputC.Text = "";
            BInputC.Text = "";
            CInputC.Text = "";
            DInputC.Text = "";
            X1ResultC.Text = "";
            X2ResultC.Text = "";
            X3ResultC.Text = "";
            AInputC.Focus();
        }
        // Обработчик кнопки Новое для очистки полей 
        private void ClearQ_Click(object sender, EventArgs e)
        {
            AInputQ.Text = "";
            BInputQ.Text = "";
            CInputQ.Text = "";
            X1ResultQ.Text = "";
            X2ResultQ.Text = "";
            DResultQ.Text = "";
            AInputQ.Focus();
        }
    }
}

