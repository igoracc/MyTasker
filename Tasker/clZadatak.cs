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
        // public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tasks.mdf;Integrated Security=True";

       // public static string constr = @"Server=myServerAddress;Database=myDataBase;User Id = sa; Password=12!?qwQW;";

        public static string constr = @"Server=WORKSTATION\SQL;Database=tasks;User Id = sa; Password=12!?qwQW;";


        public  void OpenConnection()
        {
            dbCon = new SqlConnection(constr);

            try
            {
                if (dbCon.State != ConnectionState.Open)
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

        public string cipher (string table, string format) 
        {
            long ciphra = 1;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText= " SELECT MAX ( cipher ) + 1 FROM " + table + " WHERE isnull(deleted,0)=0 ";
            cmd.Connection = dbCon;

            ciphra =Convert.ToInt64(   cmd.ExecuteScalar() );

            string result = ciphra.ToString("D4");

            return result;

        }

        public long addTask (string cipher, string TaskName, string hyperlink, DateTime dtPlan, decimal cost, int prioritet, int plannedHours,string description, DateTime dtRok)
        {
            int n = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbCon;

            cmd.CommandText = @"INSERT INTO Zadatak (cipher, name, link, description, priority, price, dateCreated, userU, plannedTime, datePlanned ) 

                                             VALUES ( @cipher, @name, @link, @description, @priority,@price, @dateCreated, @UserU, @plannedTime, @datePlanned )

            ";

            cmd.Parameters.AddWithValue("@cipher", cipher);
            cmd.Parameters.AddWithValue("@name", TaskName);
            cmd.Parameters.AddWithValue("@link", hyperlink);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@priority", prioritet);
            cmd.Parameters.AddWithValue("@price", cost);
            cmd.Parameters.AddWithValue("@dateCreated", dtPlan);
            cmd.Parameters.AddWithValue("@UserU", "");
            cmd.Parameters.AddWithValue("@plannedTime", plannedHours);
            cmd.Parameters.AddWithValue("@datePlanned", dtRok);


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



        public long UpdateTask(long ID, string cipher, string TaskName, string hyperlink, DateTime dtPlan, decimal cost, int prioritet, int plannedHours, string description, DateTime dtRok)
        {
            int n = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbCon;

            cmd.CommandText = @"UPDATE Zadatak SET
                                    name = @name,
                                    link = @link,
                                    description = @description,
                                    priority = @priority,
                                    price =@price,
                                    dateCreated = @dateCreated,
                                    userU = @userU,
                                    plannedTime = @plannedTime,
                                    datePlanned = @datePlanned

                                    WHERE id = @ID

            ";

            cmd.Parameters.AddWithValue("@cipher", cipher);
            cmd.Parameters.AddWithValue("@name", TaskName);
            cmd.Parameters.AddWithValue("@link", hyperlink);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@priority", prioritet);
            cmd.Parameters.AddWithValue("@price", cost);
            cmd.Parameters.AddWithValue("@dateCreated", dtPlan);
            cmd.Parameters.AddWithValue("@UserU", "");
            cmd.Parameters.AddWithValue("@plannedTime", plannedHours);
            cmd.Parameters.AddWithValue("@datePlanned", dtRok);
            cmd.Parameters.AddWithValue("@ID", ID);


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

        public long FinishTask(long ID,  string description)
        {
            int n = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbCon;

            cmd.CommandText = @"UPDATE Zadatak SET
                                   
                                    description = @description,
                                    status = 4

                                    WHERE id = @ID

            ";

            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@ID", ID);


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
