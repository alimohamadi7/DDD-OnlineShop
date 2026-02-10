using Framework.Domain.Entities;
using OnlineShop.Core.Domain.Parameters;


namespace OnlineShop.Core.Domain.Catalog.Categories;

public class Feature: Entity<long>
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int SortOrder { get; set; }

    public Feature(FeatureCreateParameter parameter)
    {
        //validation
        Title = parameter.Title;
        Description= parameter.Description;
        SortOrder =parameter.SortOrder ;
    }

    private Feature() { }
}

