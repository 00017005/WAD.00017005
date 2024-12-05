using System.Collections.Generic;
using WAD._00017005.Models;
using Microsoft.EntityFrameworkCore;

namespace WAD._00017005.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Event> Events { get; set; }
    }


}

