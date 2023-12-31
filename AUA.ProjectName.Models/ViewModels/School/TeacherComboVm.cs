﻿using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.School;

namespace AUA.ProjectName.Models.ViewModels.School
{
    public class TeacherComboVm : IMapFrom<Teacher>
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
    }
}
