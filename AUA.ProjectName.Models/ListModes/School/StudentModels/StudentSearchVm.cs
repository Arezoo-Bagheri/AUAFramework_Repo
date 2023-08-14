using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ListModes.School.StudentModels
{
    public class StudentSearchVm : BaseSearchVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string TeacherName { get; set; }
        public long? TeacherId { get; set; }

    }
}
