using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace librarysystem
{
    class classBorrow
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
       // DataTable dt;
       // SqlDataReader dr;
        public void searchBorrow(String cbxSearch, String txtSearch, DataGridView dgvBorrow)
        {

            if (cbxSearch == "All")
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select d.BorrowID,b.EmployeeID,c.BookID,b.Name,CallNumber,Title,IssueDate,Duedate,ReturnDate,Totalfee from Employee b,Borrowdetail d,Book c where b.EmployeeID=d.EmployeeID and d.BookID=c.BookID";
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Borrow");
                    dgvBorrow.DataSource = ds.Tables["Borrow"];
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            else if (cbxSearch == "Call Number")
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select d.BorrowID,b.EmployeeID,c.BookID,b.Name,CallNumber,Title,IssueDate,Duedate,ReturnDate,Totalfee from Employee b,Borrowdetail d,Book c where b.EmployeeID=d.EmployeeID and d.BookID=c.BookID and c.Callnumber='" + txtSearch + "'";
                    MessageBox.Show(strSql);
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Borrow");
                    dgvBorrow.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            else
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select d.BorrowID,b.EmployeeID,c.BookID,b.Name,CallNumber,Title,IssueDate,Duedate,ReturnDate,Totalfee from Employee b,Borrowdetail d,Book c where b.EmployeeID=d.EmployeeID and d.BookID=c.BookID and d.EmployeeID='" + txtSearch + "'";
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Borrow");
                    dgvBorrow.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }
        public void reloadgv(DataGridView dgv)
        {
            conn = Connect.getConnection();
            conn.Open();
            String strSql = "select d.BorrowID,b.EmployeeID,c.BookID,b.Name,CallNumber,Title,IssueDate,Duedate,ReturnDate,Totalfee from Employee b,Borrowdetail d,Book c where b.EmployeeID=d.EmployeeID and d.BookID=c.BookID";
            cmd = new SqlCommand(strSql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Borrow");
            dgv.DataSource = ds.Tables["Borrow"];
            conn.Close();
        }
        public void searchBorrowID(String txtSearch, DataGridView dgvBorrow)
        {

            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String strSql = "select d.BorrowID,b.EmployeeID,c.BookID,b.Name,CallNumber,Title,Duedate,ReturnDate,Totalfee from Employee b,Borrowdetail d,Book c where b.EmployeeID=d.EmployeeID and d.BookID=c.BookID and d.BorrowID='" + txtSearch + "'";
                cmd = new SqlCommand(strSql, conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Borrow");
                dgvBorrow.DataSource = ds.Tables["Borrow"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }
        public void searchborrowbook(DataGridView dgv)
        {
            conn = Connect.getConnection();
            conn.Open();
            String strSql = "select d.BorrowID,b.EmployeeID,c.BookID,b.Name,CallNumber,Title,Duedate,ReturnDate,Totalfee from Employee b,Borrowdetail d,Book c where b.EmployeeID=d.EmployeeID and d.BookID=c.BookID and Status=1 ";
            cmd = new SqlCommand(strSql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Borrow");
            dgv.DataSource = ds.Tables["Borrow"];
            conn.Close();
        }
    }
}
