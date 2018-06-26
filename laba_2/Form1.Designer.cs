namespace laba_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label_c = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.buttonComput = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxC);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.label_c);
            this.groupBox1.Controls.Add(this.label_b);
            this.groupBox1.Controls.Add(this.label_a);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(63, 85);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxC_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(63, 58);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxB_KeyPress);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(63, 31);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(7, 88);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(25, 13);
            this.label_c.TabIndex = 2;
            this.label_c.Text = "c = ";
            this.label_c.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(7, 61);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(25, 13);
            this.label_b.TabIndex = 1;
            this.label_b.Text = "b = ";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(7, 34);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(22, 13);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "a =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxX2);
            this.groupBox2.Controls.Add(this.textBoxX1);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(63, 60);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.ReadOnly = true;
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 3;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(63, 33);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(7, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(30, 13);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "x2 = ";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(7, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(30, 13);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "x1 = ";
            // 
            // buttonComput
            // 
            this.buttonComput.Location = new System.Drawing.Point(287, 152);
            this.buttonComput.Name = "buttonComput";
            this.buttonComput.Size = new System.Drawing.Size(75, 23);
            this.buttonComput.TabIndex = 5;
            this.buttonComput.Text = "Вычислить";
            this.buttonComput.UseVisualStyleBackColor = true;
            this.buttonComput.Click += new System.EventHandler(this.buttonComput_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(287, 196);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Очистить ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(85, 158);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(146, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Решение в обработчике";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Решение в классе формы";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(85, 204);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(176, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Решение в отдельном классе";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonComput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Button buttonComput;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

