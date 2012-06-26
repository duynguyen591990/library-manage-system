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
 
    public partial class CRBook : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public CRBook()
        {
            InitializeComponent();
        }

        private void CRBook_Load(object sender, EventArgs e)
        {
            conn = Connect.getConnection();
            conn.Open();
            String str = "select * from Book";
            da = new SqlDataAdapter(str, conn);
            ds = new DataSet();
            da.Fill(ds, "Book");
            CRBook1 rpt = new CRBook1();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Dispose();
        }
    }
}
