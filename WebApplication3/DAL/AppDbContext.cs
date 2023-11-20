using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Image> Images { get; set; }

    }
}
