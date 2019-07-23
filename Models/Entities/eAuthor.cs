using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Models.Entities
{
    public class eAuthor: ePerson
    {
        #region PROPERTIES
        public int Age { get; set; }

        #endregion

        #region CONSTRUCTORS
        public eAuthor()
        {
            Name = string.Empty;
            LastName = string.Empty;
        }
        public eAuthor(int pID, string pName, string pLastName, int pAge)
        {
            ID = pID;
            Name = pName;
            LastName = pLastName;
            Age = pAge;
        }

        public List<eBlog> GetBlogsList()
        {
            Dummy.dBLog blog = new Dummy.dBLog();

            return blog.GetBlogsByAuthorID(ID);
        }
        #endregion

    }
}
