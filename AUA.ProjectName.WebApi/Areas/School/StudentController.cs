using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.ValidationServices.School.StudentValidations.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using AUA.ProjectName.WebApi.Utility.ApiAuthorization;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.School
{

    [WebApiAuthorize(EUserAccess.Student)]
    public class StudentController : BaseApiController
    {

        private readonly IStudentService _studentService;
        private readonly IInsertStudentDtoValidationService _insertStudentDtoValidationService;


        public StudentController(IStudentService studentService
                                             , IInsertStudentDtoValidationService insertStudentDtoValidationService)
        {
            _studentService = studentService;
            _insertStudentDtoValidationService = insertStudentDtoValidationService;
        }

        [WebApiAuthorize(EUserAccess.AppUser)]
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
