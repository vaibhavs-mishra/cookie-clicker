namespace CookieClicker
{
    public partial class Clicker : Form
    {
        int score;
        public Clicker()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                if (progressBar1.Value >= 2)
                {
                    progressBar1.Value -= 2;
                    label3.Text = "" + progressBar1.Value;
                }
            }
            else if (progressBar1.Value == 0)
            {
                progressBar1.Value = 0;
                label1.Text = "Game OVER!!!";
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0 && progressBar1.Value != 100)
            {
                try { progressBar1.Value += 5; }
                catch (Exception ex) { }
                score++;
                label2.Text = "Score: " + score;
            }
        }

        private void Clicker_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            timer1.Enabled = true;
        }
    }
}
