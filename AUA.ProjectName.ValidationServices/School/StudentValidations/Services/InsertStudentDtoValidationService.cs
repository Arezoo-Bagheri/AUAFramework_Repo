using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.School.StudentValidations.Contracts;

namespace AUA.ProjectName.ValidationServices.School.StudentValidations.Services
{
    public class InsertStudentDtoValidationService : BaseValidationService, IInsertStudentDtoValidationService
    {

        private StudentDto _studentDto;

        public ValidationResultVm Validation(StudentDto studentDto)
        {
            _studentDto = studentDto;

            DoValidation();

            return ValidationResultVm;
        }

        private void DoValidation()
        {
            FixValues();

            DefaultValidations();

            if (HasError) return;

            //ToDo : ...
        }

        private void FixValues()
        {
            // ToDo : ...
        }

        private void DefaultValidations()
        {
            if (IsEmpty(_studentDto.FirstName))
                AddError("FirstName", "FirstName is empty");

            if (IsEmpty(_studentDto.LastName))
                AddError("LastName", "LastName is empty");

            if (_studentDto.Age <= 0)
                AddError("Age", "Age is not valid");
        }


    }
}
