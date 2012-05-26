namespace librarysystem
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quánLýEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quảnLýEmployeeToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItem1.Image = global::librarysystem.Properties.Resources.Setting;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem1.Text = "System";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.đăngNhậpToolStripMenuItem.Image = global::librarysystem.Properties.Resources.unlock;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Login";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.thoátToolStripMenuItem.Image = global::librarysystem.Properties.Resources.delete;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thoátToolStripMenuItem.Text = "Exit";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýEmployeeToolStripMenuItem
            // 
            this.quảnLýEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quánLýEmployeeToolStripMenuItem,
            this.bookManagerToolStripMenuItem,
            this.subjectManagerToolStripMenuItem,
            this.borrowManagerToolStripMenuItem});
            this.quảnLýEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quảnLýEmployeeToolStripMenuItem.Image = global::librarysystem.Properties.Resources.Computer;
            this.quảnLýEmployeeToolStripMenuItem.Name = "quảnLýEmployeeToolStripMenuItem";
            this.quảnLýEmployeeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.quảnLýEmployeeToolStripMenuItem.Text = "Manager";
            // 
            // quánLýEmployeeToolStripMenuItem
            // 
            this.quánLýEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quánLýEmployeeToolStripMenuItem.Image = global::librarysystem.Properties.Resources.Employee;
            this.quánLýEmployeeToolStripMenuItem.Name = "quánLýEmployeeToolStripMenuItem";
            this.quánLýEmployeeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quánLýEmployeeToolStripMenuItem.Text = "Employee Manager";
            this.quánLýEmployeeToolStripMenuItem.Click += new System.EventHandler(this.quánLýEmployeeToolStripMenuItem_Click);
            // 
            // bookManagerToolStripMenuItem
            // 
            this.bookManagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bookManagerToolStripMenuItem.Image = global::librarysystem.Properties.Resources.Book;
            this.bookManagerToolStripMenuItem.Name = "bookManagerToolStripMenuItem";
            this.bookManagerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.bookManagerToolStripMenuItem.Text = "Book Manager";
            this.bookManagerToolStripMenuItem.Click += new System.EventHandler(this.bookManagerToolStripMenuItem_Click);
            // 
            // subjectManagerToolStripMenuItem
            // 
            this.subjectManagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.subjectManagerToolStripMenuItem.Image = global::librarysystem.Properties.Resources.Sub;
            this.subjectManagerToolStripMenuItem.Name = "subjectManagerToolStripMenuItem";
            this.subjectManagerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.subjectManagerToolStripMenuItem.Text = "Subject Manager";
            this.subjectManagerToolStripMenuItem.Click += new System.EventHandler(this.subjectManagerToolStripMenuItem_Click);
            // 
            // borrowManagerToolStripMenuItem
            // 
            this.borrowManagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.borrowManagerToolStripMenuItem.Image = global::librarysystem.Properties.Resources.Borrow;
            this.borrowManagerToolStripMenuItem.Name = "borrowManagerToolStripMenuItem";
            this.borrowManagerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.borrowManagerToolStripMenuItem.Text = "Borrow Manager";
            this.borrowManagerToolStripMenuItem.Click += new System.EventHandler(this.borrowManagerToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyticToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.thốngKêToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.thốngKêToolStripMenuItem.Image = global::librarysystem.Properties.Resources.full_page;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thốngKêToolStripMenuItem.Text = "Report";
            // 
            // analyticToolStripMenuItem
            // 
            this.analyticToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.analyticToolStripMenuItem.Image = global::librarysystem.Properties.Resources.TopBook;
            this.analyticToolStripMenuItem.Name = "analyticToolStripMenuItem";
            this.analyticToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.analyticToolStripMenuItem.Text = "Analytic";
            this.analyticToolStripMenuItem.Click += new System.EventHandler(this.analyticToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.employeeToolStripMenuItem.Image = global::librarysystem.Properties.Resources.TopBorrower;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.helpToolStripMenuItem.Image = global::librarysystem.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guideToolStripMenuItem.Image = global::librarysystem.Properties.Resources.View;
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guideToolStripMenuItem.Text = "Guide";
            this.guideToolStripMenuItem.Click += new System.EventHandler(this.guideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.aboutToolStripMenuItem.Image = global::librarysystem.Properties.Resources.rss;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(88, 511);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(108, 21);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Backup Database";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(397, 511);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(85, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(299, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Library Manager System";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(786, 559);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quánLýEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowManagerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem guideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

