using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Shop1.Data.Models
{
    public class User : IdentityUser
    {
        public string Country { get; set; }
    }
}
