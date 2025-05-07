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
            if (listView1.SelectedIndices.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                switch (index)
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wynik;
            int temp1;
            temp1 = int.Parse(textBox1.Text);
            wynik = temp1;
            ZmienneGlobalne.ZG2 = wynik.ToString();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
