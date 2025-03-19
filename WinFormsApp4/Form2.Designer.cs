namespace WinFormsApp4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox1 = new TextBox();
            lWaluta = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            Sprawdz = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Komputer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Dyski";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Procesory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 292);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Reszta";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 178);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "SSD 256GB";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 203);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "SSD 512GB";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Intel Core i9-14900KF", "Intel Core i9-13900K", "Intel Core i5-12600K", "Intel Core i3-14100", "", "AMD Ryzen 7 9800X3D", "AMD Ryzen 5 7600", "AMD Ryzen 7 5700X3D", "AMD Ryzen 5 5500" });
            comboBox1.Location = new Point(12, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 228);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "SSD 1TB";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(12, 253);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "SSD 2TB";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lWaluta
            // 
            lWaluta.AutoSize = true;
            lWaluta.Location = new Point(235, 124);
            lWaluta.Name = "lWaluta";
            lWaluta.Size = new Size(15, 15);
            lWaluta.TabIndex = 10;
            lWaluta.Text = "zł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 211);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 12;
            label5.Text = "zł";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 23);
            textBox2.TabIndex = 11;
            // 
            // Sprawdz
            // 
            Sprawdz.Location = new Point(164, 267);
            Sprawdz.Name = "Sprawdz";
            Sprawdz.Size = new Size(75, 23);
            Sprawdz.TabIndex = 13;
            Sprawdz.Text = "Koszt";
            Sprawdz.UseVisualStyleBackColor = true;
            Sprawdz.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 385);
            Controls.Add(Sprawdz);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(lWaluta);
            Controls.Add(textBox1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox1;
        private Label lWaluta;
        private Label label5;
        private TextBox textBox2;
        private Button Sprawdz;
    }
}