using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.ValidationServices.School.TeacherValidations.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.School
{

    public class TeacherController : BaseApiController
    {
        private readonly ITeacherService _teacherService;
        private readonly IInsertTeacherDtoValidationService _insertTeacherDtoValidationService;

        public TeacherController(ITeacherService teacherService
                                              , IInsertTeacherDtoValidationService insertTeacherDtoValidationService)
        {
            _teacherService = teacherService;
            _insertTeacherDtoValidationService = insertTeacherDtoValidationService;
        }

        [HttpPost]
        public async Task<ResultModel<long>> InsertAsync(TeacherDto teacherDto)
        {
            ValidationResultVm = _insertTeacherDtoValidationService.Validation(teacherDto);

            if (HasError)
                return CreateInvalidResult<long>();

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
