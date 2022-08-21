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

            gatherData("");




        }


        private void gatherData ( string search)
        {
            sql = @"   SELECT 
                      [id]
                      ,[cipher]
                      ,[name]
                      ,[link]
                      ,[description] ,

	                  case isnull(status,0) when 0 then 'Not defined'
	                  when 1 then 'Started'
	                  when 2 then 'Paused'
	                  when 3 then 'Stopped'
	                  when 4 then 'Finished'
	                  end as status,

	                  case isnull(priority,0) 
	                  when 1 then 'Low'
	                  when 2  then 'Medium'
	                  when 3 then 'High'
	                  when 4 then 'Emergency'
	                  ELSE 'Not set'  end as priority

                      ,[price]
                      ,[dateCreated]
                      ,[datePlanned]
                      ,[dateFinished]
                      ,[dateInsert]
                      ,[userU]
                      ,[plannedTime]
                      ,[DateDue]
                      ,[deleted]

                  FROM [tasks].[dbo].[Zadatak] 

                    WHERE isnull(deleted,0) = 0 ";


            DataTable dt = new DataTable();
            dt = zadatak.GetDataTableSQL(sql);

            bsData.DataSource = dt;


            if (dataGridView1.Rows.Count > 0)
            {
                TaskID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtDescription.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            }

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text != "")
                gatherData(txtSearch.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmEdit form = new frmEdit();
            form.TaskID = 0;
            form.modus = 1;
            form.ShowDialog();

            gatherData("");
        }


        private void bsData_PositionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count>0)
            {
                TaskID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtDescription.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            }

        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            frmEdit form = new frmEdit();
            form.TaskID = TaskID;
            form.modus = 2;
            form.ShowDialog();

            gatherData("");

        }

    }
}
