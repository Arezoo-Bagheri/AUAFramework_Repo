using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.School.StudentModels;
using AUA.ProjectName.Services.ListService.School.Contracts;
using AUA.ServiceInfrastructure.BaseSearchService;
using AutoMapper;

namespace AUA.ProjectName.Services.ListService.School.Services
{
    public class StudentListService : BaseListService<Student, StudentListDto, StudentSearchVm>, IStudentListService
    {
        public StudentListService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {
        }

        public async Task<ListResultVm<StudentListDto>> ListAsync(StudentSearchVm studentSearchVm)
        {
            SetSearchVm(studentSearchVm);


            ApplyFirstNameFilter();
            ApplyLastNameFilter();
            ApplyAgeFilter();
            ApplyTeacherNameFilter();
            ApplyTeacherIdFilter();


            return await CreateListVmResultAsync();
        }

        private void ApplyFirstNameFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.FirstName))
                return;

            Query = Query.Where(p => p.FirstName.Contains(SearchVm.FirstName));
        }

        private void ApplyLastNameFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.LastName))
                return;

            Query = Query.Where(p => p.LastName.Contains(SearchVm.LastName));
        }

        private void ApplyAgeFilter()
        {
            if (!SearchVm.Age.HasValue || SearchVm.Age <= 0)
                return;

            Query = Query.Where(p => p.Age == SearchVm.Age);
        }

        private void ApplyTeacherNameFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.TeacherName))
                return;

            Query = Query.Where(p => p.StudentTeachers.Any(q => q.Teacher.FirstName.Contains(SearchVm.TeacherName) ||
                                                                                                  q.Teacher.LastName.Contains(SearchVm.TeacherName)));
        }

        private void ApplyTeacherIdFilter()
        {
            if (!SearchVm.TeacherId.HasValue || SearchVm.TeacherId <= 0)
                return;

            Query = Query.Where(p => p.StudentTeachers.Any(q => q.Teacher.Id == SearchVm.TeacherId));
        }


    }
}
