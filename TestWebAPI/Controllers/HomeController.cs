﻿using Microsoft.AspNetCore.Mvc;

namespace TestWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
    }
}
