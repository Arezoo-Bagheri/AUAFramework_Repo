namespace AUA.ProjectName.DomainEntities.Events
{
    public class CategoryCreated : IDomainEvent
    {
        public string Title { get; }
        public int Id { get; }

        public CategoryCreated(string title, int id)
        {
            Title = title;
            Id = id;
        }

    }
}
