using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tasker
{


    public partial class frmGlavna : Form
    {
        clZadatak zadatak = new clZadatak();
        string sql;
        long TaskID = 0;    

        public frmGlavna()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            zadatak.OpenConnection();






        }


        private void gatherData ( string search)
        {
            sql = " SELECT * from zadatak WHERE deleted = 0 ";


            DataTable dt = new DataTable();
            dt = zadatak.GetDataTableSQL(sql);

            bsData.DataSource = dt;

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
                gatherData(textBox1.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmEdit form = new frmEdit();
            form.ShowDialog();

           

            gatherData("");
        }


        private void bsData_PositionChanged(object sender, EventArgs e)
        {

                  TaskID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            


        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            frmEdit form = new frmEdit();
            form.TaskID = TaskID;
            form.ShowDialog();

        }
    }
}
