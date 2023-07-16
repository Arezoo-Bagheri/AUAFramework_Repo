using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AutoMapper;

namespace AUA.ProjectName.Models.ViewModels.School
{
    public class StudentVm : BaseVm, IHaveCustomMappings
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int StudentTeacherCount { get; set; }
        public IEnumerable<string> TeacherNames { get; set; }
        public IEnumerable<TeacherComboVm> TeacherComboVms { get; set; }

        public void ConfigureMapping(Profile configuration)
        {
            configuration.CreateMap<Student, StudentVm>()
                .ForMember(p => p.StudentTeacherCount, p => p.MapFrom(q => q.StudentTeachers.Count))
                .ForMember(p => p.TeacherComboVms, p => p.MapFrom(q => q.StudentTeachers.Select(t => t.Teacher)))
                .ForMember(p => p.TeacherNames, p => p.MapFrom(q => q.StudentTeachers.Select(t => t.Teacher.FirstName + " " + t.Teacher.LastName)));

        }
    }
}
