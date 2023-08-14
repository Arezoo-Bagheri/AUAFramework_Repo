using AUA.ProjectName.DomainEntities.BaseEntities;

namespace AUA.ProjectName.DomainEntities.Entities.School
{

    //  [Table("StudentTeacher", Schema = SchemaConsts.School)]
    public class StudentTeacher : DomainEntity<long>
    {
        public int StudentId { get; set; }
        public long TeacherId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }


    }
}
