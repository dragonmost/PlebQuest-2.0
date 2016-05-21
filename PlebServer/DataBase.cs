using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebServer
{
    class DataBase
    {
        static MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();
        const string SERVER = "localhost";
        const string USERID = "root";
        const string DATABASE = "plebquest";
        const string PASSWORD = "root";


        static MySqlConnection DbConnect()
        {
            connString.Server = SERVER ;
            connString.UserID = USERID;
            connString.Password = PASSWORD;
            connString.Database = DATABASE;
            return new MySqlConnection(connString.ToString());
        }

        public static bool DbExecute(string query)
        {
            try
            {
                using (MySqlConnection conn = DbConnect())
                using (MySqlCommand cmd = conn.CreateCommand())
                {    //watch out for this SQL injection vulnerability below
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                LogService.SilentLog(ex);
                return false;
            }

            return true;
        }



    }
}
