using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class Budget
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Guid UserId { get; set; }
        public Guid CurrencyId { get; set; }

        public UserProfile UserProfile { get; set; }
        public Currency Currency { get; set; }
        public ICollection<ExpensesTransaction> ExpensesTransactions { get; set; }
        public ICollection<ProfitTransaction> ProfitTransactions { get; set; }
    }
}
