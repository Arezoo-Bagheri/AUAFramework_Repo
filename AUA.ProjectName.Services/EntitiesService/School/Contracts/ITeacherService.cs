using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ServiceInfrastructure.BaseServices;

namespace AUA.ProjectName.Services.EntitiesService.School.Contracts
{
    public interface ITeacherService : IGenericEntityService<Teacher, TeacherDto, long>
    {
        Task<List<TeacherComboVm>> GetTeacherComboVmAsync();
    }
}
