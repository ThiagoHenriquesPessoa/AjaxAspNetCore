using AjaxAspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxAspNetCore.Data
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext( DbContextOptions<TransactionDbContext> options) : base(options)
        {
        }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
