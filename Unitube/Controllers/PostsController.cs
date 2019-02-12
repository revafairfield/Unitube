using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unitube.Models;

namespace Unitube.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts/Random
        public ActionResult Random()
        {
            var post = new Post() { Name = "Test!" };

            return View(post);
        }
    }
}