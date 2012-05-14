﻿using System;
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
        FrmAnalytic frmanalytic = new FrmAnalytic();

        public CRAnalytic(DataSet ds)
        {
            InitializeComponent();
            mDS = ds;
        }
        
        private void CRAnalytic_Load(object sender, EventArgs e)
        {
           
            ReportDocument cRep = new ReportDocument();   
            if(FrmAnalytic.report == 1)
            cRep.Load("C:/Users/Administrator/Desktop/QLDA/library-manage-system/librarysystem/librarysystem/CRTopBook.rpt");
            else 
            cRep.Load("C:/Users/Administrator/Desktop/QLDA/library-manage-system/librarysystem/librarysystem/CRTopBorrow.rpt");
            cRep.SetDataSource(mDS);
            crystalReportViewer1.ReportSource = cRep;
            
        }
    }
}
