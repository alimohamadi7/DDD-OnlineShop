using Framework.Domain.Entities;
using Framework.Domain.ValueObjects;
using OnlineShop.Core.Domain.Features;
using OnlineShop.Core.Domain.Products.Prarmeters;


namespace OnlineShop.Core.Domain.Products;

public class ProductFeatureValue: Entity<long>
{
    public BusinessId ProductId { get; private set; }
    public BusinessId FeatureId { get; private set; }
    public string Value { get; private set; }

    public ProductFeatureValue(ProductFeatureValueParameter productFeatureValue)
    {
        ProductId = productFeatureValue. ProductId;
        FeatureId = productFeatureValue.FeatureId;
        Value = productFeatureValue.Value;
    }

    private ProductFeatureValue()
    {

    }
}
