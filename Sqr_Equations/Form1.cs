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

namespace Sqr_Equations
{
    public partial class Form1 : Form
    {
        double a, b, c, x1,x2; // коэффициенты и корни
        bool isComplex; // комплексное решение

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void ABox_TextChanged(object sender, EventArgs e)
        {
            ABox.Text = Validate(ABox.Text); // валидация коэффициента А
        }

        public string Validate(string str) // метод валидации
        {
            string pattern = @"[+|-]?\d+[\.|\,]?[\d+]{0,4}";
            Match m = Regex.Match(str, pattern);
            return m.Value;
        }

        private void BBox_TextChanged(object sender, EventArgs e)
        {
            BBox.Text = Validate(BBox.Text); // валидация коэффициента В
        }

        private void CBox_TextChanged(object sender, EventArgs e)
        {
            CBox.Text = Validate(CBox.Text); // валидация коэффициента С
        }

        private void OnClickCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e) // полный сброс флагов
        {
            isComplex = false;
            a = b = c = x1 = x2 = 0;
            ABox.Text = BBox.Text = CBox.Text = "";
            ListenerRadio.Checked = MethodRadio.Checked = ClassRadio.Checked = false;
            x2Box.Text = x1Box.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //закрываем приложение
        }

        private void ListenerRadio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            isComplex = false;

            if(ABox.Text == "" || BBox.Text=="" || CBox.Text=="") // обработка пустых коэффициентов
            {
                MessageBox.Show("нужны все коэффициенты");
                return;
            }

            if (!parseCoeffs()) // не удалось распарсить коэффициенты
            {
                MessageBox.Show("плохие коэффициенты(");
                return;
            }

            if (a==0 || b ==0 || c == 0) // обработка нулевых коэффициентов
            {
                MessageBox.Show("только полные квадратные уравнения");
                return;
            }

            if (ListenerRadio.Checked) // решаем кв уравнение заданным путем
            {
                double d = b*b - (4 * a * c);
                string x1s = "";
                string x2s = "";

                if (d < 0)
                {
                    isComplex = true;
                    d *= -1;

                    x1s += String.Format("{0:0.00}", -b / 2 * a) + "+" + String.Format("{0:0.00}", Math.Sqrt(d) / 2 * a) + "*i";
                    x2s += String.Format("{0:0.00}", -b / 2 * a) + "-" + String.Format("{0:0.00}", Math.Sqrt(d) / 2 * a) + "*i";
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;

                    x1s = String.Format("{0:0.0000}", x1);
                    x2s = String.Format("{0:0.0000}", x2); ;

                }

                x1Box.Text = x1s;
                x2Box.Text = x2s;
            }
            else if(MethodRadio.Checked)
            {
                SolveSqrEquation();
            }
            else if(ClassRadio.Checked)
            {
                SqrSolver sqrSolver = new SqrSolver(a, b, c);
                isComplex = sqrSolver.Solve(out x1, out x2);

                string x1s = "";
                string x2s = "";

                if (isComplex)
                {
                    x1s += String.Format("{0:0.00}", x1) + "+" + String.Format("{0:0.00}", x2) + "*i";
                    x2s += String.Format("{0:0.00}", x1) + "-" + String.Format("{0:0.00}", x2) + "*i";
                }
                else
                {
                    x1s = String.Format("{0:0.0000}", x1);
                    x2s = String.Format("{0:0.0000}", x2);
                }

                x1Box.Text = x1s;
                x2Box.Text = x2s;
            }
            else // если путь не задали - сообщаем об этом
            {
                MessageBox.Show("нужно выбрать способ вычисления");
            }

        }

        public bool parseCoeffs() // парсинг коэффициентов
        {
            try
            {
                a = double.Parse(ABox.Text);
                b = double.Parse(BBox.Text);
                c = double.Parse(CBox.Text);
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public void SolveSqrEquation() // метод решения кв уравнения
        {
            double d = b*b - (4 * a * c);
            string x1s = "";
            string x2s = "";

            if (d < 0)
            {
                isComplex = true;
                d *= -1;

                x1s += String.Format("{0:0.00}",-b / 2 * a) + "+" + String.Format("{0:0.00}", Math.Sqrt(d) / 2 * a) + "*i";
                x2s += String.Format("{0:0.00}", -b / 2 * a) + "-" + String.Format("{0:0.00}", Math.Sqrt(d) / 2 * a) + "*i";
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;

                x1s = String.Format("{0:0.0000}", x1);
                x2s = String.Format("{0:0.0000}", x2); ;
            }

            x1Box.Text = x1s;
            x2Box.Text = x2s;
        }
    }
}
