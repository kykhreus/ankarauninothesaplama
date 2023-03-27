namespace Not_hesaplama
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;

            vize = Convert.ToDouble(Vize.Text);

            final = Convert.ToDouble(Final.Text);

            ortalama = vize * 0.3 + final * 0.8;
            tortalama.Text = ortalama.ToString();

            if (ortalama > 0 && ortalama < 50)
            {
                tdurum.Text = "Ortalamanýz: F2 (Kaldý) ";
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                tdurum.Text = "Ortalamanýz: F1 (Kaldý) ";
            }
            else if (ortalama >= 60 && ortalama < 65)
            {
                tdurum.Text = "Ortalamanýz: C3 (Geçti) ";
            }
            else if (ortalama >= 65 && ortalama < 70)
            {
                tdurum.Text = "Ortalamanýz: C2 (Geçti) ";
            }
            else if (ortalama >= 70 && ortalama < 75)
            {
                tdurum.Text = "Ortalamanýz: C1 (Geçti) ";
            }
            else if (ortalama >= 75 && ortalama < 80)
            {
                tdurum.Text = "Ortalamanýz: B3 (Geçti) ";
            }
            else if (ortalama >= 80 && ortalama < 85)
            {
                tdurum.Text = "Ortalamanýz: B2 (Geçti) ";
            }
            else if (ortalama >= 85 && ortalama < 90)
            {
                tdurum.Text = "Ortalamanýz: B1 (Geçti) ";
            }
            else if (ortalama >= 90 && ortalama < 100)
            {
                tdurum.Text = "Ortalamanýz: A/A+ (Geçti) ";
            }
            else if (ortalama >= 100 && ortalama <= 110)
            {
                tdurum.Text = "Ortalamanýz: A/A+ (Geçti) ";
            }
            else if (ortalama > 110)
            {
                tdurum.Text = "Geçersiz not bilgisi girdiniz. ";
            }


            Console.Read();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}