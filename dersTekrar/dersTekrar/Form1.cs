namespace dersTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers= new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text),Convert.ToInt32(mesaiTxt.Text), comboBox1.Text );

            if (string.IsNullOrEmpty(adTxt.Text))
            {
                MessageBox.Show("Ad Soyad Bo� B�rak�lamaz!");
            }
            else if (string.IsNullOrEmpty(adresTxt.Text))
            {
                MessageBox.Show("Adres Bo� B�rak�lamaz!");
            }
            else if (string.IsNullOrEmpty(mesaiTxt.Text))
            {
                MessageBox.Show("Mesai Bo� B�rak�lamaz!");
            }
            else if (string.IsNullOrEmpty(yasTxt.Text))
            {
                MessageBox.Show("Ya� Bo� B�rak�lamaz!");
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Bir �nvan Se�iniz!");
            }

            


            if (comboBox1.Text == "���i")
            {
                MessageBox.Show(pers.ucretHesapla().ToString());
            }
            else
                {
                        pers.ucretHesapla(1000);
                }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("���i");
            comboBox1.Items.Add("M�hendis");
        }

        
    }
}