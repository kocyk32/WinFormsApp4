namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ZmienneGlobalne.ZG4 = ZmienneGlobalne.ZG1;
            textBox1.Text = ZmienneGlobalne.ZG4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bMonitory_Click(object sender, EventArgs e)
        {

        }
    }
}
