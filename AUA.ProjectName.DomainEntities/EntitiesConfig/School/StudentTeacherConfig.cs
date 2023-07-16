using AUA.ProjectName.DomainEntities.Entities.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.School
{
    public class StudentTeacherConfig : IEntityTypeConfiguration<StudentTeacher>
    {
        public void Configure(EntityTypeBuilder<StudentTeacher> builder)
        {

            builder
                   .HasOne(p => p.Teacher)
                   .WithMany(p => p.StudentTeachers)
                   .HasForeignKey(p => p.TeacherId);


            builder
                   .HasOne(p => p.Student)
                   .WithMany(p => p.StudentTeachers)
                   .HasForeignKey(p => p.StudentId);

            builder
           .Property(p => p.IsActive)
           .IsRequired();
        }
    }
}
