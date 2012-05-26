using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace librarysystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmdangnhap = new FrmLogin();
            frmdangnhap.Show();
            this.Dispose();
                      
        }

        private void quánLýEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee frmaddemployee = new FrmEmployee();
            frmaddemployee.Show();
            this.Dispose();
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
            this.Dispose();
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
        }

        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Guide.docx");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Library";
        }

      
       
    }
}
