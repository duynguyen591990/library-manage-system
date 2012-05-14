using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace librarysystem
{
    class classBook
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        SqlDataReader dr;
        public String BookID, CallNumber, ISBN, Author, Title, subject, Numberofbook, Bookinlibrary, Publisher;
        public void searchBook(String cbxSearch, String txtSearch, DataGridView dgvBook)
        {

            if (cbxSearch == "All")
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                   // String strsql = "select * from Book";
                    String strSql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID";
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Book");
                    dgvBook.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            else if (cbxSearch == "CallNumber")
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    //String strSql = "select * from Book where CallNumber='" + txtSearch + "'";
                    String strSql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID and CallNumber='" + txtSearch + "'";
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Book");
                    dgvBook.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            else

                if (cbxSearch == "ISBN")
                {
                    try
                    {
                        conn = Connect.getConnection();
                        conn.Open();
                        //String strSql = "select * from Book where ISBN='" + txtSearch + "'";
                        String strSql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID and ISBN='" + txtSearch + "'";              
                        cmd = new SqlCommand(strSql, conn);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "Book");
                        dgvBook.DataSource = ds.Tables[0];

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
                else
                    if (cbxSearch == "Title")
                    {
                        try
                        {
                            conn = Connect.getConnection();
                            conn.Open();
                         //   String strSql = "select * from Book where Title like'" + txtSearch + "'";
                            String strSql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID and Title like'" + txtSearch + "'";
                           // MessageBox.Show(strSql);
                            cmd = new SqlCommand(strSql, conn);
                            da = new SqlDataAdapter(cmd);
                            ds = new DataSet();
                            da.Fill(ds, "Book");
                            dgvBook.DataSource = ds.Tables[0];

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
                           // String strSql = "select * from Book where Author like '%" + txtSearch + "%'";
                            String strSql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID and Author like '%" + txtSearch + "%'";
                            cmd = new SqlCommand(strSql, conn);
                            da = new SqlDataAdapter(cmd);
                            ds = new DataSet();
                            da.Fill(ds, "Book");
                            dgvBook.DataSource = ds.Tables[0];

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex.Message);
                        }
                    }
        }
        public void loadcomboxsubject(ComboBox cbo)
        {
            conn = Connect.getConnection();
            conn.Open();
            dt = Connect.getDT(conn, "Subject");
            cbo.DataSource = dt;
            cbo.DisplayMember = dt.Columns[1].ToString();
            cbo.ValueMember = dt.Columns[0].ToString();

        }
        public void deleteBook() {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String sql = " select * from Borrowdetail where BookID='" + FrmBook.BookIDD + "'";
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                dt = new DataTable();
                da.Fill(ds, "Borrowdetail");
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Book is borrowed so you can't delete", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    String strSql = "delete Book where BookID='" + FrmBook.BookIDD + "'";
                    cmd = new SqlCommand(strSql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfull!", "Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
      
        }
        public void DetailBook()
        {
            {
                try
                {

                    conn = Connect.getConnection();
                    conn.Open();
                   // String strSql = "select * from Book where BookID='" + FrmBook.BookID + "'";
                    String strSql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID and BookID='"+FrmBook.BookID+"'";
                    cmd = new SqlCommand(strSql, conn);
                    // MessageBox.Show(FrmEmployee.EmployeeID);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        BookID = dr.GetInt32(0).ToString();
                        CallNumber = dr.GetString(1);
                        ISBN = dr.GetString(2);
                        //subject = dr.GetInt32(3).ToString();
                        subject = dr.GetString(3);
                        Title = dr.GetString(4);
                        Author = dr.GetString(5);
                        Publisher = dr.GetString(6);
                        Numberofbook = dr.GetInt32(7).ToString();
                        Bookinlibrary = dr.GetInt32(8).ToString();

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void AddBook(String CallNumber, String ISBN, int Subject,String Title, String Author, String Publisher,int NumberofBook,int Bookinlirary)
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String sqlstr = "insert into Book values('" + CallNumber + "','" + ISBN + "', '" + Subject + "' ,'"
               + Title + "','" + Author + "','"+ Publisher + "','" + NumberofBook + "','" + Bookinlirary + "')";
                cmd = new SqlCommand(sqlstr, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add new book successfull ", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error",ex.Message );
            }
        }
        public void reloadgv(DataGridView dgv) {
            conn = Connect.getConnection();
            conn.Open();
            String strSql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID";
            cmd = new SqlCommand(strSql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Book");
            dgv.DataSource = ds.Tables["Book"];
            conn.Close();
        }
        public void loaddataedit() {
            {
                try
                {

                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select * from Book where BookID='" + FrmBook.BookIDE + "'";
                    cmd = new SqlCommand(strSql, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        BookID = dr.GetInt32(0).ToString();
                        CallNumber = dr.GetString(1);
                        ISBN = dr.GetString(2);
                        subject = dr.GetInt32(3).ToString();
                       // MessageBox.Show(subject);
                        Title = dr.GetString(4);
                        Author = dr.GetString(5);
                        Publisher = dr.GetString(6);
                        Numberofbook = dr.GetInt32(7).ToString();
                        Bookinlibrary = dr.GetInt32(8).ToString();

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void updateBook(String CallNumber, String ISBN, int subjectid, String Title, String Author, String Publisher, int Numberofbook,int bookinlibrary)
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String strSql = "update Book set CallNumber='" + CallNumber + "',ISBN='" + ISBN + "',SubjectID='" + subjectid + "',Title='" + Title + "',Author='" +Author + "',Publisher='" + Publisher + "',[No Book]='" + Numberofbook + "',[Book in Library]='" +bookinlibrary + "' where BookID='" +FrmBook.BookIDE + "'";
                cmd = new SqlCommand(strSql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfull!", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void loaddetailbook(DataGridView dgv) {
            conn = Connect.getConnection();
            conn.Open();
            String sql = "select a.EmployeeID,a.Name,a.Email,a.[Phone Number],a.Department ,IssueDate,DueDate from Employee a,Borrowdetail b,Borrow c where a.EmployeeID=c.EmployeeID and c.BorrowID=b.BorrowID and BookID='"
                +FrmBook.BookID+"'";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "detailbook");
            dgv.DataSource = ds.Tables["detailbook"];
            conn.Close();
        }
    }
}
