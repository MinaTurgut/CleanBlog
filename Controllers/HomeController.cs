using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CleanBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanBlog.Controllers
{
    [Route("")]
    public class HomeController : Controller
    { 
        private readonly HomeContext _context;
    public HomeController(HomeContext context)
    {
        _context = context;
    }
    
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/SamplePost")]
        public IActionResult SamplePost()
        {
            return View();
        }

        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        
    }
}
