using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ListModes.School.TeacherModels;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.Services.ListService.School.Contracts;
using AUA.ProjectName.ValidationServices.School.TeacherValidations.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.School
{

    public class TeacherController : BaseApiController
    {
        private readonly ITeacherService _teacherService;
        private readonly IInsertTeacherDtoValidationService _insertTeacherDtoValidationService;
        private readonly ITeacherListService _teacherListService;

        public TeacherController(ITeacherService teacherService
                                              , IInsertTeacherDtoValidationService insertTeacherDtoValidationService
                                              , ITeacherListService teacherListService)
        {
            _teacherService = teacherService;
            _insertTeacherDtoValidationService = insertTeacherDtoValidationService;
            _teacherListService = teacherListService;
        }


        public async Task<ResultModel<bool>> SoftDeleteTestAsync()
        {
            var teacher = new Teacher
            {
                FirstName = "Rahim",
                LastName = "Lotfi"
            };

            var teacherId = await _teacherService.InsertAsync(teacher);

            await _teacherService.SoftDeleteAsync(teacherId);

            return CreateSuccessResult(true);
        }


        [HttpPost]
        public async Task<ResultModel<ListResultVm<TeacherListDto>>> GetListAsync(TeacherSearchVm searchVm)
        {
            ValidationSearchVm(searchVm);

            if (HasError)
                return CreateInvalidResult<ListResultVm<TeacherListDto>>();

            var result = await _teacherListService.ListAsync(searchVm);

            return CreateSuccessResult(result);

        }

        [HttpPost]
        public async Task<ResultModel<long>> InsertAsync(TeacherDto teacherDto)
        {

            // Update Audit : 
            //teacherDto.ModifierUserId = UserId;
            //teacherDto.ModifyDate = DateTime.Now;


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
