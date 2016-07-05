using MySql.Data.MySqlClient;
using PlebQuest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PlebServer
{
    class DataBase
    {
        static MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();
        const string SERVER = "localhost";
        const string USERID = "root";
        const string DATABASE = "plebquest";
        const string PASSWORD = "root";

        private static MySqlConnection conn;

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
                conn = DbConnect();
                MySqlCommand cmd = conn.CreateCommand();
                    //watch out for this SQL injection vulnerability below
                    cmd.CommandText = query;
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //conn.Close();
                    return reader;
                
            }
            catch (Exception ex)
            {
                LogService.SilentLog(ex);
                return null;
            }

        }

        public static T[] GetDBObjects<T>(string tableName)
        {
            List<T> objects = new List<T>();
            try
            {
                MySqlDataReader reader = DbRead("SELECT * FROM `" + tableName + "` ORDER BY name ASC");
                while (reader.Read())
                {
                    //Debug.WriteLine(reader.GetString("name"));

                    MethodInfo method = typeof(T).GetMethod("Create");
                    object obj = method.Invoke(null, new object[]{ reader});

                    objects.Add((T)obj);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                LogService.SilentLog(ex);
            }
            finally
            {
                conn.Close();
            }

            return objects.ToArray();
        }

        public static Pleb GetPleb(string username, string password)
        {
            try
            {
                MySqlDataReader reader = DbRead("SELECT * FROM `characters` " + 
                    "WHERE name='" + username + "' AND '" + password + "'");

                Pleb pleb = (Pleb)Activator.CreateInstance(typeof(Pleb));
                return pleb;

                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                LogService.SilentLog(ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
