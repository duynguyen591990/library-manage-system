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
            clb.reloadgv(dgvBook);
            if (FrmLogin.quyen != "Librarian ") { 
                btnAdd.Enabled = false; 
                btnDelete.Enabled = false; 
                btnEdit.Enabled = false;
            }
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
