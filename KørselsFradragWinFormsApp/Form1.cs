using MyLibrary;


namespace KørselsFradragWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mindreEnd0 = Convert.ToInt32(numericUpDown1.Value);
            int mindreEnd01 = Convert.ToInt32(numericUpDown2.Value);
            if (mindreEnd0 <= 0 || mindreEnd01 <= 0)
            {
                MessageBox.Show("Advarsel, dit indtastet tal skal være større end 0");
                button1.Text = "UDREGN";
            }
            else
            {
                var fradragsberegner = new CalculateFradrag();
                var t = fradragsberegner.RunCalulationOfFradrag((int)numericUpDown1.Value, (int)numericUpDown2.Value);

                textBox1.Text = t.ToString();
                button1.Text = "PRØV IGEN";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALT EGERSKAB AF DETTE SOFTWARE GÅR TIL LUZICODE. ÆNDRING AF SOURCE CODE, UDEN AT GIVE CREDIT VIL BLIVE SET SOM EN FORBRYDELSE.");
        }
    }
}