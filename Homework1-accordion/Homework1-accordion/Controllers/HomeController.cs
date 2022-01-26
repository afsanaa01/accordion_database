using Homework1_accordion.DAL;
using Homework1_accordion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1_accordion.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;

        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            List<faq> accors = db.Faqs.ToList();
            return View(accors);
        }
    }
}
