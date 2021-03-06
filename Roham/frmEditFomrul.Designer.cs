namespace Roham
{
    partial class frmEditFomrul
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFomrul));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteFormulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFormulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDate = new Atf.UI.DateTimeSelector();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.cmbColorType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLock = new System.Windows.Forms.CheckBox();
            this.txtBuildBase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtBaseColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lstBaseColor = new System.Windows.Forms.ListBox();
            this.lstWeight = new System.Windows.Forms.ListBox();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFormulToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.updateFormulToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteFormulToolStripMenuItem
            // 
            this.deleteFormulToolStripMenuItem.Name = "deleteFormulToolStripMenuItem";
            this.deleteFormulToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.deleteFormulToolStripMenuItem.Text = "Delete Formul";
            this.deleteFormulToolStripMenuItem.Click += new System.EventHandler(this.deleteFormulToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.saveToolStripMenuItem.Text = "Update Color";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // updateFormulToolStripMenuItem
            // 
            this.updateFormulToolStripMenuItem.Name = "updateFormulToolStripMenuItem";
            this.updateFormulToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.updateFormulToolStripMenuItem.Text = "Update Formul";
            this.updateFormulToolStripMenuItem.Click += new System.EventHandler(this.updateFormulToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbBase);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtAccuracy);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUsage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtDate);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbMake);
            this.panel1.Controls.Add(this.cmbColorType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbUnit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtColorCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkLock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 697);
            this.panel1.TabIndex = 21;
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(102, 245);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(121, 22);
            this.txtAccuracy.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 62;
            this.label7.Text = "Accuracy:";
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtUsage.Location = new System.Drawing.Point(102, 273);
            this.txtUsage.Multiline = true;
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsage.Size = new System.Drawing.Size(360, 119);
            this.txtUsage.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 60;
            this.label6.Text = "Usage:";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(102, 156);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(120, 23);
            this.dtDate.TabIndex = 59;
            this.dtDate.UsePersianFormat = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 14);
            this.label12.TabIndex = 57;
            this.label12.Text = "Last Update:";
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(102, 95);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(121, 22);
            this.cmbMake.TabIndex = 56;
            // 
            // cmbColorType
            // 
            this.cmbColorType.FormattingEnabled = true;
            this.cmbColorType.Location = new System.Drawing.Point(102, 126);
            this.cmbColorType.Name = "cmbColorType";
            this.cmbColorType.Size = new System.Drawing.Size(121, 22);
            this.cmbColorType.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 14);
            this.label10.TabIndex = 54;
            this.label10.Text = "Color Type:";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(102, 64);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 22);
            this.cmbUnit.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 52;
            this.label9.Text = "Unit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "Make:";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(102, 33);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(176, 22);
            this.txtColorCode.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "Color Code:";
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(0, 470);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(0);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDesc.Size = new System.Drawing.Size(465, 225);
            this.txtDesc.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "Description:";
            // 
            // chkLock
            // 
            this.chkLock.AutoSize = true;
            this.chkLock.Location = new System.Drawing.Point(12, 188);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(57, 18);
            this.chkLock.TabIndex = 45;
            this.chkLock.Text = "Lock";
            this.chkLock.UseVisualStyleBackColor = true;
            // 
            // txtBuildBase
            // 
            this.txtBuildBase.Enabled = false;
            this.txtBuildBase.Location = new System.Drawing.Point(154, 317);
            this.txtBuildBase.Name = "txtBuildBase";
            this.txtBuildBase.Size = new System.Drawing.Size(106, 22);
            this.txtBuildBase.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 14);
            this.label8.TabIndex = 43;
            this.label8.Text = "Build Base:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblUnit);
            this.panel2.Controls.Add(this.txtBaseColor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtWeight);
            this.panel2.Controls.Add(this.txtBuildBase);
            this.panel2.Controls.Add(this.lstBaseColor);
            this.panel2.Controls.Add(this.lstWeight);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(473, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 697);
            this.panel2.TabIndex = 59;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(264, 321);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(31, 14);
            this.lblUnit.TabIndex = 60;
            this.lblUnit.Text = "xxx";
            // 
            // txtBaseColor
            // 
            this.txtBaseColor.Location = new System.Drawing.Point(21, 35);
            this.txtBaseColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBaseColor.Name = "txtBaseColor";
            this.txtBaseColor.Size = new System.Drawing.Size(132, 22);
            this.txtBaseColor.TabIndex = 22;
            this.txtBaseColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBaseColor_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Base Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(155, 35);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 22);
            this.txtWeight.TabIndex = 24;
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            // 
            // lstBaseColor
            // 
            this.lstBaseColor.FormattingEnabled = true;
            this.lstBaseColor.ItemHeight = 14;
            this.lstBaseColor.Location = new System.Drawing.Point(21, 56);
            this.lstBaseColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBaseColor.Name = "lstBaseColor";
            this.lstBaseColor.Size = new System.Drawing.Size(132, 242);
            this.lstBaseColor.TabIndex = 25;
            this.lstBaseColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBaseColor_MouseUp);
            // 
            // lstWeight
            // 
            this.lstWeight.FormattingEnabled = true;
            this.lstWeight.ItemHeight = 14;
            this.lstWeight.Location = new System.Drawing.Point(155, 56);
            this.lstWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstWeight.Name = "lstWeight";
            this.lstWeight.Size = new System.Drawing.Size(132, 242);
            this.lstWeight.TabIndex = 26;
            this.lstWeight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstWeight_MouseUp);
            // 
            // cmbBase
            // 
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(102, 215);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(121, 22);
            this.cmbBase.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 14);
            this.label11.TabIndex = 64;
            this.label11.Text = "Base:";
            // 
            // frmEditFomrul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(793, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditFomrul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش فرمول";
            this.Load += new System.EventHandler(this.frmEditFomrul_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteFormulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.ComboBox cmbColorType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuildBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColorCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkLock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBaseColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ListBox lstBaseColor;
        private System.Windows.Forms.ListBox lstWeight;
        private Atf.UI.DateTimeSelector dtDate;
        private System.Windows.Forms.ToolStripMenuItem updateFormulToolStripMenuItem;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtAccuracy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.Label label11;
    }
}