using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NET_Core_Introduction.Models;

namespace NET_Core_Introduction.Controllers
{
    public class HomeController : Controller
    {
        #region PROPERTIES
        private Models.Dummy.dAuthor _mAuthor;
        public Models.Dummy.dAuthor mAuthor
        {
            get
            {
                if (_mAuthor == null)
                    _mAuthor = new Models.Dummy.dAuthor();

                return _mAuthor;
            }
        }
        #endregion

        #region ACTIONS

        public IActionResult Index()
        {
            ConfigureAuthors(null);

            return View();
        }

        public IActionResult AuthorDetail()
        {
            string author_id = Request.Form["ddlAuthors"].ToString();
            int id = Int32.Parse(author_id);

            ConfigureAuthors(id);

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion

        #region FUNCTIONS
        private void ConfigureAuthors(int? pID)
        {
            List<Models.Entities.eAuthor> lst_authors = mAuthor.GetDummyAuthors();
            SelectList selectList_authors = new SelectList(lst_authors, "ID", "CompleteName");

            //use this to simulate a View overload
            //in the first request, pID will not have any value
            int id = pID.HasValue ? (Int32)pID : 1;

            //force to select the author which is selected by user
            //if we don't do that, when the view html is render, its display the first author and
            //not the one selected before
            selectList_authors.First(x => x.Value == id.ToString()).Selected = true;
            ViewBag.lst_authors = selectList_authors;

            Models.Entities.eAuthor author = mAuthor.GetAuthorByID(id);
            ViewBag.Author = author;
            ViewBag.Blogs = author.GetBlogsList();
        }
        #endregion
    }
}
