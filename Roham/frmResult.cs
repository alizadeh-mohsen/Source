using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Roham
{
    public partial class frmResult : Form
    {
        private int carId;
        private int colorTypeId;
        public int ColorId { get; set; }

        #region Code
        public frmResult()
        {
            InitializeComponent();


        }
        private void frmResult_Load(object sender, EventArgs e)
        {
            GetFormul();
            GetUnits();
        }

        private void GetUnits()
        {
            flpUnits.Controls.Clear();

            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {
                SqlCommand com = new SqlCommand("GetColorUnits", dbConnection) { CommandType = CommandType.StoredProcedure };
                com.Parameters.AddWithValue("@colorCode", lblColorCode.Text.Trim());


                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    foreach (DataRow unit in ds.Tables[0].Rows)
                    {
                        RadioButton rb = new RadioButton
                        {
                            Tag = unit.ItemArray[0].ToString(),
                            Text = unit.ItemArray[1].ToString(),
                            Checked = unit.ItemArray[1].ToString() == lblUnit.Text,

                        };
                        rb.CheckedChanged += Rb_CheckedChanged;
                        flpUnits.Controls.Add(rb);
                    }
                    Controls.Add(flpUnits);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" : خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {

            lstColor.Items.Clear();
            lstWeight.Items.Clear();

            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {
                SqlCommand com = new SqlCommand("GetCodeInfoByUnitId", dbConnection) { CommandType = CommandType.StoredProcedure };
                com.Parameters.AddWithValue("@code", lblColorCode.Text.Trim());
                com.Parameters.AddWithValue("@unitId", int.Parse(((RadioButton)sender).Tag.ToString()));


                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    DataTable formulTable = ds.Tables[0];

                    if (formulTable.Rows.Count > 0)
                    {
                        float total = 0;
                        foreach (DataRow drFormul in formulTable.Rows)
                        {
                            lstColor.Items.Add(drFormul["Code"].ToString());
                            lstWeight.Items.Add(string.Format(Helper.NumberFormatInfo, drFormul["Weight"]));
                            total += float.Parse(drFormul["Weight"].ToString());
                        }
                        lblTotal.Text = txtBuildBase.Text = lblUnit.Text.Contains("gr") ? string.Format(Helper.NumberFormatInfo, total) : string.Format(Helper.NumberFormatInfo, total);
                    }
                    else
                    {
                        MessageBox.Show("فرمولی برای این نوع رنگ وارد نشده.", "فرمول یافت نشد", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" : خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void GetFormul()
        {
            lstColor.Items.Clear();
            lstWeight.Items.Clear();

            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {
                SqlCommand com = new SqlCommand("GetCodeInfo", dbConnection) { CommandType = CommandType.StoredProcedure };
                com.Parameters.AddWithValue("@colorId", ColorId);


                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    DataRow colorInfo = ds.Tables[0].Rows[0];
                    DataTable formulTable = ds.Tables[1];

                    lblColorCode.Text = colorInfo["Code"].ToString();
                    lblUnit.Text = colorInfo["Name"].ToString();
                    lblBase.Text = colorInfo["BaseName"].ToString();
                    lblMake.Text = colorInfo["Car"].ToString();
                    lblColorType.Text = colorInfo["Type"].ToString();
                    lblLastUpdate.Text = colorInfo["LastUpdate"] != null &&
                                         !string.IsNullOrEmpty(colorInfo["LastUpdate"].ToString())
                        ? DbHelper.GregorianToShamsi((DateTime)colorInfo["LastUpdate"])
                        : string.Empty;

                    chkLock.Checked = (bool)colorInfo["Lock"];
                    txtDescription.Text = colorInfo["Comment"].ToString();
                    lblAccuracy.Text = colorInfo["Accuracy"].ToString();
                    txtUsage.Text = colorInfo["Usage"].ToString();

                    if (formulTable.Rows.Count > 0)
                    {
                        float total = 0;
                        foreach (DataRow drFormul in formulTable.Rows)
                        {
                            lstColor.Items.Add(drFormul["Code"].ToString());
                            lstWeight.Items.Add(string.Format(Helper.NumberFormatInfo, drFormul["Weight"]));
                            total += float.Parse(drFormul["Weight"].ToString());
                        }
                        lblTotal.Text = txtBuildBase.Text = lblUnit.Text.Contains("gr") ? string.Format("{0:0.#}", total) : string.Format(Helper.NumberFormatInfo, total);
                    }
                    else
                    {
                        MessageBox.Show("فرمولی برای این نوع رنگ وارد نشده.", "فرمول یافت نشد", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" : خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }
        private void btnEasyMix_Click(object sender, EventArgs e)
        {
            Mix();
        }
        private void lstWeight_MouseUp(object sender, MouseEventArgs e)
        {
            if (lstWeight.SelectedIndex != -1)
            {
                txtEasyMix.Text = lstWeight.SelectedItem.ToString();
                txtEasyMix.Focus();
            }
        }
        private void frmResult_Shown(object sender, EventArgs e)
        {
            txtBuildBase.Focus();
            txtBuildBase.SelectionStart = 0;
            txtBuildBase.SelectionLength = txtBuildBase.Text.Length;
        }
        private void txtBuildBase_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculate();
            }
        }
        private void txtEasyMix_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Mix();
            }
        }
        private void Calculate()
        {
            var total = 0f;
            for (int i = 0; i < lstWeight.Items.Count; i++)
            {
                float weitgh = float.Parse(lstWeight.Items[i].ToString());
                float newBase = float.Parse(txtBuildBase.Text.Trim());
                float buildBase = float.Parse(lblTotal.Text);
                lstWeight.Items[i] = lblUnit.Text.ToLower().Contains("gr") ? Math.Round(weitgh * newBase / buildBase, 1) : Math.Round(weitgh * newBase / buildBase, 2);
                total += float.Parse(lstWeight.Items[i].ToString());
            }
            lblTotal.Text = string.Format(Helper.NumberFormatInfo, total);
        }
        private void Mix()
        {
            var total = 0f;
            if (string.IsNullOrEmpty(txtEasyMix.Text.Trim()))
            {
                return;
            }
            var newValue = float.Parse(txtEasyMix.Text.Trim());
            var oldValue = float.Parse(lstWeight.SelectedItem.ToString());
            var rate = newValue / oldValue;

            for (int i = 0; i < lstWeight.Items.Count; i++)
            {
                lstWeight.Items[i] = lblUnit.Text.ToLower().Contains("gr") ? Math.Round(float.Parse(lstWeight.Items[i].ToString()) * rate, 1) : Math.Round(float.Parse(lstWeight.Items[i].ToString()) * rate, 2);
                total += float.Parse(lstWeight.Items[i].ToString());
            }
            lblTotal.Text = string.Format(Helper.NumberFormatInfo, total);
        }

        private void lstColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (lstColor.SelectedIndex != -1)
            {
                txtEasyMix.Text = lstWeight.Items[lstColor.SelectedIndex].ToString();
                txtEasyMix.Focus();
            }
        }

        #endregion

        #region Print
        private void printFomrulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstColor.Items.Count <= 0)
            {
                return;
            }
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintForFomrul;
            printDialog1.Document = printDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void printLableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstColor.Items.Count <= 0)
            {
                return;
            }
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintForLabel;
            printDialog1.Document = printDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintForLabel(object sender, PrintPageEventArgs e)
        {
            StringBuilder textToPrint = new StringBuilder();
            textToPrint.Append("\t\t\t\t\tفروشگاه رنگ رهام - شریفی \n");
            textToPrint.Append("\t\t\t\t\t    www.roham-paint.ir\n\n");
            textToPrint.Append("\tCustomer: \t\t\t\t\t\t\t\t" + "Tel:56366695\n\n");
            textToPrint.Append("\tColor code: " + lblColorCode.Text + "\t\t\t\t\t\t\t Mobile: \n\n");

            textToPrint.Append("\tWeight: " + string.Format(Helper.NumberFormatInfo, lblTotal.Text) + " " + lblUnit.Text +
                               "\t\t\t\t\t\t\t\t 09125245365\n\n");
            textToPrint.Append("___________________________________ (Notes) ___________________________________\n\n");
            textToPrint.Append("\t" + txtDescription.Text.Replace("\r\n", "\r\n\t") + "\n\n\n\n\n\n\n\n");

            textToPrint.Append("\t\t\t\t\tفروشگاه رنگ رهام - شریفی \n");
            textToPrint.Append("\t\t\t\t\t    www.roham-paint.ir\n\n");
            textToPrint.Append("\tCustomer:\t\t\t\t\t\t\t\t" + "Tel:56366695\n\n");
            textToPrint.Append("\tColor code:\t\t\t\t\t\t\t\t Mobile:\n\n");

            textToPrint.Append("\tWeight:\t\t\t\t\t\t\t\t 09125245365 \n\n");
            textToPrint.Append("___________________________________ (Notes) ___________________________________\n\n");
            Font font = new Font("Arail", 10f, FontStyle.Bold);
            e.Graphics.DrawString(textToPrint.ToString(), font, Brushes.Black, 30f, 20f);
        }
        private void PrintForFomrul(object sender, PrintPageEventArgs e)
        {
            StringBuilder textToPrint = new StringBuilder();

            textToPrint.Append("\t\t( " + lblMake.Text + " - " + lblColorCode.Text + " - " + lblColorType.Text + " )");
            Font font1 = new Font("Arial", 18f, FontStyle.Bold);
            e.Graphics.DrawString(textToPrint.ToString(), font1, Brushes.Black, 20f, 10f);
            textToPrint.Remove(0, textToPrint.Length);

            textToPrint.Append("\t\twww.roham-paint.ir");
            Font font2 = new Font("Arial", 12f, FontStyle.Bold);
            e.Graphics.DrawString(textToPrint.ToString(), font2, Brushes.Black, 180f, 40f);
            textToPrint.Remove(0, textToPrint.Length);

            textToPrint.Append("\t\t\tBaseCode    Weight \n");
            textToPrint.Append("\t\t\t______________\n");
            for (int i = 0; i < lstColor.Items.Count; i++)
            {
                textToPrint.Append("\t\t\t" + lstColor.Items[i] + "  --------  " + lstWeight.Items[i] + "\n");
            }
            textToPrint.Append("\t\t\t______________\n");
            textToPrint.Append("\t\t\t\t" + lblTotal.Text + " " + lblUnit.Text);
            Font font3 = new Font("Arial", 12f, FontStyle.Bold);
            e.Graphics.DrawString(textToPrint.ToString(), font3, Brushes.Black, 150f, 80f);
        }

        #endregion
    }
}