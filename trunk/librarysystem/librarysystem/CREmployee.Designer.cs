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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrReportEmployee = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrReportEmployee
            // 
            this.CrReportEmployee.ActiveViewIndex = -1;
            this.CrReportEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrReportEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrReportEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrReportEmployee.Location = new System.Drawing.Point(0, 0);
            this.CrReportEmployee.Name = "CrReportEmployee";
            this.CrReportEmployee.Size = new System.Drawing.Size(726, 505);
            this.CrReportEmployee.TabIndex = 0;
            this.CrReportEmployee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // CREmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 505);
            this.Controls.Add(this.CrReportEmployee);
            this.Name = "CREmployee";
            this.Text = "CREmployee";
            this.Load += new System.EventHandler(this.CREmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrReportEmployee;
    }
}