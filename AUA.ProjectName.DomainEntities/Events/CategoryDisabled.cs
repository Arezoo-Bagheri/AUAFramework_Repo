namespace AUA.ProjectName.DomainEntities.Events
{
    public class CategoryDisabled : IDomainEvent
    {
        public int Id { get; }

        public CategoryDisabled(int id)
        {
            Id = id;
        }

    }
}
