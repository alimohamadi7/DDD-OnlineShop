using Framework.Domain.Entities;
using Framework.Domain.ValueObjects;


namespace OnlineShop.Core.Domain.Catalog.Categories;

public class CategoryFeature: Entity<long>
{
    public BusinessId CategoryId { get; private set; }
    public BusinessId FeatureId { get; private set; }



    public CategoryFeature(BusinessId categoryId, BusinessId featureId)
    {
        CategoryId = categoryId;
        FeatureId = featureId;
    }

    private CategoryFeature()
    {

    }
}
