using NET_Core_Introduction.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Models.Dummy
{
    public class dAuthor
    {
        #region FUNCTIONS
        /// <summary>
        /// Return a hardcoded list of Users for signing up.
        /// </summary>
        List<eAuthor> lst_authors
        {
            get
            {
                dBLog blog = new dBLog();

                return new List<eAuthor>
                {
                    new eAuthor(1, "Nicolás", "Socoró", 23),
                    new eAuthor(2, "Docker", "Lover", 48),
                    new eAuthor(3, "Microsoft", "Researcher", 36)
                    //new eAuthor(1, "Nicolás", "Socoró", blog.GetBlogsByAuthorID(1)),
                    //new eAuthor(2, "Docker", "Lover", blog.GetBlogsByAuthorID(2)),
                    //new eAuthor(3, "Microsoft", "Researcher", blog.GetBlogsByAuthorID(3))
                };
            }
        }


        /// <summary>
        /// Return a list of Dummy Users.
        /// </summary>
        /// <returns></returns>
        public List<eAuthor> GetDummyAuthors()
        {
            return lst_authors;
        }

        public eAuthor GetAuthorByID(int pID)
        {
            try
            {
                eAuthor author = lst_authors.First(x => x.ID == pID);
                return author;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
