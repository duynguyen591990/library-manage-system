using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace librarysystem
{
    

    class classEmployee
    {
        SqlConnection conn;
        SqlCommand cmd,cmd1;
        SqlDataReader rd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        public String txtEmployeeID, txtName, txtDate, txtGender,
            txtAddress, txtEmail, txtPassword, txtPermission, txtPhone, txtDepartment;

        public void AddEmployee(String txtName, String date, String gender, String txtAddress, String txtEmail, String txtPassword, String cboPermission, String txtPhone, String txtDepartment)
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();        
                String sqlstr = "insert into Employee values('" + txtName + "','" + date + "', '" + gender + "' ,'" + txtAddress + "','" + txtEmail + "','" + txtPassword + "','" + cboPermission + "','" + txtPhone + "','" + txtDepartment + "')";
                cmd = new SqlCommand(sqlstr, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công " + txtName + " vào CSDL", "Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại!", "Thất Bại");
            }
        }
        public void load_permission(ComboBox cbo)
        {
                conn = Connect.getConnection();
                conn.Open();
                dt = Connect.getDataTable(conn, "Employee");
                cbo.DataSource = dt;
                cbo.DisplayMember = dt.Columns[0].ToString();
                cbo.ValueMember = dt.Columns[0].ToString();
               
        }

        public void fillDataDetailEmployee()
        {
            try
            {

                conn = Connect.getConnection();
                conn.Open();
                String strSql = "select * from Employee where EmployeeID='"+FrmEmployee.EmployeeID+"'";
                cmd = new SqlCommand(strSql, conn);
               // MessageBox.Show(FrmEmployee.EmployeeID);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txtEmployeeID = rd.GetInt32(0).ToString();
                    txtName = rd.GetString(1);
                    txtDate = rd.GetDateTime(2).ToString();
                    txtGender = rd.GetBoolean(3).ToString();
                    if (txtGender.Equals("True"))
                        txtGender = "Male";
                    else txtGender = "Female";
                    txtAddress = rd.GetString(4);
                    txtEmail = rd.GetString(5);
                    txtPassword = rd.GetString(6);
                    txtPermission = rd.GetString(7);
                    txtPhone = rd.GetString(8);
                    txtDepartment = rd.GetString(9);
                   
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillDataEditEmployee()
        {
            try
            {

                conn = Connect.getConnection();
                conn.Open();
                String strSql = "select * from Employee where EmployeeID='" + FrmEmployee.EmployeeIDE + "'";
                cmd = new SqlCommand(strSql, conn);
                // MessageBox.Show(FrmEmployee.EmployeeID);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txtEmployeeID = rd.GetInt32(0).ToString();
                    txtName = rd.GetString(1);
                    txtDate = rd.GetDateTime(2).ToString();
                    txtGender = rd.GetBoolean(3).ToString();
                    txtAddress = rd.GetString(4);
                    txtEmail = rd.GetString(5);
                    txtPassword = rd.GetString(6);
                    txtPermission = rd.GetString(7);
                    txtPhone = rd.GetString(8);
                    txtDepartment = rd.GetString(9);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateEmployee(String name, String date, String gender, String address, String email, String password, String permission, String phone, String department)
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String strSql = "update Employee set Name='" + name + "',[Date of birth]='" + date + "',Gender='" + gender + "',Address='" + address + "',Email='" + email + "',Password='" + password + "',Permission='" + permission + "',[Phone number]='" + phone + "',Department='" + department + "' where EmployeeID='" + FrmEmployee.EmployeeIDE + "'";
                cmd = new SqlCommand(strSql, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfull!", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        public void deleteEmployee()
        {
            try
            {
                conn = Connect.getConnection();
                conn.Open();
                String strsql1 = " select * from Borrow where EmployeeID='" + FrmEmployee.EmployeeIDD + "'";
                cmd1 = new SqlCommand(strsql1, conn);
                da = new SqlDataAdapter(cmd1);
                ds = new DataSet();
                dt = new DataTable();
                da.Fill(ds, "Borrow");
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Employee is borrowing book", "Alert");
                }
                else
                {
                    String strSql = "delete Employee where EmployeeID='" + FrmEmployee.EmployeeIDD + "'";
                    cmd = new SqlCommand(strSql, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete success!", "Alert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        
        }

        public void searcheEmployee(String cbo, String ID, DataGridView dgv)
        {
            if (cbo == "ID")
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select * from Employee where EmployeeID='" + ID + "'";
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Employee");
                    dgv.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
            else
            {
                try
                {
                    conn = Connect.getConnection();
                    conn.Open();
                    String strSql = "select * from Employee where Name like '%" + ID + "%'";
                    cmd = new SqlCommand(strSql, conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Employee");
                    dgv.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
        }

        public void loadall(DataGridView dgv)
        {
            conn = Connect.getConnection();
            conn.Open();
            String strSql = "select * from Employee";
            cmd = new SqlCommand(strSql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Employee");
            dgv.DataSource = ds.Tables[0];
        }

        public void loaddetailemployee(DataGridView dgv)
        {
            conn = Connect.getConnection();
            conn.Open();
            String sql = "select title,CallNumber,ISBN,SubjectName,author,publisher from Subject e, Employee a,Borrowdetail b, Book d where a.EmployeeID=b.EmployeeID and b.bookID = d.bookID and d.subjectID = e.subjectID  and a.EmployeeID='"
                + FrmEmployee.EmployeeID + "'";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Employee");
            dgv.DataSource = ds.Tables["Employee"];
            conn.Close();
        }
    }
}
