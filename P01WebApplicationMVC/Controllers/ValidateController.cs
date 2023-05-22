﻿using Microsoft.AspNetCore.Mvc;
using P01WebApplicationMVC.Models;

namespace P01WebApplicationMVC.Controllers
{
    public class ValidateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Member());
        }

        [HttpPost]
        public IActionResult Index(Member member)
        {
            if (!ModelState.IsValid)
            {
                return View(member);
            }
            return View(new Member());
        }
    }
}
