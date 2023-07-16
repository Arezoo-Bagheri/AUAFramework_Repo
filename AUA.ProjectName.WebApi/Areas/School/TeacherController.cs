using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.WebApi.Areas.School
{

    public class TeacherController : BaseApiController
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost]
        public async Task<ResultModel<long>> InsertAsync(TeacherDto teacherDto)
        {
            var teacherId = await _teacherService.InsertAsync(teacherDto);

            return CreateSuccessResult(teacherId);
        }


        [HttpGet]
        public async Task<ResultModel<List<TeacherComboVm>>> GetTeacherComboVmAsync()
        {
            var result = await _teacherService.GetTeacherComboVmAsync();
            return CreateSuccessResult(result);
        }
    }
}
