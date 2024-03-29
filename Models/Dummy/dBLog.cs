﻿using NET_Core_Introduction.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Models.Dummy
{
    public class dBLog
    {
        #region PROPERTIES
        List<eBlog> lst_blogs
        {
            get
            {
                dAuthor author = new dAuthor();

                eAuthor auth1 = author.GetAuthorByID(1);
                eAuthor auth2 = author.GetAuthorByID(2);
                eAuthor auth3 = author.GetAuthorByID(3);

                return new List<eBlog>
                {
                    new eBlog(1, "How to make your first ASP NET Core Application", "20192307", "https://medium.com/@nicolassocoro/asp-net-core-working-with-docker-de90a6bf67e4", new List<string>{ "microsoft", "asp", "net" }, auth1),
                    new eBlog(2, "Little introduction example of ASP NET Core web site.", "20192307", "https://github.com/nicosocoro/Introduction_ASPNET_Core", new List<string>{ "mvc", "asp", "core", "net", "github" }, auth1),
                    new eBlog(3, "Introduction to Docker containers", "20180305", "https://www.docker.com/resources/what-container", new List<string>{ "docker", "container"}, auth2),
                    new eBlog(4, "Why choose Docker?",  "20170107", "https://www.docker.com/why-docker", new List<string>{ "easy", "docker", "lightweight" }, auth2),
                    new eBlog(5, "What's Entity Framework?", "20150205", "https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/overview", new List<string>{ "entity", "orm", "queries" }, auth3),
                    new eBlog(6, "Discover ASP NET Core",  "20160813", "https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.2", new List<string>{ "microsoft", "asp", "net", "core" }, auth3),
                    new eBlog(7, "Open source blog", "20170130", "https://cloudblogs.microsoft.com/opensource/", new List<string>{ "cloud", "community", "opensource" }, auth3),
                    new eBlog(8, "Contributing to the Open Source community", "20160910", "https://github.com/microsoft",new List<string>{ "repository", "code", "opensource", "github" }, auth3)
                };
            }

        }
        #endregion

        #region FUNCTIONS
        public List<eBlog> GetBlogs()
        {
            return lst_blogs;
        }

        public List<eBlog> GetBlogsByAuthorID(int pID)
        {
            List<eBlog> lst = lst_blogs.FindAll(x => x.Author.ID == pID);
            return lst;
        }
        #endregion
    }
}
