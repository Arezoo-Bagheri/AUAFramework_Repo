using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Services.EntitiesService.School.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationEfContext _context;

        public StudentService(ApplicationEfContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            await _context.AddAsync(student);
            return student;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            _context.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> FindStudentAsync(int id)
        {
            var student = await _context.Students.SingleOrDefaultAsync(c => c.Id == id);
            return student;
        }

    }
}
