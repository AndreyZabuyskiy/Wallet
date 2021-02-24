using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class ExpensesTransaction
    {
        public Guid Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransactionData { get; set; }
        public Guid BudgetId { get; set; }
        public Guid ExpenseCategoryId { get; set; }

        public Budget Budget { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
    }
}
