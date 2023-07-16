using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ServiceInfrastructure.BaseServices;

namespace AUA.ProjectName.Services.EntitiesService.School.Contracts
{
    public interface IStudentTeacherService : IGenericEntityService<StudentTeacher, StudentTeacherDto, long>
    {
    }
}
