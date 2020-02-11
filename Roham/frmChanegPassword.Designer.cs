namespace Roham
{
    partial class frmChanegPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChanegPassword));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(205, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repeat Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(143, 79);
            this.txtRepeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(162, 22);
            this.txtRepeat.TabIndex = 2;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(143, 50);
            this.txtNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(162, 22);
            this.txtNew.TabIndex = 1;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(143, 22);
            this.txtOld.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(162, 22);
            this.txtOld.TabIndex = 0;
            // 
            // frmChanegPassword
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(327, 153);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 192);
            this.Name = "frmChanegPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تغییر پسورد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtOld;
    }
}