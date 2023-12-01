using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.School
{

    public class TeacherController : BaseApiController
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public IEnumerable<Teacher> GetAll()
        {
            return _teacherService.GetAllTeachers();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Teacher teacher)
        {
            await _teacherService.AddTeacherAsync(teacher);
            return Ok(teacher);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Teacher teacher)
        {
            await _teacherService.UpdateTeacherAsync(teacher);
            return Ok(teacher);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            await _teacherService.FindTeacherAsync(id);
            return Ok();
        }
    }
}
