using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [PersonalData]
        [MaxLength(120)]
        [Required]
        public string FirstName { get; set; }
    
        [MaxLength(120)]
        public string LastName { get; set; }

      
        public string Avatar { get; set; }
        //public int Age { get; set; }
        [MaxLength(40)]
        public string Sex { get; set; }







    }
}
