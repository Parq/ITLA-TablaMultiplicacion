using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablaMultiplicacion.Models;

namespace TablaMultiplicacion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("FormSelectTabla");
        }

        [HttpPost]
        public IActionResult FormSelectTabla(int num)
        {
            Tabla(num);
            return View("TablaMultiplicacion");
        }

        public IActionResult FormSelectTabla()
        {
            return View("FormSelectTabla");
        }
        public void Tabla(int num)
        {
            List<string> tablamulti = new List<string>();
            for (int i = 1; i <=12; i++)
            {
                tablamulti.Add(num + " x " + i + " = " + (num * i));
            }
            ViewBag.TablaMulti = tablamulti;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
