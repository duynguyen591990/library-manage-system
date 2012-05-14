namespace librarysystem
{
    partial class CREmployee
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

       

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CRReportEmployee = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRReportEmployee
            // 
            this.CRReportEmployee.ActiveViewIndex = -1;
            this.CRReportEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRReportEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRReportEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRReportEmployee.Location = new System.Drawing.Point(0, 0);
            this.CRReportEmployee.Name = "CRReportEmployee";
            this.CRReportEmployee.Size = new System.Drawing.Size(1047, 540);
            this.CRReportEmployee.TabIndex = 0;
            this.CRReportEmployee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // CREmployee
            // 
            this.ClientSize = new System.Drawing.Size(1047, 540);
            this.Controls.Add(this.CRReportEmployee);
            this.Name = "CREmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREmployee";
            this.Load += new System.EventHandler(this.CREmployee_Load);
            this.ResumeLayout(false);

        }

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRReportEmployee; 
    }
}