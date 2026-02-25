using Framework.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace OnlineShop.Infrastracture.sql.ValueConversions;


    public class BusinessIdConversion : ValueConverter<BusinessId, Guid>
    {
        public BusinessIdConversion() : base(c => c.Value, c => BusinessId.FromGuid(c))
        {

        }
    }
