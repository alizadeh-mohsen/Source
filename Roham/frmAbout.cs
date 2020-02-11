using System.Diagnostics;
using System.Windows.Forms;

namespace Roham
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.roham-paint.ir");
        }
    }
}
