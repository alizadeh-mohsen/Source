using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Roham
{
    public partial class frmEditFomrul : Form
    {
        public int ColorId { get; set; }

        public frmEditFomrul()
        {
            InitializeComponent();
            cmbMake.DataSource = DbHelper.LoadDataSet("SelectCarAndCompany").Tables[0];
            cmbMake.DisplayMember = "Car";
            cmbMake.ValueMember = "ID";

            cmbColorType.DataSource = DbHelper.LoadDataSet("SelectTypes").Tables[0];
            cmbColorType.DisplayMember = "Type";
            cmbColorType.ValueMember = "ID";

            cmbUnit.DataSource = DbHelper.LoadDataSet("SelectUnit").Tables[0];
            cmbUnit.DisplayMember = "Name";
            cmbUnit.ValueMember = "ID";

            cmbBase.DataSource = DbHelper.LoadDataSet("SelectBase").Tables[0];
            cmbBase.DisplayMember = "Name";
            cmbBase.ValueMember = "ID";
        }

        private void frmEditFomrul_Load(object sender, EventArgs e)
        {
            GetResult();
        }

        private void GetResult()
        {
            lstBaseColor.Items.Clear();
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

                    txtColorCode.Text = colorInfo["Code"].ToString();
                    cmbUnit.SelectedValue = colorInfo["UnitId"].ToString();
                    if (!(colorInfo["BaseId"] is DBNull))
                        cmbBase.SelectedValue = colorInfo["BaseId"].ToString();

                    lblUnit.Text = cmbUnit.Text;
                    cmbMake.SelectedValue = colorInfo["CarID"].ToString();
                    cmbColorType.SelectedValue = colorInfo["ColorTypeID"].ToString();

                    dtDate.Text = !(colorInfo["LastUpdate"] is DBNull) &&
                                  !string.IsNullOrEmpty(colorInfo["LastUpdate"].ToString())
                        ? DbHelper.GregorianToShamsi(DateTime.Parse(colorInfo["LastUpdate"].ToString()))
                        : string.Empty;
                    chkLock.Checked = (bool)colorInfo["Lock"];
                    txtDesc.Text = colorInfo["Comment"].ToString();
                    txtUsage.Text = colorInfo["Usage"].ToString();
                    txtAccuracy.Text = colorInfo["Accuracy"].ToString();


                    if (formulTable.Rows.Count > 0)
                    {
                        float total = 0;
                        foreach (DataRow drFormul in formulTable.Rows)
                        {
                            lstBaseColor.Items.Add(drFormul["Code"].ToString());
                            lstWeight.Items.Add(string.Format(Helper.NumberFormatInfo, drFormul["Weight"]));
                            total += float.Parse(drFormul["Weight"].ToString());

                        }

                        txtBuildBase.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("فرمولی برای این نوع رنگ وارد نشده.", "فرمول یافت نشد", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }

                    if (chkLock.Checked)
                    {
                        if (MessageBox.Show("فرمول انتخابی لاک شده است. آیا ادامه می دهید؟", "",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) ==
                   DialogResult.No)
                        {
                            Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" : خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void lstWeight_MouseUp(object sender, MouseEventArgs e)
        {
            if (lstWeight.SelectedIndex != -1)
            {
                if (txtBaseColor.Text == string.Empty && txtWeight.Text == string.Empty)
                {
                    int index = lstWeight.SelectedIndex;
                    txtWeight.Text = lstWeight.SelectedItem.ToString();
                    txtBaseColor.Text = lstBaseColor.Items[index].ToString();
                    lstWeight.Items.RemoveAt(index);
                    lstBaseColor.Items.RemoveAt(index);
                    txtBuildBase.Text = UpdateBaseWeight();
                    txtBaseColor.Focus();
                }
            }
        }

        private void lstBaseColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (lstBaseColor.SelectedIndex != -1)
            {
                if (txtBaseColor.Text == string.Empty && txtWeight.Text == string.Empty)
                {
                    int index = lstBaseColor.SelectedIndex;
                    txtBaseColor.Text = lstBaseColor.SelectedItem.ToString();
                    txtWeight.Text = lstWeight.Items[index].ToString();
                    lstBaseColor.Items.RemoveAt(index);
                    lstWeight.Items.RemoveAt(index);
                    txtBuildBase.Text = UpdateBaseWeight();
                    txtBaseColor.Focus();
                }
            }
        }

        private void txtBaseColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtWeight.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("بیس کد و وزن انتخابی حذف خواهند شد. آیا ادامه می دهید؟", "حذف بیس کد",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) ==
                    DialogResult.Yes)
                {
                    txtBaseColor.Text = txtWeight.Text = "";
                }
            }
        }

        private string UpdateBaseWeight()
        {
            float sum = lstWeight.Items.Cast<object>().Sum(t => float.Parse(t.ToString()));
            return sum.ToString();
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBaseColor.Text != string.Empty)
                {
                    try
                    {
                        float.Parse(txtWeight.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("وزن وارد شده صحیح نیست", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        txtWeight.Focus();
                        return;
                    }

                    lstBaseColor.Items.Add(txtBaseColor.Text);
                    lstWeight.Items.Add(txtWeight.Text);
                    txtBaseColor.Text = txtWeight.Text = string.Empty;

                    txtBuildBase.Text = UpdateBaseWeight();
                    txtBaseColor.Focus();
                }
                else
                {
                    MessageBox.Show("ابتدا مادر رنگ را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    txtBaseColor.Focus();
                }
            }
        }

        private void deleteFormulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("آیا از حذف این فرمول مطمئن هستید؟", "حذف فرمول", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) ==
                DialogResult.No)
            {
                return;
            }

            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {

                SqlCommand com = new SqlCommand("DeleteFormul", dbConnection) { CommandType = CommandType.StoredProcedure };
                com.Parameters.AddWithValue("@colorId", ColorId);
                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("فرمول با موفقیت حذف شد", "حذف فرمول", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {
                SqlCommand com = dbConnection.CreateCommand();
                com.CommandType = CommandType.StoredProcedure;
                try
                {
                    com.CommandText = "UpdateColor";

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@ColorID", ColorId);
                    com.Parameters.AddWithValue("@CarID", cmbMake.SelectedValue);
                    com.Parameters.AddWithValue("@ColorTypeID", cmbColorType.SelectedValue);
                    com.Parameters.AddWithValue("@code", txtColorCode.Text.Trim());
                    com.Parameters.AddWithValue("@comment", txtDesc.Text.Trim());
                    com.Parameters.AddWithValue("@Lock", chkLock.Checked ? 1 : 0);
                    com.Parameters.AddWithValue("@LastUpdate", dtDate.Value ?? DateTime.Today.Date);
                    com.Parameters.AddWithValue("@unitId", cmbUnit.SelectedValue);
                    com.Parameters.AddWithValue("@baseId", cmbBase.SelectedValue);
                    com.Parameters.AddWithValue("@accuracy", txtAccuracy.Text.Trim());
                    com.Parameters.AddWithValue("@usage", txtUsage.Text.Trim());

                    com.ExecuteNonQuery();
                    MessageBox.Show("اطلاعات رنگ با موفقیت آپدیت شد", "ویرایش رنگ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }

            }
        }

        private void updateFormulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstWeight.Items.Count == 0 || lstBaseColor.Items.Count == 0)
            {
                MessageBox.Show("فرمول را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                txtBaseColor.Focus();
                return;
            }

            if (txtBaseColor.Text != string.Empty || txtWeight.Text != string.Empty)
            {
                MessageBox.Show("فرمولی وجود دارد که وارد نشده است", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                txtBaseColor.Focus();
                return;
            }
            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {
                SqlCommand com = dbConnection.CreateCommand();
                com.CommandType = CommandType.StoredProcedure;
                try
                {
                    com.CommandText = "DeleteFormulForEdit";
                    com.Parameters.AddWithValue("@ColorID", ColorId);
                    com.ExecuteNonQuery();

                    com.CommandText = "UpdateFormul";
                    for (int i = 0; i < lstBaseColor.Items.Count; i++)
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@ColorID", ColorId);
                        com.Parameters.AddWithValue("@Code", lstBaseColor.Items[i]);
                        com.Parameters.AddWithValue("@weight", lstWeight.Items[i]);

                        com.ExecuteNonQuery();
                    }

                    MessageBox.Show("فرمول با موفقیت آپدیت شد", "ویرایش فرمول", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }

            }
        }
    }
}
