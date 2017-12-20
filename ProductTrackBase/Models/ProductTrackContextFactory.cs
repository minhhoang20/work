using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ProductTrack.Models
{
    public class ProductTrackContextFactory : IDesignTimeDbContextFactory<ProductTrackContext>
    {
        public ProductTrackContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductTrackContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ProductTrackEntities"].ToString());

            return new ProductTrackContext(optionsBuilder.Options);
        }
    }
}