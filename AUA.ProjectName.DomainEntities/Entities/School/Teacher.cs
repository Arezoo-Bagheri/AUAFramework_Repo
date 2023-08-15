using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUA.ProjectName.DomainEntities.Entities.School
{

    [Table("Teacher", Schema = SchemaConsts.School)]
    public class Teacher : DomainEntity<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }


    }
}
