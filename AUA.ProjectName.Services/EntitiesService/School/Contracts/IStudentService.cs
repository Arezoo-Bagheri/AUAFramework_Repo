using AUA.ProjectName.DomainEntities.Entities.School;

namespace AUA.ProjectName.Services.EntitiesService.School.Contracts
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Task<Student> AddStudentAsync(Student student);
        Task<Student> UpdateStudentAsync(Student student);
        Task<Student> FindStudentAsync(int id);

    }
}
