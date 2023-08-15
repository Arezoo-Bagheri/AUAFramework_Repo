using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.School.TeacherModels;
using AUA.ProjectName.Services.ListService.School.Contracts;
using AUA.ServiceInfrastructure.BaseSearchService;
using AutoMapper;


namespace AUA.ProjectName.Services.ListService.School.Services
{
    public class TeacherListService : BaseListService<Teacher, TeacherListDto, TeacherSearchVm>, ITeacherListService
    {
        public TeacherListService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {
        }

        public async Task<ListResultVm<TeacherListDto>> ListAsync(TeacherSearchVm teacherSearchVm)
        {

            SetSearchVm(teacherSearchVm);


            ApplyAddressFilter();
            ApplyTeacherIdsFilter();
            ApplyRegistrationFromDateFilter();
            ApplyRegistrationToDateFilter();


            return await CreateListVmResultAsync();
        }

        private void ApplyAddressFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.Address))
                return;

            Query = Query.Where(p => p.Address.Contains(SearchVm.Address));
        }

        private void ApplyTeacherIdsFilter()
        {
            if (SearchVm.Address == null || !SearchVm.TeacherIds.Any())
                return;

            Query = Query.Where(p => SearchVm.TeacherIds.Any(q => q == p.Id));
        }

        private void ApplyRegistrationFromDateFilter()
        {
            if (SearchVm.RegistrationFromDate.IsEmpty())
                return;

            Query = Query.Where(p => p.RegistrationDate.Date >= SearchVm.RegistrationFromDate.Value.Date);
        }

        private void ApplyRegistrationToDateFilter()
        {
            if (SearchVm.RegistrationToDate.IsEmpty())
                return;

            Query = Query.Where(p => p.RegistrationDate.Date <= SearchVm.RegistrationToDate.Value.Date);
        }


    }
}
