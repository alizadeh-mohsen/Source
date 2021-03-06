namespace Roham
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.label2 = new System.Windows.Forms.Label();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstColor = new System.Windows.Forms.ListBox();
            this.lstWeight = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printFomrulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblColorType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLock = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuildBase = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEasyMix = new System.Windows.Forms.Button();
            this.txtEasyMix = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.flpUnits = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color Code :";
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorCode.Location = new System.Drawing.Point(114, 32);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(35, 16);
            this.lblColorCode.TabIndex = 2;
            this.lblColorCode.Text = "xxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Make:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(298, 32);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(35, 16);
            this.lblMake.TabIndex = 5;
            this.lblMake.Text = "xxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Base Color";
            // 
            // lstColor
            // 
            this.lstColor.FormattingEnabled = true;
            this.lstColor.ItemHeight = 14;
            this.lstColor.Location = new System.Drawing.Point(484, 56);
            this.lstColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstColor.Name = "lstColor";
            this.lstColor.Size = new System.Drawing.Size(158, 270);
            this.lstColor.TabIndex = 8;
            this.lstColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstColor_MouseUp);
            // 
            // lstWeight
            // 
            this.lstWeight.FormattingEnabled = true;
            this.lstWeight.ItemHeight = 14;
            this.lstWeight.Location = new System.Drawing.Point(644, 56);
            this.lstWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstWeight.Name = "lstWeight";
            this.lstWeight.Size = new System.Drawing.Size(158, 270);
            this.lstWeight.TabIndex = 9;
            this.lstWeight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstWeight_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printFomrulToolStripMenuItem,
            this.printLableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printFomrulToolStripMenuItem
            // 
            this.printFomrulToolStripMenuItem.Name = "printFomrulToolStripMenuItem";
            this.printFomrulToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.printFomrulToolStripMenuItem.Text = "Print Formul";
            this.printFomrulToolStripMenuItem.Click += new System.EventHandler(this.printFomrulToolStripMenuItem_Click);
            // 
            // printLableToolStripMenuItem
            // 
            this.printLableToolStripMenuItem.Name = "printLableToolStripMenuItem";
            this.printLableToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.printLableToolStripMenuItem.Text = "Print Label";
            this.printLableToolStripMenuItem.Click += new System.EventHandler(this.printLableToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "Description :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblBase);
            this.groupBox1.Controls.Add(this.txtUsage);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblAccuracy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblColorType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkLock);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblLastUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblColorCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMake);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 619);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsage.ForeColor = System.Drawing.Color.Black;
            this.txtUsage.Location = new System.Drawing.Point(9, 181);
            this.txtUsage.Multiline = true;
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.ReadOnly = true;
            this.txtUsage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsage.Size = new System.Drawing.Size(449, 121);
            this.txtUsage.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 14);
            this.label14.TabIndex = 34;
            this.label14.Text = "Accuracy:";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracy.Location = new System.Drawing.Point(114, 121);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(35, 16);
            this.lblAccuracy.TabIndex = 33;
            this.lblAccuracy.Text = "xxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Usage:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 14);
            this.label11.TabIndex = 29;
            this.label11.Text = "Unit:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(298, 60);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(35, 16);
            this.lblUnit.TabIndex = 30;
            this.lblUnit.Text = "xxx";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Color Type :";
            // 
            // lblColorType
            // 
            this.lblColorType.AutoSize = true;
            this.lblColorType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorType.Location = new System.Drawing.Point(114, 60);
            this.lblColorType.Name = "lblColorType";
            this.lblColorType.Size = new System.Drawing.Size(35, 16);
            this.lblColorType.TabIndex = 28;
            this.lblColorType.Text = "xxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last Update:";
            // 
            // chkLock
            // 
            this.chkLock.AutoSize = true;
            this.chkLock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLock.Location = new System.Drawing.Point(248, 119);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(74, 20);
            this.chkLock.TabIndex = 23;
            this.chkLock.Text = "locked";
            this.chkLock.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(3, 349);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(455, 267);
            this.txtDescription.TabIndex = 22;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(114, 91);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(35, 16);
            this.lblLastUpdate.TabIndex = 21;
            this.lblLastUpdate.Text = "xxx";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(461, 495);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 148);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtBuildBase);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change base weight";
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(188, 65);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "New base:";
            // 
            // txtBuildBase
            // 
            this.txtBuildBase.Location = new System.Drawing.Point(89, 17);
            this.txtBuildBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuildBase.Name = "txtBuildBase";
            this.txtBuildBase.Size = new System.Drawing.Size(188, 22);
            this.txtBuildBase.TabIndex = 0;
            this.txtBuildBase.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuildBase_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnEasyMix);
            this.tabPage2.Controls.Add(this.txtEasyMix);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Easy mix";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 14);
            this.label12.TabIndex = 34;
            this.label12.Text = "Easy mix:";
            // 
            // btnEasyMix
            // 
            this.btnEasyMix.ForeColor = System.Drawing.Color.Black;
            this.btnEasyMix.Location = new System.Drawing.Point(187, 65);
            this.btnEasyMix.Name = "btnEasyMix";
            this.btnEasyMix.Size = new System.Drawing.Size(89, 23);
            this.btnEasyMix.TabIndex = 33;
            this.btnEasyMix.Text = "Easy Mix";
            this.btnEasyMix.UseVisualStyleBackColor = true;
            this.btnEasyMix.Click += new System.EventHandler(this.btnEasyMix_Click);
            // 
            // txtEasyMix
            // 
            this.txtEasyMix.Location = new System.Drawing.Point(89, 17);
            this.txtEasyMix.Name = "txtEasyMix";
            this.txtEasyMix.Size = new System.Drawing.Size(188, 22);
            this.txtEasyMix.TabIndex = 32;
            this.txtEasyMix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEasyMix_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(585, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 14);
            this.label13.TabIndex = 33;
            this.label13.Text = "Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(655, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 14);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "xxx";
            // 
            // flpUnits
            // 
            this.flpUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpUnits.Location = new System.Drawing.Point(467, 363);
            this.flpUnits.Name = "flpUnits";
            this.flpUnits.Size = new System.Drawing.Size(353, 116);
            this.flpUnits.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Base:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(298, 91);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(35, 16);
            this.lblBase.TabIndex = 37;
            this.lblBase.Text = "xxx";
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(820, 643);
            this.Controls.Add(this.flpUnits);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstWeight);
            this.Controls.Add(this.lstColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرمول";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.Shown += new System.EventHandler(this.frmResult_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstColor;
        private System.Windows.Forms.ListBox lstWeight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printFomrulToolStripMenuItem;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem printLableToolStripMenuItem;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblColorType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuildBase;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEasyMix;
        private System.Windows.Forms.TextBox txtEasyMix;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.FlowLayoutPanel flpUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBase;
    }
}