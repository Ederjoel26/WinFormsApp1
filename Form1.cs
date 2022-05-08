namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        private int contador1 = 0;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            preguntas(40, 10, 30, 20, 2, textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            contador -= contador1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            preguntas(30, 10, 30, 40, 3, textBox2);
        }

        private void preguntas(int a, int b, int c, int d, int tab, TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Debes introducir tu respuesta.");
            }
            else
            {
                string x = textBox.Text.ToLower();
                char[] caracteres = x.ToCharArray();
                if (caracteres.Length > 1)
                {
                    MessageBox.Show("Introduce un valor válido.");
                }
                else
                {
                    char letra = caracteres[0];
                    switch (letra)
                    {
                        case 'a':
                            contador += a;
                            contador1 = a;
                            MessageBox.Show("Respuesta registrada exitosamente!");
                            tabControl1.SelectTab(tab);
                            break;
                        case 'b':
                            contador += b;
                            contador1 = b;
                            MessageBox.Show("Respuesta registrada exitosamente!");
                            tabControl1.SelectTab(tab);
                            break;
                        case 'c':
                            contador += c;
                            contador1 = c;
                            MessageBox.Show("Respuesta registrada exitosamente!");
                            tabControl1.SelectTab(tab);
                            break;
                        case 'd':
                            contador += d;
                            contador1 = d;
                            MessageBox.Show("Respuesta registrada exitosamente!");
                            tabControl1.SelectTab(tab);
                            break;
                        default:
                            MessageBox.Show("Introduce una respuesta valida.");
                            break;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            preguntas(20, 40, 10, 30, 4, textBox3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            preguntas(40, 30, 10, 20, 5, textBox4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            preguntas(40, 30, 10, 20, 6, textBox5);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            preguntas(10, 30, 20, 40, 7, textBox6);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            preguntas(10, 20, 30, 40, 8, textBox7);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            preguntas(40, 30, 20, 10, 9, textBox8);
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            preguntas(10, 40, 20, 30, 10, textBox9);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            preguntas(10, 30, 40, 20, 10, textBox9);
            if (contador >= 100 && contador <= 240)
            {
                tabControl1.SelectTab(11);
            }
            else 
            {
                tabControl1.SelectTab(12);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            contador -= contador1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            contador -= contador1;
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
            contador -= contador1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            contador -= contador1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            contador -= contador1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
            contador -= contador1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
            contador -= contador1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
            contador -= contador1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
