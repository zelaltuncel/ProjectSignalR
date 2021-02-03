using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSignalR.Models.ORM.Context;
using ProjectSignalR.Models.ORM.Entities;

namespace ProjectSignalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ChatContext _chatContext;

        public HomeController(ChatContext chatContext) 
        {
            _chatContext = chatContext;
        }


        public IActionResult Index()
        {
            ViewBag.username = HttpContext.User.Claims.ToArray()[2].Value;
            ViewBag.loginID = HttpContext.User.Claims.ToArray()[1].Value;



            List<AdminUser> users = _chatContext.AdminUsers.ToList();

            return View(users);
        }


    }
}
