using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using estudo.Models;

namespace BancoProjTest.Context
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto>options) : base(options)
        {

        }

        public DbSet<Conta> Users { get;}
    }
}