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
                tdurum.Text = "Ortalaman�z: F2 (Kald�) ";
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                tdurum.Text = "Ortalaman�z: F1 (Kald�) ";
            }
            else if (ortalama >= 60 && ortalama < 65)
            {
                tdurum.Text = "Ortalaman�z: C3 (Ge�ti) ";
            }
            else if (ortalama >= 65 && ortalama < 70)
            {
                tdurum.Text = "Ortalaman�z: C2 (Ge�ti) ";
            }
            else if (ortalama >= 70 && ortalama < 75)
            {
                tdurum.Text = "Ortalaman�z: C1 (Ge�ti) ";
            }
            else if (ortalama >= 75 && ortalama < 80)
            {
                tdurum.Text = "Ortalaman�z: B3 (Ge�ti) ";
            }
            else if (ortalama >= 80 && ortalama < 85)
            {
                tdurum.Text = "Ortalaman�z: B2 (Ge�ti) ";
            }
            else if (ortalama >= 85 && ortalama < 90)
            {
                tdurum.Text = "Ortalaman�z: B1 (Ge�ti) ";
            }
            else if (ortalama >= 90 && ortalama < 100)
            {
                tdurum.Text = "Ortalaman�z: A/A+ (Ge�ti) ";
            }
            else if (ortalama >= 100 && ortalama <= 110)
            {
                tdurum.Text = "Ortalaman�z: A/A+ (Ge�ti) ";
            }
            else if (ortalama > 110)
            {
                tdurum.Text = "Ge�ersiz not bilgisi girdiniz. ";
            }


            Console.Read();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}