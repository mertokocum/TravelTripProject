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
        BlogComment bc=new BlogComment();
        public ActionResult BlogDetail(int id) //burada  blogdetail/""xx"" olmasını sağladık
         {
            bc.UrlValues= c.AvatarImageUrls.Where(x => x.ID == id).ToList();


            //var findBlog = c.Blogs.Where(x => x.ID == id).ToList(); //blogdetail/x ile dbdeki Blog ID  mizi eşledik
            bc.Value1 = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Value2 = c.CommentsS.Where(x => x.Blogid == id).ToList();
            return View(bc);

        }
    }
}