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
    public partial class CREmployee : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public CREmployee()
        {
            InitializeComponent();
        }

        private void CREmployee_Load(object sender, EventArgs e)
        {
            conn = Connect.getConnection();
            conn.Open();
            String str = "select * from Employee";
            da = new SqlDataAdapter(str, conn);
            ds = new DataSet();
            da.Fill(ds, "Employee");
            CREmployee1 rpt = new CREmployee1();
            rpt.SetDataSource(ds);
            CrReportEmployee.ReportSource = rpt;
            CrReportEmployee.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Dispose();
        }
    }
}
