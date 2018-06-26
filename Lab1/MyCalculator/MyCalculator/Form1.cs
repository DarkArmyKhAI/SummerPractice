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

namespace MyCalculator {
    public partial class Form1 : Form {

        string old_text = "", pattern = @"^(\+|\-)?\d{0,12}$";
        bool input_check = true;
        Calculator calc = new Calculator();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e) {
            print_number(1);
        }

        private void button2_Click(object sender, EventArgs e) {
            print_number(2);
        }

        private void button4_Click(object sender, EventArgs e) {
            print_number(4);
        }

        private void button5_Click(object sender, EventArgs e) {
            print_number(5);
        }

        private void button6_Click(object sender, EventArgs e) {
            print_number(6);
        }

        private void button7_Click(object sender, EventArgs e) {
            print_number(7);
        }

        private void button8_Click(object sender, EventArgs e) {
            print_number(8);
        }

        private void button9_Click(object sender, EventArgs e) {
            print_number(9);
        }

        private void button10_Click(object sender, EventArgs e) {
            print_number(0);
        }

        private void button3_Click(object sender, EventArgs e) {
            print_number(3);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {
            string new_text = textBox1.Text;
            double number;
            if(new_text != "-" && new_text != "+")
                try {
                    number = double.Parse(textBox1.Text);
                } catch {
                    number = 0;
                } 
            else
                number = 0;
            if(input_check) {
                // Проверяем корректность ввода
                if(Regex.IsMatch(new_text, pattern) && (number >= -10000) && (number <= 800000)) {
                    old_text = new_text;

                } else
                    textBox1.Text = old_text;
            }
            // Помещаем курсор в конец строки
            textBox1.Select(textBox1.Text.Length, 0);

        }

        private void button15_Click(object sender, EventArgs e) {
            if(textBox1.ReadOnly == true)
                return;
            try {
                textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) * -1);
            } catch (Exception ex) {
                if(textBox1.Text.Length != 0 && textBox1.Text != "-")
                    MessageBox.Show(ex.Message);
                else {
                    if(textBox1.Text == "-")
                        textBox1.Text = "";
                    else
                        textBox1.Text = "-";
                }
                    
            }
        }

        private void button12_Click(object sender, EventArgs e) {
            calculate();
        }

        private void button13_Click(object sender, EventArgs e) {
            calc.op = 'p';
            calculate();
        }

        private void button14_Click(object sender, EventArgs e) {
            operate('/');
        }

        private void button11_Click(object sender, EventArgs e) {
            clear_tb();
            calc.acc = 0;
            calc.op = '.';
        }

        private void button16_Click(object sender, EventArgs e) {
            calc.op = 's';
            calculate();
        }

        private void button21_Click(object sender, EventArgs e) {
            if(textBox1.ReadOnly == true)
                return;
            try {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            } catch(Exception ex) {
                if(textBox1.Text.Length != 0)
                    MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e) {
            calc.op = 'q';
            calculate();
        }

        private void button18_Click(object sender, EventArgs e) {
            operate('*');
        }

        private void button19_Click(object sender, EventArgs e) {
            operate('-');
        }

        private void button20_Click(object sender, EventArgs e) {
            operate('+');
        }

        private void operate(char op) {
            if(textBox1.Text.Length == 0)
                return;
            try {
                calc.acc = double.Parse(textBox1.Text);
                calc.op = op;
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            clear_tb();

        }

        private void calculate() {
            textBox1.ReadOnly = true;
            input_check = false;
            try {
                double value = calc.Calculate(double.Parse(textBox1.Text));
                if(value > 999999999999 || value < -999999999999) {
                    MessageBox.Show("Value is too big to display on screen!\n" + value);
                } else {
                    string result = Convert.ToString(value);
                    if(result.Length >= 12)
                        textBox1.Text = result.Substring(0, 12);
                    else
                        textBox1.Text = result;
                }
            } catch(Exception ex) {
                if(textBox1.Text.Length != 0)
                    MessageBox.Show(ex.Message);
            }
        }

        private void clear_tb() {
            try {
                textBox1.Text = "";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            input_check = true;
            textBox1.ReadOnly = false;
        }

        private void print_number(int n) {
            if(textBox1.ReadOnly == true)
                return;
            try {
                textBox1.Text = textBox1.Text + n.ToString();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
