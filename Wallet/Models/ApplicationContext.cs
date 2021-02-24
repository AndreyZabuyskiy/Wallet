using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class ApplicationContext : IdentityDbContext<Account>
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<ExpensesTransaction> ExpensesTransactions { get; set; }
        public DbSet<ProfitTransaction> ProfitTransactions { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>()
                .HasOne(a => a.UserProfile)
                .WithOne(u => u.Account)
                .HasForeignKey<UserProfile>(u => u.AccountForeignKey);
        }
    }
}
