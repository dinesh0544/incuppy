using admin.model;
using Microsoft.EntityFrameworkCore;

namespace admin.context
{
    public class appdbcontext:DbContext
    {

        public appdbcontext(DbContextOptions<appdbcontext> options) : base(options)
        {

        }
        public DbSet<admins> adminss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admins>().ToTable("users");
        }
    }
}
