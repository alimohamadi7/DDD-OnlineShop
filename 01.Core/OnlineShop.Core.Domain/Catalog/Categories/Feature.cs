using Framework.Domain.Entities;
using OnlineShop.Core.Domain.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
