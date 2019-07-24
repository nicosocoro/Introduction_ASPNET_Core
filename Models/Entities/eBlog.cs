using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Models.Entities
{
    public class eBlog
    {
        #region PROPERTIES
        private string _PublicationDate;

        public int ID { get; set; }
        public string Title { get; set; }
        public string PublicationDate
        {
            get
            {
                return Tools.DateHandler.TransformYYYYDDMM_to_MM_DD_YYYY(_PublicationDate);
            }

            set
            {
                _PublicationDate = value;
            }
        }
        public string Link { get; set; }
        public List<string> Tags { get; set; }
        public eAuthor Author { get; set; }
        #endregion

        #region CONSTRUCTORS
        public eBlog()
        {
            Author = new eAuthor();
        }

        public eBlog(int pID, string pTitle, string pPublicationDate, string pLink, List<string> pTags)
            : this() //initialize the Author
        {
            ID = pID;
            Title = pTitle;
            PublicationDate = pPublicationDate;
            Link = pLink;
            Tags = pTags;
        }

        public eBlog(int pID, string pTitle, string pPublicationDate, string pLink, List<string> pTags, eAuthor pAuthor)
        {
            ID = pID;
            Title = pTitle;
            PublicationDate = pPublicationDate;
            Link = pLink;
            Tags = pTags;
            Author = pAuthor;
        }
        #endregion
    }
}
