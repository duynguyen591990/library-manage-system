using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace librarysystem
{
    public partial class FrmSubject : Form
    {
        classSubject cls = new classSubject();
        static public String SubjectID, SubjectIDD, SubjectIDE;
        public FrmSubject()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cls.searchBook(cbxSearch.Text,txtSearch.Text,dgvSubject);
        }

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            cls.reloadgv(dgvSubject);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddSubject frmadd = new FrmAddSubject();
            frmadd.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SubjectIDE = dgvSubject.CurrentRow.Cells[0].Value.ToString();
            FrmEditSubject frmedit = new FrmEditSubject();
            frmedit.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SubjectID = dgvSubject.CurrentRow.Cells[0].Value.ToString();
            FrmDetailSubject frmdetail = new FrmDetailSubject();
            frmdetail.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SubjectIDD = dgvSubject.CurrentRow.Cells[0].Value.ToString();
            cls.deleteSubject();
            cls.reloadgv(dgvSubject);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain frmmain = new FrmMain();
            frmmain.Show();
            this.Dispose();
        }
    }
}
