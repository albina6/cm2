namespace cm2
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
            this.inputT = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.countOperatorsTB = new System.Windows.Forms.TextBox();
            this.wTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tPTB = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Label();
            this.nTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputT
            // 
            this.inputT.Location = new System.Drawing.Point(77, 34);
            this.inputT.Name = "inputT";
            this.inputT.Size = new System.Drawing.Size(100, 20);
            this.inputT.TabIndex = 0;
            this.inputT.Text = "480";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(525, 31);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Вычислить";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(0, 19);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTB.Size = new System.Drawing.Size(575, 173);
            this.outputTB.TabIndex = 2;
            this.outputTB.TabStop = false;
            // 
            // countOperatorsTB
            // 
            this.countOperatorsTB.Location = new System.Drawing.Point(330, 35);
            this.countOperatorsTB.Name = "countOperatorsTB";
            this.countOperatorsTB.Size = new System.Drawing.Size(100, 20);
            this.countOperatorsTB.TabIndex = 3;
            this.countOperatorsTB.Text = "14";
            // 
            // wTB
            // 
            this.wTB.Location = new System.Drawing.Point(222, 244);
            this.wTB.Name = "wTB";
            this.wTB.Size = new System.Drawing.Size(100, 20);
            this.wTB.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tPTB);
            this.groupBox1.Controls.Add(this.count);
            this.groupBox1.Controls.Add(this.nTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.outputTB);
            this.groupBox1.Controls.Add(this.wTB);
            this.groupBox1.Location = new System.Drawing.Point(25, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 324);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "V(T)";
            this.label6.Visible = false;
            // 
            // vTB
            // 
            this.vTB.Location = new System.Drawing.Point(222, 286);
            this.vTB.Name = "vTB";
            this.vTB.Size = new System.Drawing.Size(100, 20);
            this.vTB.TabIndex = 12;
            this.vTB.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tp(T)";
            // 
            // tPTB
            // 
            this.tPTB.Location = new System.Drawing.Point(403, 287);
            this.tPTB.Name = "tPTB";
            this.tPTB.Size = new System.Drawing.Size(100, 20);
            this.tPTB.TabIndex = 10;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(364, 247);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(13, 13);
            this.count.TabIndex = 9;
            this.count.Text = "n";
            // 
            // nTB
            // 
            this.nTB.Location = new System.Drawing.Point(403, 244);
            this.nTB.Name = "nTB";
            this.nTB.Size = new System.Drawing.Size(100, 20);
            this.nTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "sT(T)";
            // 
            // sTB
            // 
            this.sTB.Location = new System.Drawing.Point(52, 244);
            this.sTB.Name = "sTB";
            this.sTB.Size = new System.Drawing.Size(100, 20);
            this.sTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "W(T)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кол-во операторов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.countOperatorsTB);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.inputT);
            this.Name = "Form1";
            this.Text = "Лабораторная работа по КМ. Выполнила Муратшина А.А.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputT;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.TextBox countOperatorsTB;
        private System.Windows.Forms.TextBox wTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox nTB;
        private System.Windows.Forms.TextBox tPTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vTB;
    }
}

