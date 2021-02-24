using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public Guid AccountId { get; set; }

        public Account Account { get; set; }
        public ICollection<Budget> Budgets { get; set; }
    }
}
