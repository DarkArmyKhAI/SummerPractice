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

namespace laba_01_Calculator
{
    public partial class Form1 : Form
    {
        // хранение первого значения 
        public double a;
        // хранение второго значения 
        public double t;
        //поле хранения результата 
        public double b;
        //поле для выбора операции
        public char c;
        bool check = true;
        string s_text = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {  
                a = double.Parse(textBox1.Text);
                
            }
            c = '+';

            textBox1.Clear();
           
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {   
                a = double.Parse(textBox1.Text);
            }

            c = '-';

            textBox1.Clear();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {   
                a = double.Parse(textBox1.Text);
            }

            c = '*';

            textBox1.Clear();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {   
                a = double.Parse(textBox1.Text);
            }

            c = '/';

            textBox1.Clear();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {   
                a = double.Parse(textBox1.Text);
            }

            c = '^';

           
        }

        private void Cosinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {   
                a = double.Parse(textBox1.Text);
            }
            c = 'c';

            
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {   
                a = double.Parse(textBox1.Text);
            }

            c = '!';

            
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            check = true;
        }
        
        //вычисления
        public void Calc()
        {
            switch (c)
            {
                case '+':
                    if(textBox1.Text != "")
                    {
                        t = double.Parse(textBox1.Text);
                        b = a + t;
                        textBox1.Clear();
                        check = false;
                        textBox1.Text = b.ToString();
                        check = true;
                    }
                    break;
                case '-':
                    if (textBox1.Text != "")
                    {
                         t = double.Parse(textBox1.Text);
                        b = a - t;
                        textBox1.Clear();
                        check = false;
                        textBox1.Text = b.ToString();
                        check = true;
                   }
                    break;
                case '*':
                    if (textBox1.Text != "")
                    {
                         t = double.Parse(textBox1.Text);
                        b = a * t;
                        textBox1.Clear();
                        check = false;
                        textBox1.Text = b.ToString();
                        check = true;
                    }
                    break;
                case '/':
                    if (textBox1.Text != "" )
                    {
                        
                        t = double.Parse(textBox1.Text);
                        
                        if(t == 0)
                        {
                            MessageBox.Show("Деление на ноль запрещено!");
                        }
                        else
                        {
                            b = a / t;
                            textBox1.Clear();
                            check = false;
                            textBox1.Text = b.ToString();
                            check = true;
                        }
                    }
                    break;
                case '^':
                    if (textBox1.Text != "")
                    {
                        double s; 
                        s = double.Parse(textBox1.Text);
                        if (s <= 0)
                        {
                            MessageBox.Show("error!");
                        }
                        else
                        {
                            if (textBox1.Text != "")
                            {
                                double t = double.Parse(textBox1.Text);
                                b = Math.Sqrt(t);
                                textBox1.Clear();
                                check = false;
                                textBox1.Text = b.ToString();
                                check = true;
                            }
                        }
                    }
                    
                    
                    break;
                case 'c':
                   if (textBox1.Text != "")
                   {
                         t = double.Parse(textBox1.Text);
                        b = Math.Cos(t);
                        textBox1.Clear();
                        check = false;
                        textBox1.Text = b.ToString();
                        check = true;
                   }
                    break;
                case '!':
                   if (textBox1.Text != "")
                   {
                        b = factorial(a);
                        textBox1.Clear();
                        check = false;
                        textBox1.Text = b.ToString();
                        check = true;
                   }
                    break;
            }
        }
        //Вычисление факториала
          private double  factorial(double i)
        {
            if (i <= 1)
                return 1;
            return i * factorial(i - 1);
        }

        //защита ввода, разрешены цифры, backspace, знак плюс и минус
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           string new_text = textBox1.Text;
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 45)
            {
                e.Handled = true;   
            }
        }
        //защита ввода, ограничение диапазона вводимых чисел, запрет ввода двух минусов или плюсов
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           textBox1.KeyPress += textBox1_KeyPress;
           string sent = @"^(\+|\-)?\d{0,12}$";
           string new_text = textBox1.Text;
           double number;
            if (new_text != "-" && new_text != "+")
                try
                {
                    number = double.Parse(textBox1.Text);
                }
                catch
                {
                    number = 0;
                }
            else
                number = 0;
            if (check)
            {
               
                if (Regex.IsMatch(new_text, sent)&&(number >= -100000) && (number <= 500000))
                {
                    s_text = new_text;
                }
                else
                    textBox1.Text = s_text;
            }

            // переход в конец строки
            textBox1.Select(textBox1.Text.Length, 0);
        }

        //удаления одного символа 
        private void del_symvol_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
                check = true;
            }
            check = true;
        }
    }
}
