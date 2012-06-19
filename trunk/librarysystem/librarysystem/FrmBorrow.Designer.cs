namespace librarysystem
{
    partial class FrmBorrow
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Image = global::librarysystem.Properties.Resources.back;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(587, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(231, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Borrow Manager";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(21, 121);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.Size = new System.Drawing.Size(656, 186);
            this.dgvBorrow.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSearch.Location = new System.Drawing.Point(285, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "CallNumber",
            "EmployeeID"});
            this.comboBox1.Location = new System.Drawing.Point(449, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.Image = global::librarysystem.Properties.Resources.Search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(119, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 43);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFee
            // 
            this.btnFee.ForeColor = System.Drawing.Color.Blue;
            this.btnFee.Image = global::librarysystem.Properties.Resources.Fee;
            this.btnFee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFee.Location = new System.Drawing.Point(439, 339);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(91, 37);
            this.btnFee.TabIndex = 16;
            this.btnFee.Text = "Fee Rate";
            this.btnFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFee.UseVisualStyleBackColor = true;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnView
            // 
            this.btnView.ForeColor = System.Drawing.Color.Blue;
            this.btnView.Image = global::librarysystem.Properties.Resources.View;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(291, 339);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(117, 37);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "View Information";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckout.Image = global::librarysystem.Properties.Resources.CheckOut;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(171, 339);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(93, 37);
            this.btnCheckout.TabIndex = 14;
            this.btnCheckout.Text = "Check-Out";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckin.Image = global::librarysystem.Properties.Resources.CheckIn;
            this.btnCheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckin.Location = new System.Drawing.Point(38, 339);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(88, 37);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "Check-In";
            this.btnCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // FrmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(717, 399);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBorrow);
            this.Name = "FrmBorrow";
            this.Text = "FrmBorrow";
            this.Load += new System.EventHandler(this.FrmBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}