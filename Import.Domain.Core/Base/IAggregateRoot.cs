using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.Base
{
    public interface IAggregateRoot
    {
        IReadOnlyCollection<IDomainEvevt> DomainEvent { get; }
        void ClearDomainEvent();
    }
}
