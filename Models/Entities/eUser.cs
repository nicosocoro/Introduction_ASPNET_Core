using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Models.Entities
{
    /// <summary>
    /// Dummy class in order to access by Login
    /// </summary>
    public class eUser: ePerson
    {
        #region PROPERTIESs
        public string UserName { get; set; }
        public string Password { get; set; }
        #endregion

        #region CONSTRUCTORS
        public eUser(int pID)
        {
            ID = pID;

            Name = string.Empty;
            LastName = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
        }

        public eUser(int pID, string pUserName, string pPassword)
        {
            ID = pID;
            UserName = pUserName;
            Password = pPassword;
        }

        public eUser(int pID, string pName, string pLastName, string pUserName, string pPassword)
            :this(pID, pUserName, pPassword)
        {
            Name = pName;
            LastName = pLastName;
        }
        #endregion
    }
}
