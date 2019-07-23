using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Models.Dummy
{
    public class dUser
    {
        #region FUNCTIONS
        /// <summary>
        /// Return a hardcoded list of Users for signing up.
        /// </summary>
        List<Entities.eUser> lst_users
        {
            get
            {
                return new List<Entities.eUser>
                {
                    new Entities.eUser(1, "admin1", "password1"),
                    new Entities.eUser(2, "admin2", "password2"),
                    new Entities.eUser(3, "admin3", "password3")
                };
            }
        }

        /// <summary>
        /// Returns
        /// TRUE if exists user with UserName and Password
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public bool ValidateUser(string pUserName, string pPassword)
        {
            return lst_users.Any(x => x.UserName == pUserName && x.Password == pPassword);
        }

        /// <summary>
        /// Return a list of Dummy Users.
        /// </summary>
        /// <returns></returns>
        public List<Entities.eUser> GetDummyUsers()
        {
            return lst_users;
        }

        public void GenerateTXT_DummyUsers()
        {
            string str_final_text = string.Empty;
            string str_date = Tools.DateHandler.GetDateTime_DD_MM_YYYY();
            //string str_path = Server.;

            str_final_text += "Date: " + str_date;

            //using(StreamWriter sw = new StreamWriter())
            //{

            //}
        }
        #endregion
    }
}
