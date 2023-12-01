using AUA.ProjectName.DomainEntities.Entities.School;

namespace AUA.ProjectName.Services.EntitiesService.School.Contracts
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAllTeachers();
        Task<Teacher> AddTeacherAsync(Teacher teacher);
        Task<Teacher> UpdateTeacherAsync(Teacher teacher);
        Task<Teacher> FindTeacherAsync(int id);
    }
}
