namespace librarysystem
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(37, 38);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(697, 350);
            this.dgv.TabIndex = 0;
            // 
            // btnTopBook
            // 
            this.btnTopBook.Location = new System.Drawing.Point(58, 479);
            this.btnTopBook.Name = "btnTopBook";
            this.btnTopBook.Size = new System.Drawing.Size(75, 23);
            this.btnTopBook.TabIndex = 1;
            this.btnTopBook.Text = "Top Book";
            this.btnTopBook.UseVisualStyleBackColor = true;
            this.btnTopBook.Click += new System.EventHandler(this.btnTopBook_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(518, 423);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTopBorrow
            // 
            this.btnTopBorrow.Location = new System.Drawing.Point(192, 479);
            this.btnTopBorrow.Name = "btnTopBorrow";
            this.btnTopBorrow.Size = new System.Drawing.Size(83, 23);
            this.btnTopBorrow.TabIndex = 3;
            this.btnTopBorrow.Text = "Top Borrower";
            this.btnTopBorrow.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(222, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Due Date";
            // 
            // FrmAnalytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnTopBorrow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTopBook);
            this.Controls.Add(this.dgv);
            this.Name = "FrmAnalytic";
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
    }
}