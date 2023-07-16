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
    public class TeacherService : GenericEntityService<Teacher, TeacherDto, long>, ITeacherService
    {
        public TeacherService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {
        }


        public async Task<List<TeacherComboVm>> GetTeacherComboVmAsync()
        {
            return await GetAll()
                                .ConvertTo<TeacherComboVm>(MapperInstance)
                                .ToListAsync();
        }
    }
}
