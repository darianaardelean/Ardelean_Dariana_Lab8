using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Dariana_Lab8.Models;

namespace Ardelean_Dariana_Lab8.Data
{
    public class Ardelean_Dariana_Lab8Context : DbContext
    {
        public Ardelean_Dariana_Lab8Context (DbContextOptions<Ardelean_Dariana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ardelean_Dariana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ardelean_Dariana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ardelean_Dariana_Lab8.Models.Category> Category { get; set; }
    }
}
