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
    public partial class FrmAddBook : Form
    {
        classBook clb = new classBook();
       SqlConnection conn;
        public FrmAddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCallNumber.Text == "") checkCallNumber.Text = "*Empty"; 
            if (txtISBN.Text == "")  CheckISBN.Text = "*Empty"; 
            if (txtPublisher.Text == "") CheckPublisher.Text = "*Empty"; 
            if (txtTitle.Text == "")  CheckTitle.Text = "*Empty"; 
            if (txtAuthor.Text == "")  CheckAuthor.Text = "*Empty"; 
            if (txtPublisher.Text == "")  CheckPublisher.Text = "*Empty"; 
            //if (txtNumberofBook.Text == "") { check.Text = "*Empty"; };
            //if (txtonLibrary.Text == "") { checkBookID.Text = "*Empty"; 
            int subjectid = Int32.Parse(cboSubject.SelectedValue.ToString());
            clb.AddBook(txtCallNumber.Text, txtISBN.Text, subjectid, txtTitle.Text, txtAuthor.Text,
             txtPublisher.Text, Int32.Parse(txtNumberofBook.Text), Int32.Parse(txtonLibrary.Text));
        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {
            clb.loadcomboxsubject(cboSubject);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCallNumber.Text = "";
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtPublisher.Text = "";
            txtNumberofBook.Text = "";
            txtonLibrary.Text = "";
            txtAuthor.Text = "";
            cboSubject.SelectedItem = null;          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmBook frm = new FrmBook();
            frm.Show();
            this.Dispose();
        }

        private void txtNumberofBook_TextChanged(object sender, EventArgs e)
        {
            txtonLibrary.Text = txtNumberofBook.Text;
        }

    }
}