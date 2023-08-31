namespace AUA.ProjectName.DomainEntities.BaseEntities
{

    public class DomainEntity<TPrimaryKey> : BaseDomainEntity<TPrimaryKey>, IAuditInfo, ICreationAudited, IDeletionAudited, IModifiedAudited
    {
        public DateTime RegistrationDate { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionDate { get; set; }
        public bool IsDeleted { get; set; }
        public long? ModifierUserId { get; set; }
        public DateTime? ModifyDate { get; set; }

    }
}