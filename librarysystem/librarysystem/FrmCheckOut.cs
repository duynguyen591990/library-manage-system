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
    public partial class FrmCheckOut : Form
    {
        classEmployee cle = new classEmployee();
        classBook clb = new classBook();
        public FrmCheckOut()
        {
            InitializeComponent();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            clb.searchBook(cboBook.Text, txtBookSearch.Text, dataGridView1);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            cle.searcheEmployee(cboEmployee.Text, txtEmployeeSearch.Text, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
           // for (int i = 0; i <6 ; i++)
           //{
           //     // int  c = this.dataGridView1.CurrentCell.ColumnIndex;
           //     //MessageBox.Show(dataGridView1.Rows[r].Cells[i].Value.ToString());
           //     // dataGridView2.Rows.Add(dataGridView1.Rows[r].Cells[i].Value.ToString());
           //     // dataGridView2.Columns.AddRange(
           //  //dataGridView2.Rows[0].Cells[i].Value = dataGridView1.Rows[r].Cells[i].Value;
           // //DataGridViewColumn[] dc = new DataGridViewColumn[] {dataGridView1.Columns[0]};
           //}
            dataGridView2.Rows[0].Cells[0].Value = dataGridView1.Rows[r].Cells[0].Value;
            dataGridView2.Rows[0].Cells[1].Value = dataGridView1.Rows[r].Cells[1].Value;
            dataGridView2.Rows[0].Cells[2].Value = dataGridView1.Rows[r].Cells[2].Value;
            dataGridView2.Rows[0].Cells[3].Value = dataGridView1.Rows[r].Cells[4].Value;
            dataGridView2.Rows[0].Cells[4].Value = dataGridView1.Rows[r].Cells[5].Value;
            dataGridView2.Rows[0].Cells[5].Value = dataGridView1.Rows[r].Cells[6].Value;
           // dataGridView2.Columns.Add(dataGridView1.Rows[r].Cells[i].Value.ToString(),);
            //MessageBox.Show(dataGridView2.Columns[0].DataPropertyName) ;
                 //dataGridView2.Rows[0].Cells[0].Value = 0;
                 //dataGridView2.Rows[0].Cells[1].Value = 1;
        }

    }
}
