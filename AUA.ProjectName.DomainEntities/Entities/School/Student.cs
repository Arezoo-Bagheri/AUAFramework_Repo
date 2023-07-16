using AUA.ProjectName.DomainEntities.BaseEntities;

namespace AUA.ProjectName.DomainEntities.Entities.School
{
    public class Student : DomainEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
