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
            Application.Exit();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string text = label1.Text;
           label1.Text = text.Substring(1,text.Length-1)+text.Substring(0,1);
           // label1.Left += 10;
        }

        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Guide.docx");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //FrmLogin.Username=text
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString() ;
            toolStripStatusLabel1.Text=FrmLogin.Username+" Online!";
            if (FrmLogin.quyen != "Librarian ") { backUpDatabaseToolStripMenuItem.Enabled = false; }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlBackup = "BACKUP DATABASE [systemlibrary] TO DISK='D:\\library-manage-system\\librarysystem\\systemlibrary.bak'";
                SqlConnection con = new SqlConnection("Data Source=DEll-PC;Initial Catalog=systemlibrary;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlBackup, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Backup Database Successfull!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Backup Database");
                return;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "D:\\library-manage-system\\librarysystem\\systemlibrary.bak";
                string sqlRestore = "Use master Restore Database [systemlibrary] from disk='" + path + "'";
                SqlConnection con = new SqlConnection("Data Source=DEll-PC;Initial Catalog=systemlibrary;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand(sqlRestore, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database restore successfull ");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Restore Database");
                return;
            }
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
    }
}
