using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DomainEntities.Entities.School;
using AutoMapper;

namespace AUA.ProjectName.Models.ListModes.School.TeacherModels
{
    public class TeacherListDto : IHaveCustomMappings
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int StudentCount { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationDatePersian => RegistrationDate.ToPersianDate();


        public void ConfigureMapping(Profile configuration)
        {
            configuration.CreateMap<Teacher, TeacherListDto>()
            .ForMember(p => p.StudentCount, p => p.MapFrom(q => q.StudentTeachers.Count));
        }

    }
}
