﻿using System;
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
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        [Authorize]
        public ActionResult NewBlog()
        {

            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult DeleteBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GetBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            
            return View("GetBlog",blog);
        }
        [Authorize]
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
        [Authorize]
        public ActionResult CommentList()
        {
            var comments = c.CommentsS.ToList();
            return View(comments);
        }
        [Authorize]
        public ActionResult DeleteComment(int id)
        {
            var comment = c.CommentsS.Find(id);
            c.CommentsS.Remove(comment);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        [Authorize]
        public ActionResult GetComment(int id)
        {
            var cm = c.CommentsS.Find(id);
            return View("GetComment", cm);
        }
        [Authorize]
        public ActionResult UpdateComment(Comments y)
        {
            var comment = c.CommentsS.Find(y.ID);
            comment.Username = y.Username;
            comment.Mail = y.Mail;
            comment.Comment = y.Comment;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}