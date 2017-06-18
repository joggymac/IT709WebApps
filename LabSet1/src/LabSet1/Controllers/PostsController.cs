using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LabSet1.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LabSet1.Controllers
{
    public class PostsController : Controller
    {
        // GET: /<controller>/
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }
            post.PostedDate = DateTime.Now;
            post.Author = User.Identity.Name;
            return View();
        }
    }
}
