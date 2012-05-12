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
    public partial class FrmBook : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        FrmMain frmmain = new FrmMain();
        classBook clb = new classBook();
        public static String BookID, BookIDE, BookIDD;
        public FrmBook()
        {
            InitializeComponent();
        }

        private void FrmBook_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clb.searchBook(cbxSearch.Text, txtSearch.Text,dgvBook);
            //if (cbxSearch.SelectedItem.ToString().Equals("All"))
            //{
            //    try
            //    {
            //        conn = Connect.getConnection();
            //        conn.Open();
            //        String strsql = "select * from Book";
            //        cmd = new SqlCommand(strsql, conn);
            //        da = new SqlDataAdapter(cmd);
            //        ds = new DataSet();
            //        da.Fill(ds, "Book");
            //        dgvBook.DataSource = ds.Tables[0];

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error " + ex.Message);
            //    }
            //}
            //else   if (cbxSearch.SelectedItem.ToString().Equals("CallNumber"))
            //{
            //    try
            //    {
            //        conn = Connect.getConnection();
            //        conn.Open();
            //        String strSql = "select * from Book where CallNumber='" + txtSearch.Text + "'";
            //        cmd = new SqlCommand(strSql, conn);
            //        da = new SqlDataAdapter(cmd);
            //        ds = new DataSet();
            //        da.Fill(ds, "Book");
            //        dgvBook.DataSource = ds.Tables[0];

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error " + ex.Message);
            //    }
            //}
            //else

            //    if (cbxSearch.SelectedItem.ToString().Equals("ISBN"))
            //    {
            //        try
            //        {
            //            conn = Connect.getConnection();
            //            conn.Open();
            //            String strSql = "select * from Book where ISBN='" + txtSearch.Text + "'";
            //            cmd = new SqlCommand(strSql, conn);
            //            da = new SqlDataAdapter(cmd);
            //            ds = new DataSet();
            //            da.Fill(ds, "Book");
            //            dgvBook.DataSource = ds.Tables[0];

            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error " + ex.Message);
            //        }
            //    } else
            //        if (cbxSearch.SelectedItem.ToString().Equals("Title"))
            //        {
            //            try
            //            {
            //                conn = Connect.getConnection();
            //                conn.Open();
            //                String strSql = "select * from Book where Title like'" + txtSearch.Text + "'";
            //                MessageBox.Show(strSql);
            //                cmd = new SqlCommand(strSql, conn);
            //                da = new SqlDataAdapter(cmd);
            //                ds = new DataSet();
            //                da.Fill(ds, "Book");
            //                dgvBook.DataSource = ds.Tables[0];

            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error " + ex.Message);
            //            }
            //        } else 

            //{
            //    try
            //    {
            //        conn = Connect.getConnection();
            //        conn.Open();
            //        String strSql = "select * from Book where Author like '%" + txtSearch.Text + "%'";
            //        cmd = new SqlCommand(strSql, conn);
            //        da = new SqlDataAdapter(cmd);
            //        ds = new DataSet();
            //        da.Fill(ds, "Book");
            //        dgvBook.DataSource = ds.Tables[0];

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error " + ex.Message);
            //    }
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddBook frmadd = new FrmAddBook();
            frmadd.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            BookID = dgvBook.CurrentRow.Cells[0].Value.ToString();
            FrmDetailBook frm = new FrmDetailBook();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmmain.Show();
            this.Dispose();
        }

    }
}
