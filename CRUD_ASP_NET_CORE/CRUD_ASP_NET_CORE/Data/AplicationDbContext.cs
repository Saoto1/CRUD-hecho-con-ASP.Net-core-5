
using CRUD_ASP_NET_CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP_NET_CORE.Data
{
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base (options)
        {
            


        }

        //vamos a instanciar los modelos

        public DbSet<Libro> Libro { get; set; }

    }
}
