namespace AUA.ProjectName.DomainEntities.Events
{
    public class CategoryEnabled : IDomainEvent
    {
        public int Id { get; }

        public CategoryEnabled(int id)
        {
            Id = id;
        }

    }
}
