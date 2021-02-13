using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
 

namespace Tasker
{
      class clZadatak
    {

        public static SqlConnection dbCon = new SqlConnection();
        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tasks.mdf;Integrated Security=True";

        public  void OpenConnection()
        {
            dbCon = new SqlConnection(constr);

            try
            {
                if (dbCon.State == ConnectionState.Open)
                {
                    dbCon.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public  int ExecuteNonQuerySQL(string cSql)
        {

            if (dbCon.State == ConnectionState.Closed)
                dbCon.Open();

            int i = 0;
            SqlCommand cmd = new SqlCommand(cSql, dbCon);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public  object ExecuteScalarSQL(string cSql)
        {

            if (dbCon.State == ConnectionState.Closed)
                dbCon.Open();

            Object o = new object();

            SqlCommand cmd = new SqlCommand(cSql, dbCon);

            o = cmd.ExecuteScalar();
            return o;

        }

        public  DataTable GetDataTableSQL(string cSql)

        {
            if (dbCon.State == ConnectionState.Closed)
                dbCon.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cSql, dbCon);

            da.Fill(dt);
            return dt;

        }

        //public static DataRow GetDataRow ( string cSql)
        //{

        //    DataRow dt = new DataRow();
        //    return dt;

        //}





    }
}
