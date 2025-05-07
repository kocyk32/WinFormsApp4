using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "150";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "250";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "400";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "550";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wynik;
            int temp1;
            int temp2;
            temp1 = int.Parse(textBox1.Text);
            temp2 = int.Parse(textBox2.Text);
            wynik = temp1 + temp2;
            ZmienneGlobalne.ZG1 = wynik.ToString();
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
