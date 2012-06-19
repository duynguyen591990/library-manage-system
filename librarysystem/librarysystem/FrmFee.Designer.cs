namespace librarysystem
{
    partial class FrmFee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.affectdate = new System.Windows.Forms.DateTimePicker();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.txtBorrowFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBorrowFee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.affectdate);
            this.groupBox1.Controls.Add(this.txtLateFee);
            this.groupBox1.Controls.Add(this.txtBorrowFee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLateFee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBorrowFee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(176, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rate Fee Information";
            // 
            // affectdate
            // 
            this.affectdate.CustomFormat = "dd/MM/yyyy";
            this.affectdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.affectdate.Location = new System.Drawing.Point(94, 104);
            this.affectdate.Name = "affectdate";
            this.affectdate.Size = new System.Drawing.Size(139, 20);
            this.affectdate.TabIndex = 2;
            // 
            // txtLateFee
            // 
            this.txtLateFee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtLateFee.Location = new System.Drawing.Point(94, 71);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.Size = new System.Drawing.Size(139, 20);
            this.txtLateFee.TabIndex = 1;
            // 
            // txtBorrowFee
            // 
            this.txtBorrowFee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBorrowFee.Location = new System.Drawing.Point(94, 33);
            this.txtBorrowFee.Name = "txtBorrowFee";
            this.txtBorrowFee.Size = new System.Drawing.Size(139, 20);
            this.txtBorrowFee.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Affect Date";
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.ForeColor = System.Drawing.Color.Red;
            this.lblLateFee.Location = new System.Drawing.Point(250, 74);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(0, 13);
            this.lblLateFee.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Late Fee";
            // 
            // lblBorrowFee
            // 
            this.lblBorrowFee.AutoSize = true;
            this.lblBorrowFee.ForeColor = System.Drawing.Color.Red;
            this.lblBorrowFee.Location = new System.Drawing.Point(250, 36);
            this.lblBorrowFee.Name = "lblBorrowFee";
            this.lblBorrowFee.Size = new System.Drawing.Size(0, 13);
            this.lblBorrowFee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow Fee";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Image = global::librarysystem.Properties.Resources.back2;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(351, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::librarysystem.Properties.Resources.FeeRate;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 167);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnChange
            // 
            this.btnChange.ForeColor = System.Drawing.Color.Blue;
            this.btnChange.Image = global::librarysystem.Properties.Resources.chart_pie;
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.Location = new System.Drawing.Point(197, 183);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(83, 34);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // FrmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(517, 234);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFee";
            this.Text = "FrmFee";
            this.Load += new System.EventHandler(this.FrmFee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.TextBox txtBorrowFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker affectdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblBorrowFee;
    }
}