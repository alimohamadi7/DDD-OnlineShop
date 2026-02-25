using Framework.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Domain.Catalog.Categories;
using OnlineShop.Core.Domain.Features;
using OnlineShop.Core.Domain.Products;
using OnlineShop.Infrastracture.sql.ValueConversions;


namespace OnlineShop.Infrastracture.sql
{
    public  class OnlineShopDbContext:DbContext
    {
        public OnlineShopDbContext(DbContextOptions options ):base(options)
        {
                
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<BusinessId>().HaveConversion<BusinessIdConversion>();

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product>Products { get; set; }
    }
}
