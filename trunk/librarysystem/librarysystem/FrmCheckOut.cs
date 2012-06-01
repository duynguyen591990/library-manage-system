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
    public partial class FrmCheckOut : Form
    {
        classEmployee cle = new classEmployee();
        classBook clb = new classBook();
        classBorrow clbo = new classBorrow();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        SqlConnection conn;
        public FrmCheckOut()
        {
            InitializeComponent();
            
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            clb.searchBook(cboBook.Text, txtBookSearch.Text, dataGridView1);
            dataGridView3.Hide();
            dataGridView1.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            cle.searcheEmployee(cboEmployee.Text, txtEmployeeSearch.Text, dataGridView3);
            dataGridView1.Hide();
            dataGridView3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // SqlConnection sql = new SqlConnection(@"Data Source=DELL-PC;Initial Catalog=systemlibrary;Integrated Security=True");
            conn = Connect.getConnection();
            conn.Open();
            int index = dataGridView1.CurrentRow.Index;
            string id=dataGridView1[0,index].Value.ToString();
            string str = "select BookID,CallNumber,ISBN,Title,Author,Publisher from Book where bookid='" + id + "' ";
            da = new SqlDataAdapter(str,conn);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
          // if(issuedate.
           // string dt1 = DateTime.Parse(issuedate.Value.ToString);
            DateTime dt1 = issuedate.Value;
            DateTime dt2 = duedate.Value;
            if (DateTime.Compare(dt1, dt2) < 0)
            {
                conn = Connect.getConnection();
                conn.Open();
                int index = dataGridView3.CurrentRow.Index;
                string id = dataGridView3[0, index].Value.ToString();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    String idbook = dataGridView2[0, i].Value.ToString();
                    String sqlstr = "insert into BorrowDetail(EmployeeID, BookID, IssueDate, DueDate,Status) values('" + Int32.Parse(id) + "','" + Int32.Parse(idbook) + "', '" + issuedate.Text + "' ,'" + duedate.Text + "','" + 1 + "')";
                    //MessageBox.Show(sqlstr);
                    SqlCommand cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    //String sql = "";
                    //SqlCommand cmd1 = new SqlCommand(sql, conn);
                    //cmd1.ExecuteNonQuery();
                }
                MessageBox.Show("Check-Out Successfull");
                FrmBorrow frm = new FrmBorrow();
                frm.Show();
                this.Dispose();
            }
            else { MessageBox.Show("Due Date must great Issue Date","Error"); }
            
         
        }

        private void FrmCheckOut_Load(object sender, EventArgs e)
        {
            btnCheckout.Visible = false;
            clbo.previousfee();
            lblFee.Text = clbo.borrowFee + "$/Day-" + clbo.lateFee + "$/Day";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCheckout.Visible = true;
            int index = dataGridView3.CurrentRow.Index;
            string id = dataGridView3[0, index].Value.ToString();
            conn = Connect.getConnection();
                conn.Open();
                String strSql = "select * from Employee where EmployeeID='"+id+"'";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lblName.Text= rd.GetString(1);
                    lblDOB.Text = rd.GetDateTime(2).ToString();
                    lblGender.Text = rd.GetBoolean(3).ToString();
                    if (lblGender.Equals("True"))
                        lblGender.Text = "Male";
                    else lblGender.Text = "Female";
                    lblAddress.Text = rd.GetString(4);
                    lblPermission.Text = rd.GetString(7);
                    lblPhone.Text = rd.GetString(8);
                    lblDepartment.Text = rd.GetString(9);
        }

    }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBorrow frm = new FrmBorrow();
            frm.Show();
            this.Dispose();
        }

        }
}
