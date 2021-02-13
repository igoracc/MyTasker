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


    public partial class frmMain : Form
    {
        clZadatak zadatak = new clZadatak();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            zadatak.OpenConnection();

            string sql;

            sql = " SELECT * from zadatak";

            zadatak.ExecuteNonQuerySQL("INSERT INTO zadatak (sifra) VALUES ('001') ");

            //bsData.DataSource = zadatak.GetDataTableSQL(sql);

            DataTable dt = new DataTable();
            dt = zadatak.GetDataTableSQL(sql);

            bsData.DataSource = dt;


        }
    }
}
