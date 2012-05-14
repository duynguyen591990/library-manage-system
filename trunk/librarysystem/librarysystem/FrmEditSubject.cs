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
    public partial class FrmEditSubject : Form
    {
        classSubject cls = new classSubject();
        public FrmEditSubject()
        {
            InitializeComponent();
        }

        private void FrmEditSubject_Load(object sender, EventArgs e)
        {
            cls.loaddataedit();
            txtSubjectName.Text = cls.SubjectName;
            txtDescription.Text = cls.Description;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (txtSubjectName.Text == "") checkSubjectName.Text = "*Empty";
            //if (txtDescription.Text == "") CheckDescription.Text = "*Empty";
            cls.updateSubject(txtSubjectName.Text, txtDescription.Text);
            this.Dispose();
            FrmSubject frm = new FrmSubject();
            frm.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSubjectName.Text = "";
            txtDescription.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmSubject frm = new FrmSubject();
            frm.Show();
            this.Hide();
        }
    }
}
