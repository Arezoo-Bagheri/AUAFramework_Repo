using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.School.StudentModels;
using AUA.ServiceInfrastructure.BaseSearchService;

namespace AUA.ProjectName.Services.ListService.School.Contracts
{
    public interface IStudentListService : IBaseListService<Student, StudentListDto>
    {
        Task<ListResultVm<StudentListDto>> ListAsync(StudentSearchVm studentSearchVm);
        
    }
}

