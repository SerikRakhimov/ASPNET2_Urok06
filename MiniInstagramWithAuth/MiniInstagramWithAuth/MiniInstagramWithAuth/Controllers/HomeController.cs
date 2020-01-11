using MiniInstagramWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniInstagramWithAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new DataContext())
            {
                ViewBag.PostList = context.Posts.ToList();
            }
            return View();
        }

        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var context = new DataContext())
            {
                Post post = context.Posts.FirstOrDefault(p => p.Id == id);
                if (post == null)
                {
                    return HttpNotFound();
                }
                return View(post);
            }
        }

        [HttpPost]
        public ActionResult Like(Post post)
        {
            Post postWork;

            using (var context = new DataContext())
            {
                postWork = context.Posts.Find(post.Id);

                if (postWork != null)
                {
                    postWork.Likes++;
                }

                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (post == null)
            {
                return HttpNotFound();
            }

            using (var context = new DataContext())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}