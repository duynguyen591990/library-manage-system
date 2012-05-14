using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace librarysystem
{
    public partial class FrmAnalytic : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        FrmMain frmmain = new FrmMain();
        public static int report;
        public FrmAnalytic()
        {
            InitializeComponent();
        }

        private void btnTopBook_Click(object sender, EventArgs e)
        {
            conn = Connect.getConnection();
            conn.Open();
            String strsql = "select BookID, CallNumber, ISBN, SubjectName, Title, Author, Publisher,[No Book] - [Book in Library] [No of Borrowed] from Book, Subject where Book.SubjectID = Subject.SubjectID";
            cmd = new SqlCommand(strsql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Book");
            dgv.DataSource = ds.Tables[0];
            report = 1;
            conn.Close();
        }

        private void btnTopBorrow_Click(object sender, EventArgs e)
        {
         
            conn = Connect.getConnection();
            conn.Open();
            String strsql = "select   Employee.EmployeeID,   Name,   Gender,   Email,   Department,   [Phone number],   Permission,Count(BorrowID)   [No Borrowed] from   Borrow,   Employee where   Borrow.EmployeeID =   Employee.EmployeeID group   by   Employee.EmployeeID,   Name,   Gender,   Email,   Department,   [Phone number],   Permission";
            cmd = new SqlCommand(strsql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Employee");
            dgv.DataSource = ds.Tables[0];
            report = 2;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            conn = Connect.getConnection();
            conn.Open();
            String strsql = "select   Borrow.BorrowID, Borrow.EmployeeID, Book.BookID, Name, CallNumber, Title,   IssueDate,   DueDate from Borrow, Employee, Book,Borrowdetail where   Borrow.EmployeeID =   Employee.EmployeeID and DueDate='" + dtpDueDate.Value.ToString() + "'";
            cmd = new SqlCommand(strsql, conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Employee");
            dgv.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmmain.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DsAnalytic Ds = new DsAnalytic();
            int fields = dgv.Rows.Count;
            for (int i = 0; i <= fields - 2; i++)
            {
                Ds.Tables[0].Rows.Add
                (new object[] { dgv[0,i].Value.ToString(),
                                dgv[1,i].Value.ToString(),
                                dgv[2,i].Value.ToString(),
                                dgv[3,i].Value.ToString(),
                                dgv[4,i].Value.ToString(),
                                dgv[5,i].Value.ToString(),
                                dgv[6,i].Value.ToString(),
                                dgv[7,i].Value.ToString()
                });
            }
            CRAnalytic mCRA = new CRAnalytic(Ds);
            mCRA.Show();
        }

      
       
      
       
    }
   
}
