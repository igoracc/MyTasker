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
        public long TaskID = 0;
        public frmEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // zadatak.addTask(txtCipher.Text, dtP.Value,txtLink.Text,dt)
           



        }

        private void frmEdit_Load(object sender, EventArgs e)
        {






        }
    }
}
