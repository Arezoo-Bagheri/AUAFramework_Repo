using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ListModes.School.TeacherModels
{
    public class TeacherSearchVm : BaseSearchVm
    {
        public string Address { get; set; }
        public IEnumerable<long> TeacherIds { get; set; }
        public DateTime? RegistrationFromDate { get; set; }
        public DateTime? RegistrationToDate { get; set; }
    }
}
