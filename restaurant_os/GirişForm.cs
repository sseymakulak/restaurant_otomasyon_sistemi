namespace restaurant_os
{
    public partial class Giri�Form : Form
    {
        public Giri�Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "sseyma" && txtpassword.Text == "221601037")
            {
                new MenuForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� yada �ifre hatal�.Tekrar deneyin");
                txtUsername.Clear();
                txtpassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}