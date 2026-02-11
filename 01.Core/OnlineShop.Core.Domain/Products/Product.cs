using Framework.Domain.Entities;
using Framework.Domain.Exceptions;
using OnlineShop.Core.Domain.Features;
using OnlineShop.Core.Domain.Products.Prarmeters;
using OnlineShop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineShop.Core.Domain.Products;

public class Product : AggregateRoot<long>
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Code { get; private set; }
    public double Price { get; private set; }
    public IReadOnlyList<ProductFeatureValue> ProductFeatureValues => _productFeatureValues.AsReadOnly();
    private readonly List<ProductFeatureValue> _productFeatureValues = new List<ProductFeatureValue>();


    private void BuildFeatures(List<ProductFeatureValueParameter> featureData)
    {
        featureData.ForEach(feature =>
        {
            var newFeature =new ProductFeatureValue(new ProductFeatureValueParameter(feature.FeatureId,feature.ProductId,feature.Value));
            _productFeatureValues.Add(newFeature);
        });
    }

    public Product(ProductParameter productParameter)
    {
        if (productParameter.Price < 0) throw new InvalidEntityStateException(MessagePatterns.PriceValidationMessage, nameof(productParameter.Price));
        Title = productParameter.Title;
        Description = productParameter.Description;
        Code =productParameter.Code;
        Price =productParameter.Price;
        BuildFeatures(productParameter.ProductFeatures);
    }

    private Product() { }
}
