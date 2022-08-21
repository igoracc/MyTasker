using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tasker
{
    public partial class frmEdit : Form
    {
        clZadatak zadatak = new clZadatak();

        /// <summary>
        /// /the property for editing
        /// </summary>
        public long TaskID = 0;
        public short modus = 0; 


        public frmEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modus == 1)
            {
                zadatak.addTask(txtCipher.Text, txtName.Text, txtLink.Text, dtP.Value, numCost.Value, cbPriority.SelectedIndex, Convert.ToInt16(numPlannedHours.Value), txtDescription.Text, dtP.Value);

            }
            else if (modus == 2)
            {
                zadatak.UpdateTask(TaskID, txtCipher.Text, txtName.Text, txtLink.Text, dtP.Value, numCost.Value, cbPriority.SelectedIndex, Convert.ToInt16(numPlannedHours.Value), txtDescription.Text, dtP.Value);
            }



            this.Close();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

            if (modus == 1 )
            {
                txtCipher.Text = zadatak.cipher("zadatak", "00000");
            }
            else if (modus != 1)
            {
                gatherData(TaskID);
            }




        }

        private void gatherData ( long idStav )
        {
            string sq = string.Format(@"
                              SELECT ID,
                              cipher, name, link, description, price, 
                              isnull(dateCreated,'') AS dateCreated,
                              isnull(datePlanned,'') AS datePlanned, 
                              isnull(dateFinished,'') AS dateFinished, 
                              isnull(plannedTime,0),
                              isnull(dateDue,'') as dateDue,
                              isnull(priority,0) AS priority
                              FROM Zadatak
                              WHERE id = {0}
                              " ,idStav );



            DataTable dt = new DataTable();
            dt = zadatak.GetDataTableSQL(sq);

            foreach( DataRow row in dt.Rows )
            {

                txtCipher.Text = row.Field<string>("cipher");


                txtName.Text = row.Field<string>("name");
                txtLink.Text = row.Field<string>("link");
                txtDescription.Text = row.Field<string>("description");
                numCost.Text = row.Field<decimal>("price").ToString();

                dtP.Text = row.Field<DateTime>("datePlanned").ToString(); 


               cbPriority.SelectedIndex = Convert.ToInt32( row.Field<Int16>("priority"));


            }



        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
