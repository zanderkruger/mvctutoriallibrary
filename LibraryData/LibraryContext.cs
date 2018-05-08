using System;
using Microsoft.EntityFrameworkCore;

namespace LibraryData
{
    public class LibraryContext
    {
        public LibraryContext(DbContextOptions options) : base(options) {}

        public DbSet<Patron> Patrons {get; set}

    }
}
