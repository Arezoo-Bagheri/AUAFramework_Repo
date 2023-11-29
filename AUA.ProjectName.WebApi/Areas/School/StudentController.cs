using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.School
{

    // [WebApiAuthorize(EUserAccess.Student)]
    public class StudentController : BaseApiController
    {

        private readonly IStudentService _studentService;


        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<IActionResult> PostStudent([FromBody] Student student)
        {
            await _studentService.AddStudentAsync(student);
            return Ok(student);
        }

    }
}
