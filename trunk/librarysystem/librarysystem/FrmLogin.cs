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
       public static string Username;
       
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = txtusername.Text;
            String quyen;
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
                            MessageBox.Show("Chúc mừng Librarian đã đăng nhập thành công", "Thành Công");
                            this.Hide();
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();


                        }
                        else
                        {
                            MessageBox.Show("Chúc mừng " + txtusername.Text + " đã đăng nhập thành công", "Thành Công");
                            this.Hide();
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Tên hoặc mật khẩu sai!");
                        txtpassword.Clear();
                        txtusername.Clear();
                        txtusername.Focus();

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ", "Có lỗi xảy ra");
                txtusername.Focus();
            }

        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
