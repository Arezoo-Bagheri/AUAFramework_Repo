﻿using AUA.ProjectName.DomainEntities.Entities.School;
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

        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return _studentService.GetAllStudents();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student student)
        {
            await _studentService.AddStudentAsync(student);
            return Ok(student);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Student student)
        {
            await _studentService.UpdateStudentAsync(student);
            return Ok(student);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            await _studentService.FindStudentAsync(id);
            return Ok();
        }

    }
}
