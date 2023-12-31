﻿using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ServiceInfrastructure.BaseSearchService;
using AutoMapper;

namespace AUA.ProjectName.Services.ListService.Accounting.Services
{
    public sealed class AppUserListService : BaseListService<AppUser, AppUserListDto, AppUserSearchVm>, IAppUserListService
    {
        public AppUserListService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {

        }

        public async Task<ListResultVm<AppUserListDto>> ListAsync(AppUserSearchVm appUserSearchVm)
        {
            SetSearchVm(appUserSearchVm);

            ApplyUserNameFilter();
            ApplyLastNameFilter();
            ApplyFirstNameFilter();
            ApplyIsActiveFilters();


            return await CreateListVmResultAsync();
        }

        private void ApplyUserNameFilter()
        {
            if (SearchVm.UserName is null)
                return;

            Query = Query.Where(p => p.UserName.Contains(SearchVm.UserName));
        }

        private void ApplyLastNameFilter()
        {
            if (SearchVm.LastName is null)
                return;

            Query = Query.Where(p => p.LastName.Contains(SearchVm.LastName));
        }

        private void ApplyFirstNameFilter()
        {
            if (SearchVm.FirstName is null)
                return;

            Query = Query.Where(p => p.FirstName.Contains(SearchVm.FirstName));
        }

        private void ApplyIsActiveFilters()
        {
            if (SearchVm.IsActive is null)
                return;

            Query = Query.Where(p => p.IsActive == SearchVm.IsActive);
        }


    }
}
