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
    public partial class FrmBorrow : Form
    {
        public static String BorrowID,BookID, EmployeeID;
        classBorrow clb = new classBorrow();
        public FrmBorrow()
        {
            InitializeComponent();
        }

        private void FrmBorrow_Load(object sender, EventArgs e)
        {
            clb.reloadgv(dgvBorrow);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clb.searchBorrow(cbxSearch.Text,txtSearch.Text,dgvBorrow);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Dispose();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            BorrowID = dgvBorrow.CurrentRow.Cells[0].Value.ToString();
            FrmDetailBorrow frm = new FrmDetailBorrow();
            frm.Show();
            this.Hide();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            FrmFee frm = new FrmFee();
            frm.Show();
            this.Hide();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            FrmCheckIn frm = new FrmCheckIn();
            frm.Show();
            this.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            FrmCheckOut frm = new FrmCheckOut();
            frm.Show();
            this.Hide();
        }

    }
}
