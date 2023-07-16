using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ServiceInfrastructure.BaseServices;
using AutoMapper;

namespace AUA.ProjectName.Services.EntitiesService.School.Services
{
    public class StudentTeacherService : GenericEntityService<StudentTeacher, StudentTeacherDto, long> , IStudentTeacherService
    {
        public StudentTeacherService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {
        }
    }
}
