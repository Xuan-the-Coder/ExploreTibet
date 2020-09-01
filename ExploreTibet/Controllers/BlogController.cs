using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreTibet.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Blog posts." };
        }
    }
}
