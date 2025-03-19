using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listView1.Selected)
            {
                case 0:
                    textBox1.Text = "1700";
                    break;
                case 1:
                    textBox1.Text = "1200";
                    break;
                case 2:
                    textBox1.Text = "700";
                    break;
                case 3:
                    textBox1.Text = "550";
                    break;
                case 5:
                    textBox1.Text = "1900";
                    break;
                case 6:
                    textBox1.Text = "1000";
                    break;
                case 7:
                    textBox1.Text = "850";
                    break;
                case 8:
                    textBox1.Text = "650";
                    break;



            }
        }
    }
}
