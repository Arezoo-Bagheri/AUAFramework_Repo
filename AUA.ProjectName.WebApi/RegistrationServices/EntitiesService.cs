using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Accounting.Services;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.Services.EntitiesService.School.Services;

namespace AUA.ProjectName.WebApi.RegistrationServices
{
    public static class EntitiesService
    {

        public static void RegistrationEntitiesService(this IServiceCollection services)
        {
            services.RegistrationBaseService();

            services.RegistrationAccountingService();

            services.RegistrationBaseInformationService();

            services.RegistrationSchoolService();

        }

        private static void RegistrationBaseService(this IServiceCollection services)
        {
            services.AddDbContext<IUnitOfWork, ApplicationEfContext>();
        }

        private static void RegistrationAccountingService(this IServiceCollection services)
        {
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IUserAccessService, UserAccessService>();
            services.AddScoped<IUserRoleAccessService, UserRoleAccessService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<IActiveAccessTokenService, ActiveAccessTokenService>();
            services.AddScoped<IRoleService, RoleService>();
        }


        private static void RegistrationSchoolService(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IStudentTeacherService,StudentTeacherService>();
        }


        private static void RegistrationBaseInformationService(this IServiceCollection services)
        {

        }





    }
}
