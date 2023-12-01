using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Services.EntitiesService.School.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ApplicationEfContext _context;

        public TeacherService(ApplicationEfContext context)
        {
            _context = context;
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            await _context.AddAsync(teacher);
            return teacher;
        }

        public async Task<Teacher> FindTeacherAsync(int id)
        {
            var teacher = await _context.Teachers.SingleOrDefaultAsync(c => c.Id == id);
            return teacher;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public async Task<Teacher> UpdateTeacherAsync(Teacher teacher)
        {
            _context.Update(teacher);
            await _context.SaveChangesAsync();
            return teacher;
        }
    }
}
