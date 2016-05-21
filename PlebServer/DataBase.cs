using MySql.Data.MySqlClient;
using PlebQuest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            connString.Server = SERVER;
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

        public static MySqlDataReader DbRead(string query)
        {
            try
            {
                using (MySqlConnection conn = DbConnect())
                using (MySqlCommand cmd = conn.CreateCommand())
                {    //watch out for this SQL injection vulnerability below
                    cmd.CommandText = query;
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                    return reader;
                }
            }
            catch (Exception ex)
            {
                LogService.SilentLog(ex);
                return null;
            }

        }



        public Race[] GetRacesOffline()
        {
            List<Race> races = new List<Race>();
            try
            {
                MySqlDataReader reader = DbRead("SELECT * FROM `races` ORDER BY name ASC");
                while (reader.Read())
                {
                    Debug.WriteLine(reader.GetString("name"));
                    races.Add(Race.Create(reader));
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                LogService.SilentLog(ex);
            }

            return races.ToArray();
        }

    }
}
