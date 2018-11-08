using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarStore.Models;
using Microsoft.AspNetCore.Identity;

namespace CarStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Responds on Get Account/Register

        public IActionResult Register()
        {
            return View();
        }


        //Responds on POST Account/Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //todo create an account and log user in
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}