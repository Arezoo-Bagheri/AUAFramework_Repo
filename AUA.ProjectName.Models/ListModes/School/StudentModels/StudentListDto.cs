using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DomainEntities.Entities.School;
using AutoMapper;

namespace AUA.ProjectName.Models.ListModes.School.StudentModels
{
    public class StudentListDto : IHaveCustomMappings
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int TeacherCount { get; set; }
        public IEnumerable<string> TeacherNames { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationDatePersian => RegistrationDate.ToPersianDate();


        public void ConfigureMapping(Profile configuration)
        {
            configuration.CreateMap<Student, StudentListDto>()
                       .ForMember(p => p.TeacherCount, p => p.MapFrom(q => q.StudentTeachers.Count))
                       .ForMember(p => p.TeacherNames, p => p.MapFrom(q =>
                       q.StudentTeachers.Select(t => t.Teacher.FirstName + " " + t.Teacher.LastName)));
        }


    }
}
