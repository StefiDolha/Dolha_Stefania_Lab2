using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dolha_Stefania_Lab2.Models;

namespace Dolha_Stefania_Lab2.Data
{
    public class Dolha_Stefania_Lab2Context : DbContext
    {
        public Dolha_Stefania_Lab2Context (DbContextOptions<Dolha_Stefania_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dolha_Stefania_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Dolha_Stefania_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
