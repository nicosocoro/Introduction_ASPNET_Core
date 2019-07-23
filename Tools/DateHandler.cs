using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Tools
{
    public static class DateHandler
    {
        #region PROPERTIES
        public static string DateTime_YYYYMMDD
        {
            get
            {
                return DateTime.Now.ToString("yyyyMMdd");
            }
        }
        #endregion

        #region FUNCTIONS
        /// <summary>
        /// Returns current date in format "DD/MM/YYYY"
        /// </summary>
        /// <returns></returns>
        public static string GetDateTime_DD_MM_YYYY()
        {
            string str_year = DateTime_YYYYMMDD.Substring(0, 4);
            string str_month = DateTime_YYYYMMDD.Substring(4, 2);
            string str_day = DateTime_YYYYMMDD.Substring(6, 2);

            return str_day + "/" + str_month + "/" + str_year;
        }
        #endregion
    }
}
