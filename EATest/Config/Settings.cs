using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EAAutoFramework.Config
{
    public class Settings


    {
        public static string TestType { get; set; }
        public static string AUT { get; set; }
        public static string Build { get; set; }
        //public static BrowserType BrowserType { get; set; }
        public static string IsLog { get; set; }
        public static string LogPath { get; set; }
        public static string BuildName { get; internal set; }
        public static string IsReporting { get; internal set; }
    }
}
