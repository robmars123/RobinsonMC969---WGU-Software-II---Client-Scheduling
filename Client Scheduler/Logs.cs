using Client_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler
{
    public static class Logs
    {
        public static void LogInActivity(User user)
        {
            //file path and filename with extension type.
            string file = "log.text";
            //activity information and timestamp.
            string log = $"User {user.userId} - {user.userName} has logged in to the system at {DateTime.Now.ToString("u")}" + Environment.NewLine;

            //write to file and save to bin folder using System.IO.
            File.AppendAllText(file, log);
        }

        public static void LogOutActivity(User user)
        {
            //file path and filename with extension type.
            string file = "log.text";
            //activity information and timestamp.
            string log = $"User {user.userId} - {user.userName} has logged out of the system at {DateTime.Now.ToString("u")}" + Environment.NewLine;

            //write to file and save to bin folder using System.IO.
            File.AppendAllText(file, log);
        }
    }
}
