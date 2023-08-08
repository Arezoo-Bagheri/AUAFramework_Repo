using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.School;

namespace AUA.ProjectName.ValidationServices.School.TeacherValidations.Contracts
{
    public interface IInsertTeacherDtoValidationService
    {
        ValidationResultVm Validation(TeacherDto teacherDto);
    }
}
