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
    public partial class FrmDetailBook : Form
    {
        public FrmDetailBook()
        {
            InitializeComponent();
        }

        private void FrmDetailBook_Load(object sender, EventArgs e)
        {
            classBook clb = new classBook();
            clb.DetailBook();
            lblBookID.Text = clb.BookID;
            lblCallNumber.Text = clb.CallNumber;
            lblISBN.Text = clb.ISBN;
            lblAuthor.Text = clb.Author;
            lblTitle.Text = clb.Title;
            lblNumberofbook.Text = clb.Numberofbook;
            lblbookinlibrary.Text = clb.Bookinlibrary;
            lblPublisher.Text = clb.Publisher;
            lblSubject.Text = clb.subject;
            clb.loaddetailbook(dgvDetailbook);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmBook frm = new FrmBook();
            this.Hide();
            frm.Show();
        }

    }
}
