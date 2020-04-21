using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remember.controllers
{
    [Controller]
    public class Test:Controller
    {
        public String Index()
        {
            return "home";
        }
        public String AboutUs()
        {
            return "AboutUs";
        }

        public IActionResult Contact() {
            return View();
        }
    }
}
