using Microsoft.EntityFrameworkCore;
using OrderApp2.Core.Domain.Entities;

namespace OredApp2.Infrastructure.Persistance.DBContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
    }
}