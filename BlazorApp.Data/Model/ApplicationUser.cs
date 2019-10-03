using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [PersonalData]
        [MaxLength(120)]
        public string FirstName { get; set; }
    
        [MaxLength(120)]
        public string LastName { get; set; }

        [MaxLength(40)]
        public string Avatar { get; set; }

     
             


       

    }
}
