﻿namespace librarysystem
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrReportEmployee
            // 
            this.CrReportEmployee.ActiveViewIndex = -1;
            this.CrReportEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrReportEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrReportEmployee.Location = new System.Drawing.Point(-4, 1);
            this.CrReportEmployee.Name = "CrReportEmployee";
            this.CrReportEmployee.Size = new System.Drawing.Size(1099, 535);
            this.CrReportEmployee.TabIndex = 0;
            this.CrReportEmployee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::librarysystem.Properties.Resources.back;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(557, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CREmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CrReportEmployee);
            this.Name = "CREmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Employee";
            this.Load += new System.EventHandler(this.CREmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrReportEmployee;
        private System.Windows.Forms.Button button1;
    }
}