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
    public partial class FrmLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        //SqlDataAdapter da;
       // DataSet ds;
        //DataTable dt;
        SqlDataReader rd;
       public static string quyen;
       public static string Username;
       
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = txtusername.Text;
            try
            {

                conn = Connect.getConnection();
                if (conn != null)
                {
                    conn.Open();
                    String strsql = "select Permission from Employee where Name= '" + txtusername.Text + "' and Password= '" + txtpassword.Text + "'";
                    cmd = new SqlCommand(strsql, conn);
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        quyen = rd.GetValue(0).ToString();
                        if (quyen.Equals("Librarian "))
                        {
                            MessageBox.Show("Welcome Librarian Login Success!");
                            this.Hide();
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();


                        }
                        else
                        {
                            MessageBox.Show("Welcome " + txtusername.Text + " login success!");
                            this.Hide();
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Username or password wrong!");
                        txtpassword.Clear();
                        txtusername.Clear();
                        txtusername.Focus();

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Username or password wrong!");
                txtusername.Focus();
            }

        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
