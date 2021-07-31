using Microsoft.EntityFrameworkCore;
using OrderCafe.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCafe.DAL
{
    public class ApplicationDBcontex:DbContext
    {
        public ApplicationDBcontex(DbContextOptions<ApplicationDBcontex> options) : base(options) { }

        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
