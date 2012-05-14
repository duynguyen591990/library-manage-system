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
    public partial class FrmEditBook : Form
    {
        classBook clb = new classBook();
        SqlConnection conn;
        public FrmEditBook()
        {
            InitializeComponent();
        }

        private void txtNumberofBook_TextChanged(object sender, EventArgs e)
        {
            txtonLibrary.Text = txtNumberofBook.Text;
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

        private void FrmEditBook_Load(object sender, EventArgs e)
        {
           // clb.loadcomboxsubject(cboSubject);
            clb.loaddataedit();
            txtCallNumber.Text = clb.CallNumber;
            txtISBN.Text = clb.ISBN;
            txtAuthor.Text = clb.Author;
            txtPublisher.Text = clb.Publisher;
            txtonLibrary.Text = clb.Bookinlibrary;
            txtNumberofBook.Text = clb.Numberofbook;
            txtTitle.Text = clb.Title;
            clb.loadcomboxsubject(cboSubject);
             cboSubject.SelectedValue = clb.subject;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCallNumber.Text == "") checkCallNumber.Text = "*Empty";
            if (txtISBN.Text == "") CheckISBN.Text = "*Empty";
            if (txtPublisher.Text == "") CheckPublisher.Text = "*Empty";
            if (txtTitle.Text == "") CheckTitle.Text = "*Empty";
            if (txtAuthor.Text == "") CheckAuthor.Text = "*Empty";
            if (txtPublisher.Text == "") CheckPublisher.Text = "*Empty"; 

           int subjectid = Int32.Parse(cboSubject.SelectedValue.ToString());
           clb.updateBook(txtCallNumber.Text, txtISBN.Text, subjectid, txtTitle.Text, txtAuthor.Text,
 txtPublisher.Text, Int32.Parse(txtNumberofBook.Text), Int32.Parse(txtonLibrary.Text));
            this.Dispose();
            FrmBook frm=new FrmBook();
            frm.Show();
            this.Hide();
        }
    }
}
