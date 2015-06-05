using MuhsinBlog.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhsinBlog.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        // GET: Article/Details/5
        public ActionResult Index(int? page)
        {
            int pageSize = 2;
            int pageNumber = (page ?? 1);
            IPagedList<Article> list = db.Article.SqlQuery("select * from Articles;").OrderBy(art => art.Date).ToPagedList(pageNumber, pageSize);
            if (list == null)
            {
                return HttpNotFound();
            }
            return View(list);
        }

        public ActionResult About()
        {
            return View();
        }

    }
}