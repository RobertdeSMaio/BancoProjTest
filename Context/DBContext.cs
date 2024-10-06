using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCORE;

namespace BancoProjTest.Context
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto>options) : base(options)
        {

        }

        public DbSet<User> Users { get;}
    }
}