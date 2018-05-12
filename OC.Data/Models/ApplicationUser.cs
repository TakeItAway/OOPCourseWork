using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsBlocked { get; set; }
    }
}
