using Framework.Domain.Entities;
using OnlineShop.Core.Domain.Features.Prarmeters;

namespace OnlineShop.Core.Domain.Features;

public class Feature : AggregateRoot<long>
{

    public string Title { get; private set; }
    public string Description { get; private set; }
    public int SortOrder { get; set; }

    //public static Feature CreateNewForUpdate(Guid id, string title, string description, int sortOrder)
    //{
    //    var featureId = new FeatureId(id);
    //    return new Feature(featureId, title, description, sortOrder);
    //}

    //public static Feature CreateNewForDelete(FeatureId id)
    //{
    //    return new Feature(id);
    //}

    public void Update(FeatureUpdateParameters featureUpdate)
    {
        Title = featureUpdate.Title;
        Description = featureUpdate.Description;
        SortOrder = featureUpdate.SortOrder;
    }

    public Feature(FeatureCreateParameter featureCreate)
    {
        //validation
        Title = featureCreate.Title;
        Description = featureCreate.Description;
        SortOrder = featureCreate.SortOrder;
    }
    private Feature() { }
}
}

