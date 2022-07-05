using BankCardDetails.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardDetails.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BankCard> BankCards { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
