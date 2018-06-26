using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4{
    public partial class Form1 : Form{

        public Fmas array;
        private Form2 display;

        public Form1(){
            InitializeComponent();
            array = new Fmas(1, 0, 0);
            display = new Form2();
        }

        private void button1_Click(object sender, EventArgs e){
            array = new Fmas((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            display.ArrayParams = "N = " + numericUpDown1.Value + "; A = " + numericUpDown2.Value + "; B = " + numericUpDown3.Value;
            display.Source = array.FA;
            display.N = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e) {
            display.Result = array.Func2((int)numericUpDown4.Value);
            display.ArrayParams += "; * In result array: first column represents row index, second - column index";
        }

        private void button3_Click(object sender, EventArgs e) {
            display.Result = array.Func1();
        }

        private void button4_Click(object sender, EventArgs e) {
            display.Result = array.Func3((int)numericUpDown5.Value, (int)numericUpDown6.Value);
        }

        private void button5_Click(object sender, EventArgs e){
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    array.Deserialize(openFileDialog1.FileName);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    array.Serialize(saveFileDialog1.FileName);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e) {

            Form frm = new Form();
            frm.Text = "Info";
            frm.Height = 100;
            frm.Width = 250;
            frm.StartPosition = FormStartPosition.CenterParent;
            Label view = new Label();
            frm.Controls.Add(view);
            view.Text = "Gerlyts Roman\nGroup 525\nr.gerlyts@csn.student.khai.edu";
            view.Height = 100;
            view.Width = 200;
            view.Location = new Point(6, 6);
            frm.ShowDialog(this);

            frm.Dispose();
        }

        private void button8_Click(object sender, EventArgs e) {
            display.ShowDialog();
        }

    }
}
