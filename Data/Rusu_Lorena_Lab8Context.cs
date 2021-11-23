using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rusu_Lorena_Lab8.Models;

namespace Rusu_Lorena_Lab8.Data
{
    public class Rusu_Lorena_Lab8Context : DbContext
    {
        public Rusu_Lorena_Lab8Context (DbContextOptions<Rusu_Lorena_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Rusu_Lorena_Lab8.Models.Book> Book { get; set; }

        public DbSet<Rusu_Lorena_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Rusu_Lorena_Lab8.Models.Category> Category { get; set; }
    }
}
