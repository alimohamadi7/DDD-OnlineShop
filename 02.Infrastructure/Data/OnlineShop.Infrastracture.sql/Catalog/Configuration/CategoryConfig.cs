using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Domain.Catalog.Categories;

namespace OnlineShop.Infrastracture.sql.Catalog.Configuration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "Catalog");

            builder.HasKey(x => x.Id);
            builder.Property(e => e.CategoryName)
            .HasMaxLength(128).IsRequired();

            builder.Property(e => e.Description).HasMaxLength(1024);

            builder.HasMany(c => c.CategoryFeatures)
                 .WithOne()              // CategoryFeature فقط FK به Category دارد
                 .HasForeignKey(cf => cf.CategoryId)
                 .OnDelete(DeleteBehavior.Cascade);

            builder.OwnsMany(c => c.CategoryFeatures, cf =>
            {
                cf.ToTable("CategoryFeatures", "Catalog");

                // PK ترکیبی: CategoryId + FeatureId
                cf.HasKey(x => new { x.CategoryId, x.FeatureId });
            });

        });
        }
    }
}
