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
    public partial class FrmCheckIn : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        SqlConnection conn;
        classBorrow clb = new classBorrow();
        //SqlCommand cmd;
        //DataSet ds;
        SqlDataReader dr;
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            clb.searchborrowbook(dataGridView1);
            //btnCheckin.Visible = true;
       
            // SqlCommand cmd = new SqlCommand(strSql, conn);
            //SqlDataReader rd;
            //rd = cmd.ExecuteReader();
            //while (rd.Read())
            //{
            //    txtDueDate.Text=rd.GetDateTime(6).ToString();}
            //conn.Close();
        
        }

        private void btnSearchBorrow_Click(object sender, EventArgs e)
        {
            clb.searchBorrowID(txtSearchBorrow.Text, dataGridView1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBorrow frm = new FrmBorrow();
            frm.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCheckin.Visible = true;
            int index = dataGridView1.CurrentRow.Index;
            string id = dataGridView1[1, index].Value.ToString();
            conn = Connect.getConnection();
            conn.Open();
            String strSql = "select * from Employee where EmployeeID='" + id + "'";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblName.Text = rd.GetString(1);
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
            conn.Close();
            conn = Connect.getConnection();
            conn.Open();
            int index1 = dataGridView1.CurrentRow.Index;
            string id1 = dataGridView1[0, index1].Value.ToString();
            String Sql = "select Duedate from Borrowdetail where BorrowID='" + id1 + "'";
            SqlCommand cmd1 = new SqlCommand(Sql, conn);
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                duedate.Text = dr.GetDateTime(0).ToShortDateString();
            }

        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            btnCheckin.Visible = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conn = Connect.getConnection();
            conn.Open();
            int index1 = dataGridView1.CurrentRow.Index;
            string id1 = dataGridView1[0, index1].Value.ToString();
            string str = @"select distinct borrowid,a.bookid,callnumber,title,publisher from book a,borrowdetail b where a.bookid=b.bookid and b.borrowid='" + id1 + "' ";
            da = new SqlDataAdapter(str, conn);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            DateTime dt1 = duedate.Value;
            DateTime dt2 = returndate.Value;
            if (DateTime.Compare(dt1, dt2) < 0)
            {
                //viet code tiep o day
            }
            else { MessageBox.Show("Return Date must great Due Date","Error"); }
        }


        }
    }
