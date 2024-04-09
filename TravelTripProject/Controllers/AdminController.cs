using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {

            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            
            return View("GetBlog",blog);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var blog = c.Blogs.Find(b.ID);
            blog.Description=b.Description;
            blog.Title=b.Title;
            blog.BlogImage=b.BlogImage;
            blog.Date=b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var comments = c.CommentsS.ToList();
            return View(comments);
        }
        public ActionResult DeleteComment(int id)
        {
            var comment = c.CommentsS.Find(id);
            c.CommentsS.Remove(comment);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}