using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;


namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        private Context c = new Context();
        public ActionResult Index()
        {
            var vBlogs = c.Blogs.ToList();
            return View(vBlogs);
        }

        public ActionResult BlogDetail(int id) //burada  blogdetail/""xx"" olmasını sağladık
         {
            var findBlog = c.Blogs.Where(x => x.ID == id).ToList(); //blogdetail/x ile dbdeki Blog ID  mizi eşledik
            return View(findBlog);

        }
    }
}