using System;
using System.Windows.Forms;
using Roham.Properties;

namespace Roham
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(Settings.Default.Password))
            {
                var form = new Main();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("پسورد وارد شده صحیح نیست", "ورود", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
