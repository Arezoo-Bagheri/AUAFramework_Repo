using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseDto;
using AutoMapper;

namespace AUA.ProjectName.Models.EntitiesDto.School
{
    public class StudentTeacherDto : BaseEntityDto<long>, IHaveCustomMappings
    {
        public int StudentId { get; set; }
        public long TeacherId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public string TeacherName { get; set; }
        public string StudentName { get; set; }

        public void ConfigureMapping(Profile configuration)
        {
            configuration.CreateMap<StudentTeacher, StudentTeacherDto>()
                                 .ForMember(p => p.TeacherName, p => p.MapFrom(q => q.Teacher.FirstName + " " + q.Teacher.LastName))
                                 .ForMember(p => p.StudentName, p => p.MapFrom(q => q.Student.FirstName + " " + q.Student.LastName));

            configuration.CreateMap<StudentTeacherDto, StudentTeacher>();
        }
    }
}
