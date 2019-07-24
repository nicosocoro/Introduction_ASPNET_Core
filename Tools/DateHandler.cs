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
            return TransformYYYYDDMM_to_MM_DD_YYYY(DateTime_YYYYMMDD);
        }

        /// <summary>
        /// Transform the entry date with format "YYYYMMDD" to formato "DD/MM/YYYY"
        /// </summary>
        /// <param name="oDate"></param>
        /// <returns></returns>
        public static string TransformYYYYDDMM_to_MM_DD_YYYY(int oDate)
        {
            string str_date = oDate.ToString();

            return TransformYYYYDDMM_to_MM_DD_YYYY(str_date);
        }

        /// <summary>
        /// Transform the entry date with format "YYYYMMDD" to formato "DD/MM/YYYY"
        /// </summary>
        /// <param name="oDate"></param>
        /// <returns></returns>
        public static string TransformYYYYDDMM_to_MM_DD_YYYY(string oDate)
        {
            string str_year = oDate.Substring(0, 4);
            string str_month = oDate.Substring(4, 2);
            string str_day = oDate.Substring(6, 2);

            return str_day + "/" + str_month + "/" + str_year;
        }
        #endregion
    }
}
