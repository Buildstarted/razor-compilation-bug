using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication8
{
    public class Home : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View("/Index.cshtml");
        }
    }
}
