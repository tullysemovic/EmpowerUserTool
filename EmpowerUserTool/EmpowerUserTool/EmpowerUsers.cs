using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerUserTool
{
    class EmpowerUsers
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        String path = ConfigurationManager.AppSettings.Get("sitePath");

        public static void Download()
        {
            Console.WriteLine("bb");

        }
    }
}
