using Microsoft.EntityFrameworkCore;
using ClientAPI.Models;


namespace ClientAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}