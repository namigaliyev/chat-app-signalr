﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chat_application.Identity;
using chat_application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace chat_application.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppIdentityUser> userManager;
        private readonly SignInManager<AppIdentityUser> signInManager;

        private readonly ChatDbContext chatDbContext;
        private readonly IHttpContextAccessor context;

        public AuthController(UserManager<AppIdentityUser> userManager, SignInManager<AppIdentityUser> signInManager,
                              IHttpContextAccessor context, ChatDbContext chatDbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
            this.chatDbContext = chatDbContext;
        }

        [Route("administrator/register")]
        public IActionResult Register()
        {
            var model = new RegisterRequest
            {

            };
            return View(model);
        }

        [HttpPost]
        [Route("administrator/register")]
        public async Task<IActionResult> Register(RegisterRequest model)
        {
            var user = new AppIdentityUser
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var validateItem in result.Errors)
                    ModelState.AddModelError("", validateItem.Description);

                return View(model);
            }

            return Redirect("~/administrator/login");
        }




        [Route("administrator/login")]
        public IActionResult Login()
        {
            var model = new LoginRequest
            {

            };
            return View(model);
        }

        [HttpPost]
        [Route("administrator/login")]
        public async Task<IActionResult> Login(LoginRequest model)
        {
            
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, true);
            if (result.Succeeded)
            {
                return Redirect("~/administrator/dashboard/everyone/All");
            }

            return View(model);
        }

        [Route("administrator/log-out")]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return Redirect("~/administrator/login");
        }

        [Route("administrator/access-denied")]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        [Route("administrator/create-group")]
        public async Task<IActionResult> CreateGroup(string GroupName)
        {
            await chatDbContext.Groups.AddAsync(new Group {Name = GroupName});
            await chatDbContext.SaveChangesAsync();
            return new RedirectToActionResult("Dashboard", "Administrator", new {type ="everyone", receiverName = "All"});
        }

    }
}