using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace librarysystem
{
    public partial class FrmMain : Form
    {   public static string username;
        public FrmMain()
        {
            InitializeComponent();
        }

        public void EnableMenu()
        {
            quảnLýEmployeeToolStripMenuItem.Enabled = true;
            thốngKêToolStripMenuItem.Enabled = true;
        }
        public void DisableMenu()
        {
            quảnLýEmployeeToolStripMenuItem.Enabled = false;
            thốngKêToolStripMenuItem.Enabled=false;
            backUpDatabaseToolStripMenuItem.Enabled = false;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmdangnhap = new FrmLogin();
            frmdangnhap.Show();
            this.Hide();
                      
        }

        private void quánLýEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee frmaddemployee = new FrmEmployee();
            frmaddemployee.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the program?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void analyticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnalytic frmanalytic = new FrmAnalytic();
            frmanalytic.Show();
            this.Hide();

        }

        private void bookManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBook frm = new FrmBook();
            frm.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CREmployee cremployee = new CREmployee();
            cremployee.Show();
            this.Hide();
        }

        private void subjectManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubject frm = new FrmSubject();
            frm.Show();
            this.Hide();
        }

        private void borrowManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorrow frm = new FrmBorrow();
            frm.Show();
            this.Hide();
        }
        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Guide.docx");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString() ;
            toolStripStatusLabel1.Text=FrmLogin.Username+" Online!";
            if (FrmLogin.quyen != "Librarian ") { backUpDatabaseToolStripMenuItem.Enabled = false; }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableMenu();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CRBook cremployee = new CRBook();
            cremployee.Show();
            this.Hide();
        }

        private void backUpDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            backup.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.Show();
            this.Hide();
        }   
    }
}
