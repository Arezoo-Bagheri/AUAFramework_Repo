using AUA.ProjectName.DomainEntities.Entities.School;

namespace AUA.ProjectName.Services.EntitiesService.School.Contracts
{
    public interface IStudentService
    {
        //List<Student> GetAll();
        Task<Student> AddStudentAsync(Student student);
        //Task<Student> UpdateStudentAsync(Student student);
        //Task<Student> RemoveStudentAsync(int id);
        //Task<Student> FindStudentAsync(int id);
    }
}
