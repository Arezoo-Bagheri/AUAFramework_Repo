using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ListModes.School.StudentModels;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.Services.ListService.School.Contracts;
using AUA.ProjectName.ValidationServices.School.StudentValidations.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using AUA.ProjectName.WebApi.Utility.ApiAuthorization;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.School
{

    // [WebApiAuthorize(EUserAccess.Student)]
    public class StudentController : BaseApiController
    {

        private readonly IStudentService _studentService;
        private readonly IInsertStudentDtoValidationService _insertStudentDtoValidationService;
        private readonly IStudentListService _studentListService;


        public StudentController(IStudentService studentService
                                             , IInsertStudentDtoValidationService insertStudentDtoValidationService
                                             , IStudentListService studentListService)
        {
            _studentService = studentService;
            _insertStudentDtoValidationService = insertStudentDtoValidationService;
            _studentListService = studentListService;
        }


        [HttpPost]
        public async Task<ResultModel<ListResultVm<StudentListDto>>> GetListAsync(StudentSearchVm searchVm)
        {
            ValidationSearchVm(searchVm);

            if (HasError)
                return CreateInvalidResult<ListResultVm<StudentListDto>>();

            var result = await _studentListService.ListAsync(searchVm);
            return CreateSuccessResult(result);

        }


        [HttpPost]
        public async Task<ResultModel<bool>> ShowTestAsync()
        {
            var studentVm = new InsertStudentVm
            {
                FirstName = "Arezoo",
                LastName = "Bagheri",
                IsActive = true
            };

            var studentId = await _studentService.InsertCustomVmAsync(studentVm);

            return CreateSuccessResult(true);
        }


        [HttpPost]
        public async Task<ResultModel<bool>> InsertAsync()
        {
            var dto = new StudentDto
            {
                FirstName = "Ali",
                LastName = "Ahmadi",
                Age = 25,
                IsActive = true,
                CreatorUserId = UserId,
                StudentTeachers = new List<StudentTeacher>
                {
                    new StudentTeacher
                    {
                        IsActive = true,
                        Teacher = new Teacher
                        {
                            FirstName = "Rahim",
                            LastName = "Lotfi",
                            IsActive = true
                        }
                    }
                }
            };

            var studentId = await _studentService.InsertAsync(dto);
            return CreateSuccessResult(true);
        }

        [HttpGet]
        public async Task<ResultModel<IEnumerable<StudentVm>>> GetStudentVmsAsync()
        {
            var studentVms = await _studentService.GetStudentVmsAsync();

            return CreateSuccessResult(studentVms);
        }


        public async Task<ResultModel<int>> InsertAsync(StudentDto studentDto)
        {
            ValidationResultVm = _insertStudentDtoValidationService.Validation(studentDto);

            if (HasError)
                return CreateInvalidResult<int>();

            var studentId = await _studentService.InsertAsync(studentDto);

            return CreateSuccessResult(studentId);
        }

    }
}
