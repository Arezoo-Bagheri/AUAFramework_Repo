using AUA.Mapping.Mapping;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ServiceInfrastructure.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Services.EntitiesService.School.Services
{
    public class StudentService : GenericEntityService<Student, StudentDto>, IStudentService
    {
        public StudentService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {
        }

        public async Task<IEnumerable<StudentVm>> GetStudentVmsAsync()
        {
            return await GetAll()
                               .ConvertTo<StudentVm>(MapperInstance)
                               .ToListAsync();
        }
    }
}
