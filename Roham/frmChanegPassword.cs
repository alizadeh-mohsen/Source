using System;
using System.Windows.Forms;
using Roham.Properties;

namespace Roham
{
    public partial class frmChanegPassword : Form
    {
        public frmChanegPassword()
        {
            InitializeComponent();
            txtOld.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oldPassword = Settings.Default.Password;
            if (!oldPassword.Equals(txtOld.Text.Trim()))
            {
                MessageBox.Show("پسورد فعلی صحیح نمیباشد", "تغییر پسورد", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            if (!txtNew.Text.Trim().Equals(txtRepeat.Text.Trim()))
            {
                MessageBox.Show("پسورد جدید با تکرار پسورد مغایرت دارد", "تغییر پسورد", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            Settings.Default.Password = txtNew.Text.Trim();
            Settings.Default.Save();
            
            MessageBox.Show("پسورد با موفقیت تغییر کرد.", "تغییر پسورد", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            Close();
        }
    }
}
