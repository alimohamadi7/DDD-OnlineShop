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
            builder.Property(c => c.BusinessId).IsRequired();
            builder.HasIndex(c => c.BusinessId).IsUnique();
            builder.HasKey(x => x.Id);
            builder.Property(e => e.CategoryName)
            .HasMaxLength(128).IsRequired();
             
            builder.Property(e => e.Description).HasMaxLength(1024);
            builder.OwnsMany(c => c.CategoryFeatures, cf =>
            {
                cf.WithOwner().HasForeignKey("CategoryId");  // FK به Category
                cf.Property(x => x.FeatureId);               // ستون FeatureId
                cf.HasKey("CategoryId", "FeatureId");       // PK ترکیبی
                cf.ToTable("CategoryFeatures", "Catalog"); // نام جدول
            });
        }
    }
}
