using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseDto;

namespace AUA.ProjectName.Models.EntitiesDto.School
{
    public class StudentDto : BaseEntityDto, IMapFrom<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FullName => FirstName + " " + LastName;

        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }

    }
}
