using Framework.Domain.Entities;
using Framework.Domain.Exceptions;
using OnlineShop.Core.Domain.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineShop.Core.Domain.Products.Product;

namespace OnlineShop.Core.Domain.Products;

public class Product
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Code { get; private set; }
    public double Price { get; private set; }
    //private readonly List<ProductFeatureValue> _productFeatureValues = new List<ProductFeatureValue>();
    //public IReadOnlyList<ProductFeatureValue> ProductFeatureValues => _productFeatureValues;
    public class Product : AggregateRoot<ProductId>
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Code { get; private set; }
        public double Price { get; private set; }
        private readonly List<ProductFeatureValue> _productFeatureValues = new List<ProductFeatureValue>();
        public IReadOnlyList<ProductFeatureValue> ProductFeatureValues => _productFeatureValues;

        internal static Product CreateNew(string title, string description, string code, double price, List<ProductFeatureValueData> productFeatures)
        {
            return new Product(title, description, code, price, productFeatures);
        }

        private void BuildFeatures(List<ProductFeatureValueData> featureData)
        {
            featureData.ForEach(feature =>
            {
                var newFeature = ProductFeatureValue.CreateNew(Id, feature.FeatureId, feature.Value);
                _productFeatureValues.Add(newFeature);
            });
        }

        private Product(string title, string description, string code, double price, List<ProductFeatureValueData> productFeatures)
        {
            if (price < 0) throw new DomainStateException("invalid price value",nameof(price));
            Title = title;
            Code = code;
            Description = description;
            Price = price;
            BuildFeatures(productFeatures);
        }

        private Product() { }
    }
