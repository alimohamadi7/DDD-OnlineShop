using Framework.Domain.ValueObjects;


namespace OnlineShop.Core.Domain.Products.Prarmeters;

public record class ProductFeatureValueData
{
    public BusinessId FeatureId { get; init; }
    public string Value { get; init; }

    public ProductFeatureValueData(BusinessId featureId, string value)
    {
        Value = value;
        FeatureId = featureId;
    }
}