using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace librarysystem
{
    class classSubject
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        SqlDataReader dr;
        public String SubjectID, SubjectName, Description;
        public void searchBook(String cbxSearch, String txtSearch, DataGridView dgvBook)
        {

            if (cbxSearch == "All")
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strsql = "select * from Subject";
                    cmd = new SqlCommand(strsql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Subject");
                    dgvBook.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            else if (cbxSearch == "Subject ID")
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select * from Subject where SubjectID ='" + txtSearch + "'";
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Subject");
                    dgvBook.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            else

                if (cbxSearch == "Subject Name")
                {
                    try
                    {
                        conn = Connect.getConnection();
                        conn.Open();
                        String strSql = "select * from Subject where SubjectName like '%" + txtSearch + "%'";
                        cmd = new SqlCommand(strSql, conn);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "Subject");
                        dgvBook.DataSource = ds.Tables[0];

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
            String strSql = "select * from Subject"; 
            cmd = new SqlCommand(strSql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Subject");
            dgv.DataSource = ds.Tables["Subject"];
            conn.Close();
        }
        public void addsubject(String SubjectName,String Description)
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String sqlstr = "insert into Subject values('" + SubjectName + "','" + Description  + "')";
                cmd = new SqlCommand(sqlstr, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add new subject successfull ", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
        public void loaddataedit()
        {
            {
                try
                {

                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select * from Subject where SubjectID='" + FrmSubject.SubjectIDE + "'";
                    cmd = new SqlCommand(strSql, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        SubjectID = dr.GetInt32(0).ToString();
                        SubjectName= dr.GetString(1);
                        Description = dr.GetString(2);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void updateSubject(String SubjectName,String Description)
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String strSql = "update Subject set SubjectName='" +SubjectName + "',Description='" +Description + "' where SubjectID='"+FrmSubject.SubjectIDE+"'";
                cmd = new SqlCommand(strSql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfull!", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void deleteSubject()
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String sql = " select * from Book where SubjectID='" + FrmSubject.SubjectIDD + "'";
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                dt = new DataTable();
                da.Fill(ds, "Subject");
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Many Book is using this Subject so you can't delete it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    String strSql = "delete Subject where SubjectID='" + FrmSubject.SubjectIDD + "'";
                    cmd = new SqlCommand(strSql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfull!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }
        public void detailsubject()
        {
            {
                try
                {

                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select * from Subject where SubjectID='" + FrmSubject.SubjectID + "'";
                    cmd = new SqlCommand(strSql, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        SubjectID = dr.GetInt32(0).ToString();
                        SubjectName = dr.GetString(1);
                        Description = dr.GetString(2);
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
