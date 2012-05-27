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
        DataTable dt;
        SqlDataReader dr;
        public String EmployeeID, Name, Date, Gender,
            Address, Email, Permission, Phone, Department;
        public String BorrowID, CallNumber, ISBN, Author, Title, subject, Numberofbook, Bookinlibrary, Publisher,Issuedate,Duedate,
            Returndate,Status,Totalfee;
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
        public void DetailBorrowBook()
        {
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select c.BorrowID,CallNumber,ISBN,b.SubjectName,Title,Author,Publisher,Issuedate,DueDate,Status,ReturnDate,Totalfee from Book a,Subject b,Borrowdetail c where a.SubjectID=b.SubjectID and a.BookID=c.BookID and c.BorrowID='" + FrmBorrow.BorrowID + "'";
                    cmd = new SqlCommand(strSql, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        BorrowID = dr.GetInt32(0).ToString();
                        CallNumber = dr.GetString(1);
                        ISBN = dr.GetString(2);
                        subject = dr.GetString(3);
                        Title = dr.GetString(4);
                        Author = dr.GetString(5);
                        Publisher = dr.GetString(6);
                        Issuedate = dr.GetDateTime(7).ToString();
                        Duedate = dr.GetDateTime(8).ToString();           
                        Status = dr.GetBoolean(9).ToString();
                        if (Status.Equals("True"))
                            Status = "Check-Out";
                        else Status = "Check-In";
                        
                        Returndate = dr.GetDateTime(10).ToString();
                        if (Returndate.Equals(null)) Returndate = "----";
                        
                        Totalfee = dr.GetFloat(11).ToString();
                        if (Totalfee.Equals(null)) Totalfee = "-----";
                    
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Book still check-out");
                }
            }

        }
        public void DetailBorrowEmployee()
        {
            {
                try
                {

                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select a.EmployeeID,Name,[Date of birth],Gender,Address,Email,[Phone number],Department,Permission from Employee a,Borrowdetail b where a.EmployeeID=b.EmployeeID and BorrowID ='" + FrmBorrow.BorrowID + "'";
                    cmd = new SqlCommand(strSql, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EmployeeID = dr.GetInt32(0).ToString();
                        Name =dr.GetString(1);
                        Date = dr.GetDateTime(2).ToString();
                        Gender = dr.GetBoolean(3).ToString();
                        if (Gender.Equals("True"))
                            Gender = "Male";
                        else Gender = "Female";
                        Address = dr.GetString(4);
                        Email = dr.GetString(5);
                        Phone = dr.GetString(6);
                        Department = dr.GetString(7);
                        Permission = dr.GetString(8);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
