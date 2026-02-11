using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Domain.Products.Prarmeters
{
    public sealed record class ProductParameter(string Title, string Description, string Code, double Price, List<ProductFeatureValueParameter> ProductFeatures);

}
