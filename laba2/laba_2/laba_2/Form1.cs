using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace laba_2
{
    public partial class Form1 : Form
    {
        public double a = 0, b = 0, c = 0, x1, x2, D;
        public static readonly double err = 999999;
        equation calc = new equation();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //обработка ввода
        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {

           string s = checkInput(textBoxA.Text+e.KeyChar);
            if (e.KeyChar != 8)
            {
                if (s == null) { e.KeyChar = (char)Keys.None; }
            }
        }
        //обработка ввода
        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = checkInput(textBoxB.Text + e.KeyChar);
            if (e.KeyChar != 8)
            {
                if (s == null) { e.KeyChar = (char)Keys.None; }
            }
        }
        //обработка ввода
        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = checkInput(textBoxC.Text + e.KeyChar);
            if (e.KeyChar != 8)
            {
                if (s == null) { e.KeyChar = (char)Keys.None; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //вычисление квадратного уравнения
        private void buttonComput_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//обработчик
            {
                if (textBoxA.Text != "")
                {
                    a = double.Parse(textBoxA.Text);
                }

                if (textBoxB.Text != "")
                {
                    b = double.Parse(textBoxB.Text);
                }

                if (textBoxC.Text != "")
                {
                    c = double.Parse(textBoxC.Text);
                }

                //если а = 0
                if (0 == a && b != 0 && c != 0)
                {
                    x1 = -c / b;
                    x2 = err;
                    D = err;
                    MessageBox.Show("a = 0");
                }
                //если b = 0
                if (0 == b && a != 0 && c != 0)
                {
                    D = err;
                    if ((-c / a) < 0)
                    {   //вычисление комплексных корней при b = 0
                        x1 = Math.Sqrt((-c / a) * -1);
                        x2 = Math.Sqrt((-c / a) * -1) * -1;
                        MessageBox.Show("b = 0 \n" + "x1 = " + x1 + "i\n" + "x2 = " + x2 + "i");
                    }
                    else
                    {
                        x1 = Math.Sqrt(-c / a);
                        x2 = x1 * (-1);
                        MessageBox.Show("b = 0");
                    }
                }
                //если c = 0
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

                    if (D < 0)//дискриминант отрицательный
                    {
                        MessageBox.Show("Отрицательный дискриминант");
                        double m, n;
                        m = -b / (2 * a);
                        n = Math.Abs(Math.Sqrt(-D) / (2 * a));
                        MessageBox.Show("\nx1 = " + m + " + i*" + n + "\nx2 = " + m + " -i*" + n);
                    }
                    else
                    {
                        if (D == 0)//дискриминант равен нулю
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

                if (x1 != err)
                {
                    textBoxX1.Text = x1.ToString();
                }
                if (x2 != err)
                {
                    textBoxX2.Text = x2.ToString();
                }
            }
            if (radioButton2.Checked)// вычисление в методе класса формы
            {
                if (textBoxA.Text != "")
                {
                    a = double.Parse(textBoxA.Text);
                }

                if (textBoxB.Text != "")
                {
                    b = double.Parse(textBoxB.Text);
                }

                if (textBoxC.Text != "")
                {
                    c = double.Parse(textBoxC.Text);
                }

                quadrat();


                if (x1 != err)
                {
                    textBoxX1.Text = x1.ToString();
                }
                if (x2 != err)
                {
                    textBoxX2.Text = x2.ToString();
                }
            }
            if (radioButton3.Checked)//вычисление в отдельном классе
            {
                if (textBoxA.Text != "")
                {
                    calc.a = double.Parse(textBoxA.Text);
                }

                if (textBoxB.Text != "")
                {
                    calc.b = double.Parse(textBoxB.Text);
                }

                if (textBoxC.Text != "")
                {
                    calc.c = double.Parse(textBoxC.Text);
                }

                calc.calculate();

                if (calc.x1 != equation.err)
                {
                    textBoxX1.Text = calc.x1.ToString();
                }
                if (calc.x2 != equation.err)
                {
                    textBoxX2.Text = calc.x2.ToString();
                }

            }

        }

        //очистка полей
        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxX1.Clear();
            textBoxX2.Clear();
        }

        //проверка корректности ввода
        private string checkInput(string s)
        {
            Regex reg = new Regex(@"^[+-]?\d{1,9}[,.]?\d{0,5}$");

            if (s == "+" || s == "-")
                return s;
            if (s.Length != 0)
            {      // проверка на соответствие шаблону       
                if (reg.IsMatch(s))   
                {
                    // если в строке  есть точка                      
                    if (s.IndexOf('.', 0, s.Length) != (-1))
                    {  // то точку заменить на запятую                           
                        s = Regex.Replace(s, @"\.", ",");     
                    }          

                }
                else
                    return null;
            }
            return s;
        }   
        
        //вычисление уравнения в классе формы
        private void quadrat()
        {
            if (0 == a && b != 0 && c != 0)
            {
                x1 = -c / b;
                x2 = err;
                D = err;
                MessageBox.Show("a = 0");
            }

            if (0 == b && a != 0 && c != 0)
            {
                D = err;
                if ((-c / a) < 0)
                {
                    x1 = Math.Sqrt((-c / a) * -1);
                    x2 = Math.Sqrt((-c / a) * -1) * -1;
                    MessageBox.Show("b = 0 \n" + "x1 = " + x1 + "i\n" + "x2 = " + x2 + "i");
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

                if (D < 0)//дискриминант отрицательный
                {
                    MessageBox.Show("Отрицательный дискриминант");
                    double m, n;
                    m = -b / (2 * a);
                    n = Math.Abs(Math.Sqrt(-D) / (2 * a));
                    MessageBox.Show("\nx1 = " + m + " + i*" + n + "\nx2 = " + m + " -i*" + n);
                }
                else
                {
                    if (D == 0)//дискриминант равен нулю
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


    }
}
