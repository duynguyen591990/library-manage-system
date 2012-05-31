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
    public partial class FrmFee : Form
    {
        classBorrow clb = new classBorrow();
        public FrmFee()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtBorrowFee.Text == "") lblBorrowFee.Text = "*Empty";
            if (txtLateFee.Text == "") lblLateFee.Text = "*Empty";
            clb.changerate(Double.Parse(txtBorrowFee.Text),Double.Parse(txtLateFee.Text),affectdate.Value.ToString());
            FrmBorrow frm = new FrmBorrow();
            frm.Show();
            this.Dispose();
           // affectdate.Enabled = false;
          
        }

        private void FrmFee_Load(object sender, EventArgs e)
        {
            clb.previousfee();
            txtBorrowFee.Text = clb.borrowFee;
            txtLateFee.Text = clb.lateFee;
            affectdate.Text = clb.affectdate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBorrow frm = new FrmBorrow();
            frm.Show();
            this.Dispose();
        }


    }
}
