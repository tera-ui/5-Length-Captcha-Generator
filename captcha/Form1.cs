namespace captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
        string[] sembol2 = { "+", "-", "*", "/", "!", "#", "?" };
        string[] sembol3 = { "A", "B", "C", "D", "E", "F", "G" };
        int s1, s2, s3, s4, s5;
        private void Form1_Load(object sender, EventArgs e)
        {


            Random rnd = new Random();
            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, sembol3.Length);
            s4 = rnd.Next(10, 21);
            s5 = rnd.Next(0, 10);
            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + s4.ToString() + s5.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            Random rnd = new Random();
            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, sembol3.Length);
            s4 = rnd.Next(10, 21);
            s5 = rnd.Next(0, 10);
            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + s4.ToString() + s5.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text)
            {
                MessageBox.Show("Giriş Başarılı. Uygulamaya Yönlendiriliyorsunuz...");
            }
            else
            {
                MessageBox.Show("Geçersiz Captcha. Lütfen Tekrar Deneyiniz...");
                Application.Exit();
            }


        }

       
    }
}