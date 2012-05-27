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
    public partial class FrmDetailBorrow : Form
    {
        classBorrow clb = new classBorrow();
        public FrmDetailBorrow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmBorrow frm = new FrmBorrow();
            this.Hide();
            frm.Show();
        }

        private void FrmDetailBorrow_Load(object sender, EventArgs e)
        {
            //load du lieu ra group employee
            clb.DetailBorrowEmployee();
            lblEmployeeID.Text = clb.EmployeeID;
            lblName.Text = clb.Name;
            lblDate.Text = clb.Date;
            lblGender.Text = clb.Gender;
            lblAddress.Text = clb.Address;
            lblEmail.Text = clb.Email;
            lblPermission.Text = clb.Permission;
            lblPhone.Text = clb.Phone;
            lblDepartment.Text = clb.Department;
            //load du lieu ra group borrow
            clb.DetailBorrowBook();
            lblBorrowID.Text = clb.BorrowID;
            lblCallNumber.Text = clb.CallNumber;
            lblISBN.Text = clb.ISBN;
            lblAuthor.Text = clb.Author;
            lblTitle.Text = clb.Title;
            lblPublisher.Text = clb.Publisher;
            lblSubject.Text = clb.subject;
            lblIssueDate.Text = clb.Issuedate;
            lblDueDate.Text = clb.Duedate;
            lblReturnDate.Text = clb.Returndate;
            lblTotalFee.Text = clb.Totalfee;
            lblIssueStatus.Text = clb.Status;

        }
    }
}
