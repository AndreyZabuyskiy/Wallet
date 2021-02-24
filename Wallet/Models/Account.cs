using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class Account : IdentityUser
    {
        public UserProfile UserProfile { get; set; }
    }
}
