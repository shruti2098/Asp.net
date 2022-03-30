using EntityRelations.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations.Data
{
    public class ProductDbContext :DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<ModelInfo> ModelInfo { get; set; }
        public DbSet<ProductDescription> ProductDes { get; set; }
    }
}
