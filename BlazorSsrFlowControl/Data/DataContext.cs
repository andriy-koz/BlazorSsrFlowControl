using BlazorSsrFlowControl.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSsrFlowControl.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
