using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.School.TeacherModels;
using AUA.ServiceInfrastructure.BaseSearchService;

namespace AUA.ProjectName.Services.ListService.School.Contracts
{
    public interface ITeacherListService : IBaseListService<Teacher, TeacherListDto>
    {
        Task<ListResultVm<TeacherListDto>> ListAsync(TeacherSearchVm teacherSearchVm);
    }
}
