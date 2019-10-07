using System;
using System.Collections.Generic;
using System.Text;
using BlazorApp.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Data.Service
{
    public class UserService
    {
        MyDbContext context;
        UserManager<ApplicationUser> userManager;
        RoleManager<ApplicationRole> roleManager;
       
        public UserService(MyDbContext Context , UserManager<ApplicationUser> UserManager,
        RoleManager<ApplicationRole> RoleManager)
        {
            context = Context;
            userManager = UserManager;
            roleManager = RoleManager;
        }

        public void Login(string Email, string FirstName="", string LastName = "")
        {
            var user = new ApplicationUser()
            {
                UserName = Email,
                Email = Email,
                FirstName = FirstName,
                LastName = LastName
            };

            
        }

    }
}
