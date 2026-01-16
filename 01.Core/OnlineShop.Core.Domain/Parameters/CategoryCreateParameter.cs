using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Domain.Parameters
{
    public sealed record class CategoryCreateParameter(string categoryName, bool isActive, string desscription);
}
