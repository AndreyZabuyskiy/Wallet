using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        public Guid AccountId { get; set; }
        public string AccountForeignKey { get; set; }

        public Account Account { get; set; }
        public ICollection<Budget> Budgets { get; set; }
    }
}
