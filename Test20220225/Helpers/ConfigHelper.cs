using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Test20220225.Helpers
{
    public class ConfigHelper
    {
        private const string _test99DB = "Test99DB";
        /// <summary>
        /// 讀取設定檔中的連線字串
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return GetConnectionString(_test99DB);
        }
        /// <summary>
        /// 讀取設定檔中的連線字串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            string connString =
                ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return connString;
        }
    }
}