using Framework.Domain.Entities;
using OnlineShop.Core.Domain.Catalog.Parameters;
using OnlineShop.Core.Domain.Features;
using OnlineShop.Core.Domain.Features.Prarmeters;


namespace OnlineShop.Core.Domain.Catalog.Categories;

public class Category:AggregateRoot<long>
{
    public string CategoryName { get; private set; }
    public bool IsActive { get; private set; }
    public string Description { get; private set; }
    public IReadOnlyList<Feature> Features => _feature.AsReadOnly();
    private readonly List<Feature> _feature = new List<Feature>();
    public Category(CategoryCreateParameter parameter, List<FeatureCreateParameter> featureParmeters)
    {
        //validation....
        CategoryName = parameter.categoryName;
        IsActive = parameter. isActive;
        Description = parameter. desscription;
    }
    private void BuildFeatures(List<FeatureCreateParameter> featureParmeters)
    {
        featureParmeters.ForEach(item =>
        {
            var newFeature = new Feature(new FeatureCreateParameter(item.Title, item.Description, item.SortOrder));
            _feature.Add(newFeature);
        });
    }
    private Category()
    {

    }
}
