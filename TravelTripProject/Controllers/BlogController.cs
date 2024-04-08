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
        BlogComment bc = new BlogComment();



        public ActionResult Index()
        {
            bc.Value1 = c.Blogs.OrderByDescending(x => x.ID).ToList();
            bc.Value3 = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();



            //var vBlogs = c.Blogs.ToList();
            return View(bc);
        }




        public ActionResult BlogDetail(int id) //burada  blogdetail/""xx"" olmasını sağladık
         {
            bc.UrlValues= c.AvatarImageUrls.ToList();


            //var findBlog = c.Blogs.Where(x => x.ID == id).ToList(); //blogdetail/x ile dbdeki Blog ID  mizi eşledik
            bc.Value1 = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Value2 = c.CommentsS.Where(x => x.Blogid == id).ToList();
            return View(bc);

        }

        [HttpGet]
        public PartialViewResult Commenting(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Commenting(Comments y)
        {
            c.CommentsS.Add(y);
            c.SaveChanges();
            return PartialView();
        }

       
    }
}