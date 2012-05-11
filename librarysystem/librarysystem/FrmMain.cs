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
            FrmDangnhap frmdangnhap = new FrmDangnhap();
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

      
       
    }
}
