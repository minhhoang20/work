using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductTrack.Models
{
    public class ProductTrackContext : DbContext
    {
        public ProductTrackContext(DbContextOptions<ProductTrackContext> options) : base(options)
        { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<WorkEntry> WorkEntries { get; set; }
    }
}