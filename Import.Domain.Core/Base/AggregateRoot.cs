using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.Base
{
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    {
        public IReadOnlyCollection<IDomainEvevt> DomainEvent => _domainEvent?.AsReadOnly();

        protected void AddDomainEvent(IDomainEvevt domainEvent)
        {
            _domainEvent = _domainEvent ?? new List<IDomainEvevt>();
            _domainEvent.Add(domainEvent);
        }

        public void ClearDomainEvent()
        {
            _domainEvent?.Clear();
        }

        private List<IDomainEvevt> _domainEvent;
    }
}
