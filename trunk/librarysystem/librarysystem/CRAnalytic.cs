using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace librarysystem
{
    public partial class CRAnalytic : Form
    {
        private DataSet mDS;
        public CRAnalytic(DataSet ds)
        {
            InitializeComponent();
            mDS = ds;
        }
        
        private void CRAnalytic_Load(object sender, EventArgs e)
        {
            FrmAnalytic frma = new FrmAnalytic();
            ReportDocument cRep = new ReportDocument();
            cRep.Load("D:/library-manage-system/librarysystem/librarysystem/CRAnalytic1.rpt");
            cRep.SetDataSource(mDS);
            crystalReportViewer1.ReportSource = cRep;
            
        }
    }
}
