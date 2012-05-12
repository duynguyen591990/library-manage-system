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
                    String strsql = "select * from Book";
                    cmd = new SqlCommand(strsql, conn);
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
                    String strSql = "select * from Book where CallNumber='" + txtSearch + "'";
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
                        String strSql = "select * from Book where ISBN='" + txtSearch + "'";
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
                            String strSql = "select * from Book where Title like'" + txtSearch + "'";
                            MessageBox.Show(strSql);
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
                            String strSql = "select * from Book where Author like '%" + txtSearch + "%'";
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
        public void checkvalidate() { }
        public void DetailBook()
        {
            {
                try
                {

                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select * from Book where BookID='" + FrmBook.BookID + "'";    
                    cmd = new SqlCommand(strSql, conn);
                    // MessageBox.Show(FrmEmployee.EmployeeID);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        BookID = dr.GetInt32(0).ToString();
                       // MessageBox.Show(BookID);
                        CallNumber = dr.GetString(1);
                        ISBN = dr.GetString(2);
                        subject = dr.GetInt32(3).ToString();
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
        public void AddBook(String CallNumber, String ISBN, Int32 Subject,String Title, String Author, String Publisher,Int32 NumberofBook,Int32 Bookinlirary)
        {
            //try
            //{
            //    conn = Connect.getConnection();
            //    conn.Open();
            //    dt = Connect.getDT(conn, "Book");
            //    DataRow newRow = dt.NewRow();
            //    newRow["CallNumber"] = CallNumber;
            //    newRow["ISBN"] = ISBN;
            //    newRow["Subject"] = Subject;
            //    newRow["Title"] = Title;
            //    newRow["Author"] = Author;
            //    newRow["Publisher"] = Publisher;
            //    newRow["NumberofBook"] = NumberofBook;
            //    newRow["Bookinlibrary"] = Bookinlirary;
            //    //insert vao database
            //    dt.Rows.Add(newRow);
            //    da.Update(ds, "Book");
            //   // MessageBox.Show("Thêm mới thành công");
            //    //       ds.AcceptChanges();
            //    //da.Fill(ds);
            //    //dataGridView1.DataSource = ds.Tables["Student"];
            //   // reloadgv(DataGridView dgv);
            //   // cmd = new SqlCommand(sqlstr, conn);
            //    //cmd.ExecuteNonQuery();
            //    MessageBox.Show ("Add Book Successfull!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String sqlstr = "insert into Employee values('" + CallNumber + "','" + ISBN + "', '" + Subject + "' ,'"
               + Title + "','" + Author + "','"+ Publisher + "','" + NumberofBook + "','" + Bookinlirary + "')";
                cmd = new SqlCommand(sqlstr, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công ", "Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại!", "Thất Bại");
            }
        }
        public void reloadgv(DataGridView dgv) {
            conn.Open();
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Book");
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            dgv.DataSource = ds.Tables["Book"];
            conn.Close();
        }
    }
}
