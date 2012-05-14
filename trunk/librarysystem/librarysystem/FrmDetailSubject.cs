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
    public partial class FrmDetailSubject : Form
    {
        classSubject cls = new classSubject();
        public FrmDetailSubject()
        {
            InitializeComponent();
        }

        private void FrmDetailSubject_Load(object sender, EventArgs e)
        {
            cls.detailsubject();
            lblSubjectID.Text = cls.SubjectID;
            lblSubjectName.Text = cls.SubjectName;
            lblDescription.Text = cls.Description;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmSubject frm = new FrmSubject();
            this.Hide();
            frm.Show();
        }

    }
}
