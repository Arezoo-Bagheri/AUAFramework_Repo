using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DomainEntities.BaseEntities;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.BaseModel.BaseDto
{
    public class BaseEntityDto<TPrimaryKey> : BaseVm<TPrimaryKey>, IBaseEntityDto, IModifiedAudited
    {
        public DateTime RegistrationDate { get; private protected set; }

        public string RegistrationDatePersian => RegistrationDate.ToPersianDate();

        public long? ModifierUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
    }



}
