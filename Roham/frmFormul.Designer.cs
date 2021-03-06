namespace Roham
{
    partial class frmFormul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormul));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.cmbColorGroup = new System.Windows.Forms.ComboBox();
            this.txtColorDesc = new System.Windows.Forms.TextBox();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtBaseColor = new System.Windows.Forms.TextBox();
            this.lstBaseColor = new System.Windows.Forms.ListBox();
            this.lstWeight = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Base Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color Desription";
            // 
            // cmbMake
            // 
            this.cmbMake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(136, 18);
            this.cmbMake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(159, 22);
            this.cmbMake.TabIndex = 0;
            this.cmbMake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMake_KeyDown);
            // 
            // cmbColorGroup
            // 
            this.cmbColorGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbColorGroup.FormattingEnabled = true;
            this.cmbColorGroup.Location = new System.Drawing.Point(136, 78);
            this.cmbColorGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbColorGroup.Name = "cmbColorGroup";
            this.cmbColorGroup.Size = new System.Drawing.Size(159, 22);
            this.cmbColorGroup.TabIndex = 2;
            this.cmbColorGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbColorGroup_KeyDown);
            // 
            // txtColorDesc
            // 
            this.txtColorDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorDesc.Location = new System.Drawing.Point(137, 462);
            this.txtColorDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorDesc.Multiline = true;
            this.txtColorDesc.Name = "txtColorDesc";
            this.txtColorDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtColorDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtColorDesc.Size = new System.Drawing.Size(402, 120);
            this.txtColorDesc.TabIndex = 9;
            // 
            // txtColorCode
            // 
            this.txtColorCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtColorCode.Location = new System.Drawing.Point(136, 109);
            this.txtColorCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(159, 22);
            this.txtColorCode.TabIndex = 3;
            this.txtColorCode.Enter += new System.EventHandler(this.txtColorCode_Enter);
            this.txtColorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorCode_KeyDown);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(270, 237);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 22);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.Enter += new System.EventHandler(this.txtWeight_Enter);
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            // 
            // txtBaseColor
            // 
            this.txtBaseColor.Location = new System.Drawing.Point(136, 237);
            this.txtBaseColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBaseColor.Name = "txtBaseColor";
            this.txtBaseColor.Size = new System.Drawing.Size(132, 22);
            this.txtBaseColor.TabIndex = 5;
            this.txtBaseColor.Enter += new System.EventHandler(this.txtBaseColor_Enter);
            this.txtBaseColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBaseColor_KeyDown);
            // 
            // lstBaseColor
            // 
            this.lstBaseColor.FormattingEnabled = true;
            this.lstBaseColor.ItemHeight = 14;
            this.lstBaseColor.Location = new System.Drawing.Point(137, 258);
            this.lstBaseColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBaseColor.Name = "lstBaseColor";
            this.lstBaseColor.Size = new System.Drawing.Size(131, 172);
            this.lstBaseColor.TabIndex = 7;
            this.lstBaseColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBaseColor_MouseUp);
            // 
            // lstWeight
            // 
            this.lstWeight.FormattingEnabled = true;
            this.lstWeight.ItemHeight = 14;
            this.lstWeight.Location = new System.Drawing.Point(270, 258);
            this.lstWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstWeight.Name = "lstWeight";
            this.lstWeight.Size = new System.Drawing.Size(132, 172);
            this.lstWeight.TabIndex = 8;
            this.lstWeight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstWeight_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(137, 700);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 24);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total = ";
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(137, 48);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(158, 22);
            this.cmbCompany.TabIndex = 1;
            this.cmbCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCompany_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 14);
            this.label10.TabIndex = 28;
            this.label10.Text = "Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 14);
            this.label7.TabIndex = 29;
            this.label7.Text = "Unit";
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(137, 141);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(159, 22);
            this.cmbUnit.TabIndex = 30;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(272, 438);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 14);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0";
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(136, 590);
            this.txtUsage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsage.Multiline = true;
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsage.Size = new System.Drawing.Size(402, 90);
            this.txtUsage.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 31;
            this.label9.Text = "Usage";
            // 
            // cmbBase
            // 
            this.cmbBase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(137, 173);
            this.cmbBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(159, 22);
            this.cmbBase.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 14);
            this.label11.TabIndex = 33;
            this.label11.Text = "Base";
            // 
            // frmFormul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(559, 736);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUsage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstWeight);
            this.Controls.Add(this.lstBaseColor);
            this.Controls.Add(this.txtBaseColor);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.txtColorDesc);
            this.Controls.Add(this.cmbColorGroup);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFormul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرمول جدید";
            this.Load += new System.EventHandler(this.frmFormul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.ComboBox cmbColorGroup;
        private System.Windows.Forms.TextBox txtColorDesc;
        private System.Windows.Forms.TextBox txtColorCode;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtBaseColor;
        private System.Windows.Forms.ListBox lstBaseColor;
        private System.Windows.Forms.ListBox lstWeight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.Label label11;
    }
}