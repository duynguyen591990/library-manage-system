﻿namespace librarysystem
{
    partial class FrmAnalytic
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnTopBook = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTopBorrow = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(37, 79);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(843, 309);
            this.dgv.TabIndex = 0;
            // 
            // btnTopBook
            // 
            this.btnTopBook.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTopBook.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTopBook.Location = new System.Drawing.Point(58, 479);
            this.btnTopBook.Name = "btnTopBook";
            this.btnTopBook.Size = new System.Drawing.Size(75, 23);
            this.btnTopBook.TabIndex = 1;
            this.btnTopBook.Text = "Top Book";
            this.btnTopBook.UseVisualStyleBackColor = false;
            this.btnTopBook.Click += new System.EventHandler(this.btnTopBook_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Location = new System.Drawing.Point(518, 423);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTopBorrow
            // 
            this.btnTopBorrow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTopBorrow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTopBorrow.Location = new System.Drawing.Point(192, 479);
            this.btnTopBorrow.Name = "btnTopBorrow";
            this.btnTopBorrow.Size = new System.Drawing.Size(83, 23);
            this.btnTopBorrow.TabIndex = 3;
            this.btnTopBorrow.Text = "Top Borrower";
            this.btnTopBorrow.UseVisualStyleBackColor = false;
            this.btnTopBorrow.Click += new System.EventHandler(this.btnTopBorrow_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(289, 426);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(222, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Due Date";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(835, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReport.Location = new System.Drawing.Point(347, 479);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(400, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Analytic";
            // 
            // FrmAnalytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(917, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnTopBorrow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTopBook);
            this.Controls.Add(this.dgv);
            this.Name = "FrmAnalytic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnalytic";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnTopBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTopBorrow;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label4;
    }
}