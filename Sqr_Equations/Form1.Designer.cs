namespace Sqr_Equations
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
            this.coeffGroup = new System.Windows.Forms.GroupBox();
            this.CBox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.ABox = new System.Windows.Forms.TextBox();
            this.clabel = new System.Windows.Forms.Label();
            this.blabel = new System.Windows.Forms.Label();
            this.alabel = new System.Windows.Forms.Label();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.x2Box = new System.Windows.Forms.TextBox();
            this.x1Box = new System.Windows.Forms.TextBox();
            this.x2label = new System.Windows.Forms.Label();
            this.x1label = new System.Windows.Forms.Label();
            this.manageGroup = new System.Windows.Forms.GroupBox();
            this.ClassRadio = new System.Windows.Forms.RadioButton();
            this.MethodRadio = new System.Windows.Forms.RadioButton();
            this.ListenerRadio = new System.Windows.Forms.RadioButton();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.coeffGroup.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.manageGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // coeffGroup
            // 
            this.coeffGroup.Controls.Add(this.CBox);
            this.coeffGroup.Controls.Add(this.BBox);
            this.coeffGroup.Controls.Add(this.ABox);
            this.coeffGroup.Controls.Add(this.clabel);
            this.coeffGroup.Controls.Add(this.blabel);
            this.coeffGroup.Controls.Add(this.alabel);
            this.coeffGroup.Location = new System.Drawing.Point(13, 13);
            this.coeffGroup.Name = "coeffGroup";
            this.coeffGroup.Size = new System.Drawing.Size(125, 133);
            this.coeffGroup.TabIndex = 0;
            this.coeffGroup.TabStop = false;
            this.coeffGroup.Text = "Коэффициенты";
            // 
            // CBox
            // 
            this.CBox.Location = new System.Drawing.Point(34, 97);
            this.CBox.MaxLength = 6;
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(68, 20);
            this.CBox.TabIndex = 5;
            this.CBox.TextChanged += new System.EventHandler(this.CBox_TextChanged);
            // 
            // BBox
            // 
            this.BBox.Location = new System.Drawing.Point(33, 63);
            this.BBox.MaxLength = 6;
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(69, 20);
            this.BBox.TabIndex = 4;
            this.BBox.TextChanged += new System.EventHandler(this.BBox_TextChanged);
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(33, 27);
            this.ABox.MaxLength = 6;
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(69, 20);
            this.ABox.TabIndex = 3;
            this.ABox.TextChanged += new System.EventHandler(this.ABox_TextChanged);
            // 
            // clabel
            // 
            this.clabel.AutoSize = true;
            this.clabel.Location = new System.Drawing.Point(6, 100);
            this.clabel.Name = "clabel";
            this.clabel.Size = new System.Drawing.Size(22, 13);
            this.clabel.TabIndex = 2;
            this.clabel.Text = "с =";
            // 
            // blabel
            // 
            this.blabel.AutoSize = true;
            this.blabel.Location = new System.Drawing.Point(5, 66);
            this.blabel.Name = "blabel";
            this.blabel.Size = new System.Drawing.Size(22, 13);
            this.blabel.TabIndex = 1;
            this.blabel.Text = "в =";
            // 
            // alabel
            // 
            this.alabel.AutoSize = true;
            this.alabel.Location = new System.Drawing.Point(6, 30);
            this.alabel.Name = "alabel";
            this.alabel.Size = new System.Drawing.Size(22, 13);
            this.alabel.TabIndex = 0;
            this.alabel.Text = "а =";
            this.alabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.x2Box);
            this.resultGroup.Controls.Add(this.x1Box);
            this.resultGroup.Controls.Add(this.x2label);
            this.resultGroup.Controls.Add(this.x1label);
            this.resultGroup.Location = new System.Drawing.Point(163, 13);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Size = new System.Drawing.Size(128, 133);
            this.resultGroup.TabIndex = 1;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Результат";
            // 
            // x2Box
            // 
            this.x2Box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.x2Box.Location = new System.Drawing.Point(38, 66);
            this.x2Box.MaxLength = 6;
            this.x2Box.Name = "x2Box";
            this.x2Box.ReadOnly = true;
            this.x2Box.Size = new System.Drawing.Size(72, 20);
            this.x2Box.TabIndex = 3;
            // 
            // x1Box
            // 
            this.x1Box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.x1Box.Location = new System.Drawing.Point(38, 30);
            this.x1Box.MaxLength = 6;
            this.x1Box.Name = "x1Box";
            this.x1Box.ReadOnly = true;
            this.x1Box.Size = new System.Drawing.Size(72, 20);
            this.x1Box.TabIndex = 2;
            // 
            // x2label
            // 
            this.x2label.AutoSize = true;
            this.x2label.Location = new System.Drawing.Point(6, 66);
            this.x2label.Name = "x2label";
            this.x2label.Size = new System.Drawing.Size(24, 13);
            this.x2label.TabIndex = 1;
            this.x2label.Text = "х2=";
            // 
            // x1label
            // 
            this.x1label.AutoSize = true;
            this.x1label.Location = new System.Drawing.Point(7, 30);
            this.x1label.Name = "x1label";
            this.x1label.Size = new System.Drawing.Size(24, 13);
            this.x1label.TabIndex = 0;
            this.x1label.Text = "х1=";
            this.x1label.Click += new System.EventHandler(this.label4_Click);
            // 
            // manageGroup
            // 
            this.manageGroup.Controls.Add(this.ClassRadio);
            this.manageGroup.Controls.Add(this.MethodRadio);
            this.manageGroup.Controls.Add(this.ListenerRadio);
            this.manageGroup.Controls.Add(this.ExitBtn);
            this.manageGroup.Controls.Add(this.ResetBtn);
            this.manageGroup.Controls.Add(this.CalculateBtn);
            this.manageGroup.Location = new System.Drawing.Point(13, 168);
            this.manageGroup.Name = "manageGroup";
            this.manageGroup.Size = new System.Drawing.Size(278, 124);
            this.manageGroup.TabIndex = 2;
            this.manageGroup.TabStop = false;
            this.manageGroup.Text = "Управление";
            // 
            // ClassRadio
            // 
            this.ClassRadio.AutoSize = true;
            this.ClassRadio.Location = new System.Drawing.Point(6, 81);
            this.ClassRadio.Name = "ClassRadio";
            this.ClassRadio.Size = new System.Drawing.Size(55, 17);
            this.ClassRadio.TabIndex = 11;
            this.ClassRadio.TabStop = true;
            this.ClassRadio.Text = "класс";
            this.ClassRadio.UseVisualStyleBackColor = true;
            // 
            // MethodRadio
            // 
            this.MethodRadio.AutoSize = true;
            this.MethodRadio.Location = new System.Drawing.Point(6, 54);
            this.MethodRadio.Name = "MethodRadio";
            this.MethodRadio.Size = new System.Drawing.Size(56, 17);
            this.MethodRadio.TabIndex = 10;
            this.MethodRadio.TabStop = true;
            this.MethodRadio.Text = "метод";
            this.MethodRadio.UseVisualStyleBackColor = true;
            this.MethodRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ListenerRadio
            // 
            this.ListenerRadio.AutoSize = true;
            this.ListenerRadio.Location = new System.Drawing.Point(6, 27);
            this.ListenerRadio.Name = "ListenerRadio";
            this.ListenerRadio.Size = new System.Drawing.Size(83, 17);
            this.ListenerRadio.TabIndex = 9;
            this.ListenerRadio.TabStop = true;
            this.ListenerRadio.Text = "обработчик";
            this.ListenerRadio.UseVisualStyleBackColor = true;
            this.ListenerRadio.CheckedChanged += new System.EventHandler(this.ListenerRadio_CheckedChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(185, 81);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(185, 54);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Сброс";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(185, 27);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Вычислить";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 320);
            this.Controls.Add(this.manageGroup);
            this.Controls.Add(this.resultGroup);
            this.Controls.Add(this.coeffGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Sqr Equation Solver";
            this.coeffGroup.ResumeLayout(false);
            this.coeffGroup.PerformLayout();
            this.resultGroup.ResumeLayout(false);
            this.resultGroup.PerformLayout();
            this.manageGroup.ResumeLayout(false);
            this.manageGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox coeffGroup;
        private System.Windows.Forms.TextBox CBox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.Label clabel;
        private System.Windows.Forms.Label blabel;
        private System.Windows.Forms.Label alabel;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.Label x2label;
        private System.Windows.Forms.Label x1label;
        private System.Windows.Forms.TextBox x2Box;
        private System.Windows.Forms.TextBox x1Box;
        private System.Windows.Forms.GroupBox manageGroup;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.RadioButton ClassRadio;
        private System.Windows.Forms.RadioButton MethodRadio;
        private System.Windows.Forms.RadioButton ListenerRadio;
    }
}

