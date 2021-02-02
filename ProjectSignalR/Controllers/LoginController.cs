using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjectSignalR.Models.ORM.Context;
using ProjectSignalR.Models.VM;

namespace ProjectSignalR.Controllers
{
    public class LoginController : Controller
    {
        private readonly ChatContext _chatContext;


        public LoginController(ChatContext chatContext)
        {
            _chatContext = chatContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            var user = _chatContext.AdminUsers.FirstOrDefault(x => x.EMail == model.email && x.Password == model.password);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, model.email),
                    new Claim(ClaimTypes.Sid, user.ID.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName),


                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return Redirect("/Home/Index");

            }
            else
            {
                ViewBag.error = "You do not exist";
                return View();
            }

        }

    }
}
