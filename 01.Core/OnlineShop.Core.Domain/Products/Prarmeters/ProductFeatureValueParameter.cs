using Framework.Domain.ValueObjects;


namespace OnlineShop.Core.Domain.Products.Prarmeters;

public sealed record class ProductFeatureValueParameter
{
    public BusinessId FeatureId { get; init; }
    public BusinessId ProductId { get; init; }
    public string Value { get; init; }

    public ProductFeatureValueParameter(BusinessId featureId, BusinessId productId,string value)
    {
        Value = value;
        FeatureId = featureId;
        ProductId= productId;
    }
}