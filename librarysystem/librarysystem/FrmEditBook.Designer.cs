﻿namespace librarysystem
{
    partial class FrmEditBook
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
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtCallNumber = new System.Windows.Forms.MaskedTextBox();
            this.CheckPublisher = new System.Windows.Forms.Label();
            this.CheckAuthor = new System.Windows.Forms.Label();
            this.CheckTitle = new System.Windows.Forms.Label();
            this.CheckISBN = new System.Windows.Forms.Label();
            this.checkCallNumber = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.txtonLibrary = new System.Windows.Forms.TextBox();
            this.txtNumberofBook = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtCallNumber);
            this.groupBox1.Controls.Add(this.CheckPublisher);
            this.groupBox1.Controls.Add(this.CheckAuthor);
            this.groupBox1.Controls.Add(this.CheckTitle);
            this.groupBox1.Controls.Add(this.CheckISBN);
            this.groupBox1.Controls.Add(this.checkCallNumber);
            this.groupBox1.Controls.Add(this.cboSubject);
            this.groupBox1.Controls.Add(this.txtonLibrary);
            this.groupBox1.Controls.Add(this.txtNumberofBook);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(202, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 323);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(23, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "(Format :000-0000)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "(Format :AB-CD-000)";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.Blue;
            this.txtISBN.Location = new System.Drawing.Point(146, 69);
            this.txtISBN.Mask = "999-9999";
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(222, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtCallNumber
            // 
            this.txtCallNumber.ForeColor = System.Drawing.Color.Blue;
            this.txtCallNumber.Location = new System.Drawing.Point(146, 22);
            this.txtCallNumber.Mask = "aa-aa-999";
            this.txtCallNumber.Name = "txtCallNumber";
            this.txtCallNumber.Size = new System.Drawing.Size(222, 26);
            this.txtCallNumber.TabIndex = 5;
            // 
            // CheckPublisher
            // 
            this.CheckPublisher.AutoSize = true;
            this.CheckPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPublisher.ForeColor = System.Drawing.Color.Red;
            this.CheckPublisher.Location = new System.Drawing.Point(374, 200);
            this.CheckPublisher.Name = "CheckPublisher";
            this.CheckPublisher.Size = new System.Drawing.Size(50, 13);
            this.CheckPublisher.TabIndex = 10;
            this.CheckPublisher.Text = "Publisher";
            // 
            // CheckAuthor
            // 
            this.CheckAuthor.AutoSize = true;
            this.CheckAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAuthor.ForeColor = System.Drawing.Color.Red;
            this.CheckAuthor.Location = new System.Drawing.Point(374, 160);
            this.CheckAuthor.Name = "CheckAuthor";
            this.CheckAuthor.Size = new System.Drawing.Size(38, 13);
            this.CheckAuthor.TabIndex = 10;
            this.CheckAuthor.Text = "Author";
            // 
            // CheckTitle
            // 
            this.CheckTitle.AutoSize = true;
            this.CheckTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTitle.ForeColor = System.Drawing.Color.Red;
            this.CheckTitle.Location = new System.Drawing.Point(371, 126);
            this.CheckTitle.Name = "CheckTitle";
            this.CheckTitle.Size = new System.Drawing.Size(30, 13);
            this.CheckTitle.TabIndex = 10;
            this.CheckTitle.Text = "Tittle";
            // 
            // CheckISBN
            // 
            this.CheckISBN.AutoSize = true;
            this.CheckISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckISBN.ForeColor = System.Drawing.Color.Red;
            this.CheckISBN.Location = new System.Drawing.Point(374, 72);
            this.CheckISBN.Name = "CheckISBN";
            this.CheckISBN.Size = new System.Drawing.Size(32, 13);
            this.CheckISBN.TabIndex = 10;
            this.CheckISBN.Text = "ISBN";
            // 
            // checkCallNumber
            // 
            this.checkCallNumber.AutoSize = true;
            this.checkCallNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCallNumber.ForeColor = System.Drawing.Color.Red;
            this.checkCallNumber.Location = new System.Drawing.Point(374, 22);
            this.checkCallNumber.Name = "checkCallNumber";
            this.checkCallNumber.Size = new System.Drawing.Size(61, 13);
            this.checkCallNumber.TabIndex = 10;
            this.checkCallNumber.Text = "CallNumber";
            // 
            // cboSubject
            // 
            this.cboSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubject.ForeColor = System.Drawing.Color.Blue;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(146, 282);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(222, 21);
            this.cboSubject.TabIndex = 9;
            // 
            // txtonLibrary
            // 
            this.txtonLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtonLibrary.ForeColor = System.Drawing.Color.Blue;
            this.txtonLibrary.Location = new System.Drawing.Point(342, 243);
            this.txtonLibrary.Name = "txtonLibrary";
            this.txtonLibrary.ReadOnly = true;
            this.txtonLibrary.Size = new System.Drawing.Size(82, 20);
            this.txtonLibrary.TabIndex = 8;
            // 
            // txtNumberofBook
            // 
            this.txtNumberofBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofBook.ForeColor = System.Drawing.Color.Blue;
            this.txtNumberofBook.Location = new System.Drawing.Point(143, 243);
            this.txtNumberofBook.Name = "txtNumberofBook";
            this.txtNumberofBook.Size = new System.Drawing.Size(68, 20);
            this.txtNumberofBook.TabIndex = 7;
            this.txtNumberofBook.TextChanged += new System.EventHandler(this.txtNumberofBook_TextChanged);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.ForeColor = System.Drawing.Color.Blue;
            this.txtPublisher.Location = new System.Drawing.Point(146, 202);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(222, 20);
            this.txtPublisher.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.Blue;
            this.txtAuthor.Location = new System.Drawing.Point(146, 157);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(222, 21);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Blue;
            this.txtTitle.Location = new System.Drawing.Point(146, 123);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(219, 21);
            this.txtTitle.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Number in Library";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Number of Book";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Call Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(225, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 33);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::librarysystem.Properties.Resources.EditBook;
            this.pictureBox1.Location = new System.Drawing.Point(12, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Image = global::librarysystem.Properties.Resources.accept1;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(84, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Image = global::librarysystem.Properties.Resources.back2;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(495, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Blue;
            this.btnReset.Image = global::librarysystem.Properties.Resources.refresh1;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(284, 421);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 32);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(663, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Name = "FrmEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.FrmEditBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtISBN;
        private System.Windows.Forms.MaskedTextBox txtCallNumber;
        private System.Windows.Forms.Label CheckPublisher;
        private System.Windows.Forms.Label CheckAuthor;
        private System.Windows.Forms.Label CheckTitle;
        private System.Windows.Forms.Label CheckISBN;
        private System.Windows.Forms.Label checkCallNumber;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.TextBox txtonLibrary;
        private System.Windows.Forms.TextBox txtNumberofBook;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}