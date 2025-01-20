﻿using Microsoft.AspNetCore.Identity;

namespace WebApi.Data.Entites
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? FullName { get; set; }

        public DateTime Dob { get; set; }

       
    }
}