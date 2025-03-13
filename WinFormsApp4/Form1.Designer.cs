namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bKomputery = new Button();
            lKalkulator = new Label();
            lTekst = new Label();
            bMonitory = new Button();
            lWaluta = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // bKomputery
            // 
            bKomputery.Location = new Point(12, 176);
            bKomputery.Name = "bKomputery";
            bKomputery.Size = new Size(139, 58);
            bKomputery.TabIndex = 0;
            bKomputery.Text = "Komputery";
            bKomputery.UseVisualStyleBackColor = true;
            bKomputery.Click += button1_Click;
            // 
            // lKalkulator
            // 
            lKalkulator.AutoSize = true;
            lKalkulator.Location = new Point(124, 9);
            lKalkulator.Name = "lKalkulator";
            lKalkulator.Size = new Size(207, 15);
            lKalkulator.TabIndex = 1;
            lKalkulator.Text = "Kalkulator Zestawów Komputerowych";
            lKalkulator.Click += label1_Click;
            // 
            // lTekst
            // 
            lTekst.AutoSize = true;
            lTekst.Location = new Point(364, 176);
            lTekst.Name = "lTekst";
            lTekst.Size = new Size(34, 15);
            lTekst.TabIndex = 2;
            lTekst.Text = "Cena";
            lTekst.Click += label2_Click;
            // 
            // bMonitory
            // 
            bMonitory.Location = new Point(166, 176);
            bMonitory.Name = "bMonitory";
            bMonitory.Size = new Size(139, 58);
            bMonitory.TabIndex = 3;
            bMonitory.Text = "Monitory";
            bMonitory.UseVisualStyleBackColor = true;
            // 
            // lWaluta
            // 
            lWaluta.AutoSize = true;
            lWaluta.Location = new Point(374, 221);
            lWaluta.Name = "lWaluta";
            lWaluta.Size = new Size(15, 15);
            lWaluta.TabIndex = 5;
            lWaluta.Text = "zł";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 357);
            Controls.Add(textBox1);
            Controls.Add(lWaluta);
            Controls.Add(bMonitory);
            Controls.Add(lTekst);
            Controls.Add(lKalkulator);
            Controls.Add(bKomputery);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bKomputery;
        private Label lKalkulator;
        private Label lTekst;
        private Button bMonitory;
        private Label lWaluta;
        private TextBox textBox1;
    }
}
