using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.School
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(LengthConsts.MaxStringLen50);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(LengthConsts.MaxStringLen50);

            builder
           .Property(p => p.IsActive)
           .IsRequired();

            builder
              .HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
