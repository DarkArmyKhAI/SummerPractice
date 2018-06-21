using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_tp
{
    public partial class CalculatorForm : Form
    {
        private Calculator Calc;

        public CalculatorForm()
        {
            InitializeComponent();
            Calc = new Calculator(); // Создание объекта класса Calculator для использования методов 
            labelNumber.Text = "0"; // Изначальный текст в окне ввода/вывода
        }

        private void button0_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "0"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "0"; // Добавление нажатой цифры в окно ввода
            CorrectNumber(); // Проверка корректности отображения цифр в окне ввода
        }

        private void button1_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "1"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "1"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)  // Обработчик события нажатия кнопки "2"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "2"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "3"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "3"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "4"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "4"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "5"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "5"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "6"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "6"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "7"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "7"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "8"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "8"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "9"
        {
            if (!MaxMinNumber())
                return;
            labelNumber.Text += "9"; // Добавление нажатой цифры в окно ввода
            CorrectNumber();
        }

        private void buttonDiv_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "/"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDiv.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "x^2"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = Calc.Square().ToString();

                if (labelNumber.Text.Contains(".")) // проверка на количество цифр после запятой 
                {
                    if (labelNumber.Text.Length - labelNumber.Text.IndexOf(".") > 2)
                        labelNumber.Text = labelNumber.Text.Substring(0, 4);
                }



                Calc.Clear_A(); // очистка первого операнда
                FreeButtons(); //снятие нажатия всех кнопок мат.операций
            }
        }

        private void buttonPow_Click (object sender, EventArgs e) // Обработчик события нажатия кнопки "x^1/2"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = Calc.Pow().ToString();

                if (labelNumber.Text.Contains(".")) // проверка на количество цифр после запятой 
                {
                    if (labelNumber.Text.Length - labelNumber.Text.IndexOf(".") > 2)
                        labelNumber.Text = labelNumber.Text.Substring(0, 4);
                }



                Calc.Clear_A(); // очистка первого операнда
                FreeButtons(); //снятие нажатия всех кнопок мат.операций
            }
        }

        private void buttonFactorial_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "x!"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                if ((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) &&
                    ((Convert.ToDouble(labelNumber.Text) >= 0.0)))
                {
                    toDouble();
                    Calc.Put_A(Convert.ToDouble(labelNumber.Text));
                    labelNumber.Text = Calc.Factorial().ToString();

                    if (labelNumber.Text.Contains(".")) // проверка на количество цифр после запятой 
                    {
                        if (labelNumber.Text.Length - labelNumber.Text.IndexOf(".") > 2)
                            labelNumber.Text = labelNumber.Text.Substring(0, 4);
                    }



                    Calc.Clear_A();
                    FreeButtons(); //снятие нажатия всех кнопок мат.операций
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }

        private void buttonDouble_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "1/x"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = Calc.XDivision().ToString();

                if (labelNumber.Text.Contains(".")) // проверка на количество цифр после запятой 
                {
                    if (labelNumber.Text.Length - labelNumber.Text.IndexOf(".") > 2)
                        labelNumber.Text = labelNumber.Text.Substring(0, 4);
                }



                Calc.Clear_A(); // очистка первого операнда
                FreeButtons(); //снятие нажатия всех кнопок мат.операций
            }
        }

        private void buttonDel_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "DEL"
        {
            if (labelNumber.Text.Length != 0)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);
            else return;
            if (labelNumber.Text.Length == 0)
                labelNumber.Text = "0";
        }

        private void buttonSin_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "sin"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = Calc.Sinus().ToString();

                if (labelNumber.Text.Contains(".")) // проверка на количество цифр после запятой 
                {
                    if (labelNumber.Text.Length - labelNumber.Text.IndexOf(".") > 2)
                        labelNumber.Text = labelNumber.Text.Substring(0, 4);
                }



                Calc.Clear_A(); // очистка первого операнда
                FreeButtons(); //снятие нажатия всех кнопок мат.операций
            }
        }

        private void buttonCos_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "cos"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = Calc.Cosinus().ToString();

                if (labelNumber.Text.Contains(".")) // проверка на количество цифр после запятой 
                {
                    if (labelNumber.Text.Length - labelNumber.Text.IndexOf(".") > 2)
                        labelNumber.Text = labelNumber.Text.Substring(0, 4);
                }

                

                Calc.Clear_A(); // очистка первого операнда
                FreeButtons(); //снятие нажатия всех кнопок мат.операций
            }
        }

        private void buttonMul_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "x"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMul.Enabled = false;
                labelNumber.Text = "0";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "-"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMinus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "+"
        {
            if (CanPress()) // Если не нажата другая кнопка математической операции
            {
                toDouble();
                Calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonPlus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonSign_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "+/-"
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки ","
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }

        private void buttonCalc_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "="
        {

            if(labelNumber.Text.Contains(','))
                toDouble();

            if (!buttonMul.Enabled) // Если кнопка была нажата
                labelNumber.Text = Calc.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDiv.Enabled)
                labelNumber.Text = Calc.Division(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonPlus.Enabled)
                labelNumber.Text = Calc.Sum(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonMinus.Enabled)
                labelNumber.Text = Calc.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();

            Calc.Clear_A(); // очистка первого операнда
            FreeButtons(); //снятие нажатия всех кнопок мат.операций
            if (labelNumber.Text.Contains(",")) // проверка на количество цифр после запятой 
            {
                if (labelNumber.Text.Length - labelNumber.Text.IndexOf(",") > 2)
                    labelNumber.Text = labelNumber.Text.Substring(0, 3);
            }
        }

        //удаляем лишний ноль впереди числа, если таковой имеется
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);

        }

        private bool MaxMinNumber() // метод для проверки диапазона вводимого числа
        {
            if ((Convert.ToDouble(labelNumber.Text)) > 1000000 || (Convert.ToDouble(labelNumber.Text)) < -1000000)
                return false;
            if (labelNumber.Text.Contains(","))
            {
                if (labelNumber.Text.Length - labelNumber.Text.IndexOf(",") > 2)
                    return false;
            }
            return true;
        }

        //снятие нажатия всех кнопок мат.операций
        private void FreeButtons()
        {
            buttonMul.Enabled = true;
            buttonDiv.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
        }

        private void toDouble()
        {
            if (labelNumber.Text.Contains(","))
            {
                labelNumber.Text = labelNumber.Text.Replace(',', '.');
            }
        }

        //проверяет не нажата ли еще какая-либо из кнопок мат.операций
        private bool CanPress()
        {
            if (!buttonMul.Enabled)
                return false;

            if (!buttonDiv.Enabled)
                return false;

            if (!buttonPlus.Enabled)
                return false;

            if (!buttonMinus.Enabled)
                return false;

            return true;
        }
    }
}
