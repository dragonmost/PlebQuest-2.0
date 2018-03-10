using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebServer
{
    public static class LogService
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";

        public static void SilentLog(Exception ex)
        {
            Console.WriteLine(ex.Message);

            using (StreamWriter wr = File.AppendText(path))
            {
                wr.WriteLine(DateTime.Now);
                wr.WriteLine(ex.ToString());
            }
        }
    }
}
