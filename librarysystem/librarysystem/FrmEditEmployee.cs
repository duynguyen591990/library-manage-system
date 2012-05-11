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
    public partial class FrmEditEmployee : Form
    {
        FrmEmployee frmemployee = new FrmEmployee();
        classEmployee nhap = new classEmployee();
        String txtGender;
        public FrmEditEmployee()
        {
            InitializeComponent();
            nhap.fillDataEditEmployee();
            txtEmployeeID.Text = nhap.txtEmployeeID;
            txtName.Text = nhap.txtName;
            txtDate.Text = nhap.txtDate;
            if (nhap.txtGender == "True")
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }

            txtAddress.Text = nhap.txtAddress;
            txtEmail.Text = nhap.txtEmail;
            txtPassword.Text = nhap.txtPassword;

           // nhap.load_permission(cboPermission);
            cboPermission.Text  = nhap.txtPermission;

            txtPhone.Text = nhap.txtPhone;
            txtDepartment.Text = nhap.txtDepartment;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
                txtGender = "True";
            else txtGender = "False";
            nhap.updateEmployee(txtName.Text, txtDate.Value.ToString(), txtGender, txtAddress.Text, txtEmail.Text, txtPassword.Text, cboPermission.SelectedItem.ToString(), txtPhone.Text, txtDepartment.Text);
            this.Dispose();
            frmemployee.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmemployee.Show();
        }

    }
}
