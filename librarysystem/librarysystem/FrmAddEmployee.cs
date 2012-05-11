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
    public partial class FrmAddEmployee : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String gender;
        classEmployee cl = new classEmployee();
        FrmEmployee frmemployee = new FrmEmployee();
        public FrmAddEmployee()
        {
            
            InitializeComponent();
           
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {           
            cl.load_permission(cboPermission);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
                gender = "True";
            if (rdFemale.Checked)
                gender = "False";
            cl.AddEmployee(txtName.Text, datetimepicker.Value.ToString(), gender,txtAddress.Text,txtEmail.Text,txtPassword.Text,cboPermission.SelectedValue.ToString(),txtPhone.Text,txtDepartment.Text);
            frmemployee.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();           
            frmemployee.Show();
        }

      
    }
}
