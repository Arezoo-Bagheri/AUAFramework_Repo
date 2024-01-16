namespace AUA.ProjectName.DomainEntities.Events
{
    public class CategoryRemoved : IDomainEvent 
    {
        public int Id { get; }

        public CategoryRemoved(int id )
        {
            Id = id;
        }

    }
}
