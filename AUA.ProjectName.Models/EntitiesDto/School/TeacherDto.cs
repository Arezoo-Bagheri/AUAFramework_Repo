using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseDto;

namespace AUA.ProjectName.Models.EntitiesDto.School
{
    public class TeacherDto : BaseEntityDto<long>, IMapFrom<Teacher>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }

    }
}
