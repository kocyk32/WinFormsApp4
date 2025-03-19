namespace WinFormsApp4
{
    partial class Form3
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
            ListViewItem listViewItem1 = new ListViewItem("AOC U2790PQU");
            ListViewItem listViewItem2 = new ListViewItem("LG UltraFine 27MD5KL-B");
            ListViewItem listViewItem3 = new ListViewItem("Asus ProArt PA279CV");
            ListViewItem listViewItem4 = new ListViewItem("Acer Predator XB273K");
            ListViewItem listViewItem5 = new ListViewItem("BenQ PD3200U");
            ListViewItem listViewItem6 = new ListViewItem("Samsung Odyssey G7");
            label1 = new Label();
            textBox1 = new TextBox();
            lWaluta = new Label();
            lTekst = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 13;
            label1.Text = "Monitory";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 29;
            // 
            // lWaluta
            // 
            lWaluta.AutoSize = true;
            lWaluta.Location = new Point(133, 315);
            lWaluta.Name = "lWaluta";
            lWaluta.Size = new Size(15, 15);
            lWaluta.TabIndex = 28;
            lWaluta.Text = "zł";
            // 
            // lTekst
            // 
            lTekst.AutoSize = true;
            lTekst.Location = new Point(123, 270);
            lTekst.Name = "lTekst";
            lTekst.Size = new Size(34, 15);
            lTekst.TabIndex = 27;
            lTekst.Text = "Cena";
            // 
            // listView1
            // 
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem1.UseItemStyleForSubItems = false;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            listView1.Location = new Point(12, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 204);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 336);
            Controls.Add(textBox1);
            Controls.Add(lWaluta);
            Controls.Add(lTekst);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label lWaluta;
        private Label lTekst;
        private ListView listView1;
    }
}