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

        public long addTask (string cipher, string TaskName, string hyperlink, DateTime dtPlan, decimal cost, short prioritet, int plannedHours,string description, DateTime dtRok)
        {
            int n = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbCon;

            cmd.CommandText = @"INSERT INTO Zadatak (sifra, naziv, link, kopis, prioritet, cijena, datump, userU, PlaniranoSati, Rok ) 

                                             VALUES ( @sifra, @naziv, @link, @kopis, @prioritet,@cijena, @datump, @User, @PlaniranoSati, @Rok )

            ";

            cmd.Parameters.AddWithValue("@sifra", cipher);
            cmd.Parameters.AddWithValue("@naziv", TaskName);
            cmd.Parameters.AddWithValue("@link", hyperlink);
            cmd.Parameters.AddWithValue("@kopis", description);
            cmd.Parameters.AddWithValue("@prioritet", prioritet);
            cmd.Parameters.AddWithValue("@cijena", cost);
            cmd.Parameters.AddWithValue("@datump", dtPlan);
            cmd.Parameters.AddWithValue("@User", "");
            cmd.Parameters.AddWithValue("@PlaniranoSati", plannedHours);
            cmd.Parameters.AddWithValue("@Rok", dtRok);


            try
            {
                cmd.ExecuteNonQuery();
                n = 1;
            }
            catch (Exception)
            {
                n = 0;
                throw;
            }

            return n;

        }

        //sifra = @sifra,
        //        naziv = @naziv,
        //        link = @link,
        //        kopis = @kopis,
        //        prioritet = @prioritet,
        //        cijena = @cijena,
        //        datump = @datump,
        //        userU = @User,
        //        PlaniranoSati = @PlaniranoSati,
        //        Rok = @Rok,
        //        datumZ = @datumZ






    }
}
