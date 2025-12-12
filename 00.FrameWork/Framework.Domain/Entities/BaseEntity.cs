using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain.Entities
{
    public abstract class BaseEntity<TId> where TId : IEquatable<TId>
    {
        public TId Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var other = obj as BaseEntity<TId>;

            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetType() != other.GetType())
                return false;

            if (Id == null || other.Id == null)
                return false;

            return Id.Equals(other.Id);
        }
    }
}
