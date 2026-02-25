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
    public IReadOnlyList<CategoryFeature> CategoryFeatures => _categoryFeatures.AsReadOnly();
    private readonly List<CategoryFeature> _categoryFeatures = new List<CategoryFeature>();
    public Category(CategoryCreateParameter parameter, List<FeatureCreateParameter> featureParmeters)
    {
        //validation....
        CategoryName = parameter.categoryName;
        IsActive = parameter. isActive;
        Description = parameter. desscription;
    }
    private void BuildFeatures(List<Feature> featureParmeters)
    {
        featureParmeters.ForEach(item =>
        {
            var newFeature = new CategoryFeature(BusinessId,item.BusinessId);
            _categoryFeatures.Add(newFeature);
        });
    }
    private Category()
    {

    }
}
