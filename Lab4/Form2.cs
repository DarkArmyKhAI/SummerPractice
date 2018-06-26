using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4 {
    public partial class Form2 : Form {

        public string ArrayParams = "";
        public int[,] Source;
        public int[,] Result;
        public int N;

        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            textBox1.Text = ArrayParams;

            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = N;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            for(int i = 0; i < N; i++) {
                string[] temp = new string[N];
                for(int j = 0; j < N; j++)
                    temp[j] = Source[i,j].ToString();
                dataGridView1.Rows.Add(temp);
            }
            dataGridView1.Refresh();

            dataGridView2.Columns.Clear();
            dataGridView2.ColumnCount = N;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            for(int i = 0; i < N; i++) {
                string[] temp = new string[N];
                for(int j = 0; j < N; j++)
                    try {
                        temp[j] = Result[i, j].ToString();
                    } catch {
                        temp[j] = " ";
                    }
                dataGridView2.Rows.Add(temp);
            }
        }
    }
}
