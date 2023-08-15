using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ProjectName.Services.ListService.Accounting.Services;
using AUA.ProjectName.Services.ListService.School.Contracts;
using AUA.ProjectName.Services.ListService.School.Services;

namespace AUA.ProjectName.WebApi.RegistrationServices
{
    public static class ListService
    {

        public static void RegistrationListService(this IServiceCollection services)
        {
            services.RegistrationAccountingListService();

            services.RegistrationSchoolListService();
        }

        public static void RegistrationAccountingListService(this IServiceCollection services)
        {
            services.AddScoped<IAppUserListService, AppUserListService>();
            services.AddScoped<IRoleListService, RoleListService>();
            services.AddScoped<IUserAccessListService, UserAccessListService>();
            services.AddScoped<IUserRoleListService, UserRoleListService>();
            services.AddScoped<IUserRoleAccessListService, UserRoleAccessListService>();
        }

        public static void RegistrationSchoolListService(this IServiceCollection services)
        {
            services.AddScoped<IStudentListService, StudentListService>();
            services.AddScoped<ITeacherListService, TeacherListService>();
        }


    }
}
