using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Model;

namespace BackEnd.Model.Context
{
    public class SqlContext : DbContext
    {
        
            public SqlContext()
            {
            }
            public SqlContext(DbContextOptions<SqlContext> options) : base(options)
            {

            }
            public DbSet<BackEnd.Model.Professor> Professor { get; set; }

           // public DbSet<Disciplinas> disciplinas { get; set; }
           
        }
    
}
