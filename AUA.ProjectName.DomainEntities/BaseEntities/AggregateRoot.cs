using AUA.ProjectName.DomainEntities.Events;

namespace AUA.ProjectName.DomainEntities.BaseEntities
{
    public class AggregateRoot : DomainEntity
    {
        private readonly List<IDomainEvent> _events;
        protected AggregateRoot() => _events = new List<IDomainEvent>();
        public AggregateRoot(IEnumerable<IDomainEvent> events)
        {
            if (events == null) return;
            foreach (var @event in events)
                ((dynamic)this).On((dynamic)@event);
        }
        protected void AddEvent(IDomainEvent @event) => _events.Add(@event);
        public IEnumerable<IDomainEvent> GetEvents() => _events.AsEnumerable();
        public void ClearEvents() => _events.Clear();

    }
}
