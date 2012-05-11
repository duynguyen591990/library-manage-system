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
    public partial class FrmDetailEmployee : Form
    {
        classEmployee nhap = new classEmployee();
        FrmEmployee frmemployee = new FrmEmployee();
        public FrmDetailEmployee()
        {
            InitializeComponent();
            nhap.fillDataDetailEmployee();
            lblEmployeeID.Text = nhap.txtEmployeeID;
            lblName.Text =nhap.txtName;
            lblDate.Text =nhap.txtDate;
            lblGender.Text =nhap.txtGender;
            lblAddress.Text =nhap.txtAddress;
            lblEmail.Text =nhap.txtEmail;
            lblPassword.Text =nhap.txtPassword;
            lblPermission.Text =nhap.txtPermission;
            lblPhone.Text =nhap.txtPhone;
            lblDepartment.Text =nhap.txtDepartment;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmemployee.Show();
        }

       
    }
}
