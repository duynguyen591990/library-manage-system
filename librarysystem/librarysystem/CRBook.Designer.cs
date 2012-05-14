namespace librarysystem
{
    partial class CRBook
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
            this.CRReportBook = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRReportBook
            // 
            this.CRReportBook.ActiveViewIndex = -1;
            this.CRReportBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRReportBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRReportBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRReportBook.Location = new System.Drawing.Point(0, 0);
            this.CRReportBook.Name = "CRReportBook";
            this.CRReportBook.Size = new System.Drawing.Size(1067, 543);
            this.CRReportBook.TabIndex = 0;
            this.CRReportBook.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // CRBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 543);
            this.Controls.Add(this.CRReportBook);
            this.Name = "CRBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRBook";
            this.Load += new System.EventHandler(this.CRBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRReportBook;
    }
}