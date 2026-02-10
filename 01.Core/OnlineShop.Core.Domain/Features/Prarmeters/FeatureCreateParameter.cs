using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Domain.Features.Prarmeters
{
public  sealed record class FeatureCreateParameter(string Title, string Description ,int SortOrder);
}
