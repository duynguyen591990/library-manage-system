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
    public partial class FrmAddSubject : Form
    {
        classSubject cls = new classSubject();
        public FrmAddSubject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (txtSubjectName.Text == "") checkSubjectName.Text = "*Empty";
            //if (txtDescription.Text == "") CheckDescription.Text = "*Empty";
            cls.addsubject(txtSubjectName.Text, txtDescription.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSubjectName.Text="";
            txtDescription.Text="";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmSubject frm=new FrmSubject();
            frm.Show();
            this.Dispose();
        }

    }
}
