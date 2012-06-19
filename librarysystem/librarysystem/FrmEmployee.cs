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
    public partial class FrmEmployee : Form
    {
       // SqlConnection conn;
        //SqlCommand cmd;
        //SqlDataAdapter da;
        //DataSet ds;
        public static String EmployeeID, EmployeeIDE, EmployeeIDD;
        classEmployee nhap = new classEmployee();
        FrmMain frmmain = new FrmMain();
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            nhap.loadall(dataGridView1);
            if (FrmLogin.quyen != "Librarian ") { btnDelete.Enabled = false; btnEdit.Enabled = false; }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            EmployeeID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmDetailEmployee frmdetailemployee = new FrmDetailEmployee();
            frmdetailemployee.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addemployee = new FrmAddEmployee();
            addemployee.Show();
            this.Hide();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeIDE = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // MessageBox.Show(EmployeeID);
            FrmEditEmployee frmeditemployee = new FrmEditEmployee();
            frmeditemployee.Show();
            this.Hide();
        }
 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            nhap.searcheEmployee(cboList.Text, txtSearch.Text, dataGridView1);
                       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeIDD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nhap.deleteEmployee();
            nhap.loadall(dataGridView1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmmain.Show();
            this.Hide();
        }

       

        
    }
}
