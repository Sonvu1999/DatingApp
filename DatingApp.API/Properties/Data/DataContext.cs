using DatingApp.API.Properties.models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Properties.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<models.Value> Values { get; set;}        
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos  { get; set; }
    }
}