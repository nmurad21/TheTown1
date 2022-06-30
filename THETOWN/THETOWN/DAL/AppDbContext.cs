using Microsoft.EntityFrameworkCore;
using THETOWN.Models;

namespace THETOWN.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<TheTownBackground> theTownBackground { get; set; }
    }
}
