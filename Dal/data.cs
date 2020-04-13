using Microsoft.EntityFrameworkCore;
using Models;

namespace Dal
{
    public class data: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=YunDongMan;uid=sa;pwd=11;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
