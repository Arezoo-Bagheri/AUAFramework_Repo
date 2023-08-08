using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.School.TeacherValidations.Contracts;

namespace AUA.ProjectName.ValidationServices.School.TeacherValidations.Services
{
    public class InsertTeacherDtoValidationService : BaseValidationService, IInsertTeacherDtoValidationService
    {

        private TeacherDto _teacherDto;

        public ValidationResultVm Validation(TeacherDto teacherDto)
        {
            _teacherDto = teacherDto;

            DoValidation();

            return ValidationResultVm;
        }

        private void DoValidation()
        {
            FixValues();

            DefaultValidations();

            if (HasError) return;

            // ToDo : ...
        }

        private void FixValues()
        {
            // ToDo : ...
        }

        private void DefaultValidations()
        {
            if (IsEmpty(_teacherDto.FirstName))
                AddError("FirstName", "FirstName is empty");

            if (IsEmpty(_teacherDto.LastName))
                AddError("LastName", "LastName is empty");
        }


    }
}

