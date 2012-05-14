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


        classBook clb = new classBook();
        public static String BookID, BookIDE, BookIDD;
        public FrmBook()
        {
            InitializeComponent();
        }

        private void FrmBook_Load(object sender, EventArgs e)
        {
            //conn = Connect.getConnection();
            //conn.Open();
            //String strsql = "select BookID,CallNumber,ISBN,Subject.SubjectName,Title,Author,Publisher,[No Book],[Book in Library] from Book,Subject where Subject.SubjectID=Book.SubjectID";
            //cmd = new SqlCommand(strsql, conn);
            //da = new SqlDataAdapter(cmd);
            //ds = new DataSet();
            //da.Fill(ds, "Book");
            //dgvBook.DataSource = ds.Tables[0];
            clb.reloadgv(dgvBook);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clb.searchBook(cbxSearch.Text, txtSearch.Text,dgvBook);
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
            FrmMain frmmain = new FrmMain();
            frmmain.Show();
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookIDD = dgvBook.CurrentRow.Cells[0].Value.ToString();
            clb.deleteBook();
            clb.reloadgv(dgvBook);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BookIDE = dgvBook.CurrentRow.Cells[0].Value.ToString();
            FrmEditBook frmedit = new FrmEditBook();
            frmedit.Show();
            this.Hide();
        }

    }
}
