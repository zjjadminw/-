using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_12_13.Models
{
    public class DBData : DbContext
    {
        public DBData(DbContextOptions<DBData> options):base(options)
        {

        }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
