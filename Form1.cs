namespace Modul3_103022400074
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Celcuis");
            comboBox1.Items.Add("Fahrenheit");
            comboBox1.Items.Add("Kelvin");
            comboBox1.Items.Add("Reamur");

            comboBox2.Items.Add("Celcuis");
            comboBox2.Items.Add("Fahrenheit");
            comboBox2.Items.Add("Kelvin");
            comboBox2.Items.Add("Reamur");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null) {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                    return;
            }
            if (textBox1.Text == "") {
                MessageBox.Show("Masukan angka yang valid!");
                return;
            }
            double nilai = Convert.ToDouble(textBox1.Text);

            String a = comboBox1.SelectedItem.ToString();
            String b = comboBox2.SelectedItem.ToString();

            double celcius = nilai;

            if (a == "Fahrenheit")
                celcius = (nilai - 32) * 5 / 9;
            else if (a == "Kelvin")
                celcius = nilai - 273.15;
            else if (a == "Reamur")
                celcius = nilai * 5 / 4;

            double hasil = celcius;

            if (b == "Fahrenheit")
                hasil = (celcius * 9 / 5) + 32;
            else if (b == "Kelvin")
                hasil = celcius + 273.15;
            else if (b == "Reamur")
                hasil = celcius * 4 / 5;

            textBox2.Text = hasil.ToString();
        }
    }
}
