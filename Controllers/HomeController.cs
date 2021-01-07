using Final_Project_Group20_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginIndex()
        {
            return View();
        }
        //public ActionResult SearchResults(String SearchString, PositionType SelectedPosition,   )

        public IActionResult LoginIntermeidate()
        {
            return View();
        }
    }

}

