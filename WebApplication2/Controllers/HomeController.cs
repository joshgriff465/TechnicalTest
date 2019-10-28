using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var root = AppDomain.CurrentDomain.BaseDirectory;
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(root + @"/Text.txt");
            var fileLines = new List<string>();
            while ((line = file.ReadLine()) != null || (counter != 12))
            {
                counter++;
                fileLines.Add(line);
            }
            string[] Bullet1 = fileLines[0].Split('.');
            string[] Bullet2 = fileLines[2].Split('.');
            // You can use model, temdata or viewbag to carry your data to view.
            ViewBag.Bullet = Bullet1;
            ViewBag.Bullet2 = Bullet2;
            ViewBag.File = fileLines;
            file.Dispose();
            return View();
        }
        public IActionResult Section2()
        {
            var root = AppDomain.CurrentDomain.BaseDirectory;
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(root + @"/Text.txt");
            var fileLines = new List<string>();
            while ((line = file.ReadLine()) != null || (counter != 12))
            {
                counter++;
                fileLines.Add(line);
            }
            string[] Bullet1 = fileLines[0].Split('.');
            string[] Bullet2 = fileLines[2].Split('.');
            // You can use model, temdata or viewbag to carry your data to view.
            ViewBag.Bullet = Bullet1;
            ViewBag.Bullet2 = Bullet2;
            ViewBag.File = fileLines;
            file.Dispose();
            return View();
        }
        public IActionResult Section3()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
