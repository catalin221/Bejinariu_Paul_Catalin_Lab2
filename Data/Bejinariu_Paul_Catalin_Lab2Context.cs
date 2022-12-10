using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bejinariu_Paul_Catalin_Lab2.Models;

namespace Bejinariu_Paul_Catalin_Lab2.Data
{
    public class Bejinariu_Paul_Catalin_Lab2Context : DbContext
    {
        public Bejinariu_Paul_Catalin_Lab2Context (DbContextOptions<Bejinariu_Paul_Catalin_Lab2Context> options): base(options)
        {
        }

        public DbSet<Bejinariu_Paul_Catalin_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bejinariu_Paul_Catalin_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Bejinariu_Paul_Catalin_Lab2.Models.Category> Category { get; set; }

        public DbSet<Bejinariu_Paul_Catalin_Lab2.Models.Author> Author { get; set; }

        public DbSet<Bejinariu_Paul_Catalin_Lab2.Models.Member> Member { get; set; }

        public DbSet<Bejinariu_Paul_Catalin_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
