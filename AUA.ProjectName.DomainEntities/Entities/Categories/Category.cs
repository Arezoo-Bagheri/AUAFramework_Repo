using AUA.ProjectName.DomainEntities.BaseEntities;
using AUA.ProjectName.DomainEntities.Events;
using AUA.ProjectName.DomainEntities.Exceptions;
using AUA.ProjectName.DomainEntities.ValueObjects;

namespace AUA.ProjectName.DomainEntities.Entities.Categories
{
    public class Category : AggregateRoot
    {
        private HashSet<Category> _children = new HashSet<Category>();
        public Title Title { get; private set; }
        public long? ParentId { get; private set; }
        public bool Disabled { get; private set; }
        public IReadOnlyCollection<Category> Children => _children.ToList();

        private Category()
        {
        }

        public Category(int id, Title title)
        {
            Id = id;
            Title = title;
            Disabled = false;
            AddEvent(new CategoryCreated(Title.Value, Id = id));
        }

        public void AddChild(int id, Title title)
        {
            if (_children.Any(c => c.Title == title))
                throw new InvalidEntityStateException(ResourceKeyes.InvalidDuplicateValueInCollection, nameof(Children), nameof(Title));

            if (Disabled)
                throw new InvalidEntityStateException(ResourceKeyes.InvalidOperation, nameof(AddChild), ResourceKeyes.EntityIsDisable);

            var child = new Category
            {
                Title = title,
                Id = id,
                Disabled = false
            };

            _children.Add(child);
            AddEvent(new CategoryCreated(child.Title.Value, child.Id));
        }

        public void Disable()
        {
            if (!Disabled)
            {
                Disabled = true;
                AddEvent(new CategoryDisabled(Id));
            }
        }

        public void Enable()
        {
            if (Disabled)
            {
                Disabled = false;
                AddEvent(new CategoryEnabled(Id));
            }
        }

        public void Remove()
        {
            if (_children.Any())
                throw new InvalidEntityStateException(ResourceKeyes.InvalidOperation, nameof(Remove), ResourceKeyes.EntityIsDisable);

            AddEvent(new CategoryRemoved(Id));
        }

    }
}
