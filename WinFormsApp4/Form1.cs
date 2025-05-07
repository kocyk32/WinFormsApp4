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
            int liczba1 = int.TryParse(ZmienneGlobalne.ZG1, out int wynik1) ? wynik1 : 0;
            int liczba2 = int.TryParse(ZmienneGlobalne.ZG2, out int wynik2) ? wynik2 : 0;
            int suma = liczba1 + liczba2;
            textBox1.Text = suma.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bMonitory_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
