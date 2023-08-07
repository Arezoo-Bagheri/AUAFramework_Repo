using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.School;

namespace AUA.ProjectName.ValidationServices.School.StudentValidations.Contracts
{
    public  interface IInsertStudentDtoValidationService
    {
        ValidationResultVm Validation(StudentDto studentDto);
    }
}
