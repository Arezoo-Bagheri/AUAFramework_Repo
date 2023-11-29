using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.WebApi.Areas.School;
using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AUA.ProjectName.Tests.Domain.Students
{
    public class StudentTests
    {

        private Mock<IStudentService> _mock;
        private Fixture _fixture;
        private StudentController _studentController;

        public StudentTests()
        {
            _mock = new Mock<IStudentService>();
            _fixture = new Fixture();
            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
            .ForEach(b => _fixture.Behaviors.Remove(b));
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }


        [Fact]
        public async Task When_pass_correct_values_To_Factory_expect_student_create()
        {
            var student = _fixture.Create<Student>();
            _mock.Setup(repo => repo.AddStudentAsync(It.IsAny<Student>())).ReturnsAsync(student);
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.PostStudent(student);
            var obj = result as ObjectResult;
            Assert.True(obj.StatusCode == 200);
        }

        [Fact]
        public async Task When_pass_invalid_business_id_to_factory_expect_invalid_student_id_exception()
        {
            _mock.Setup(repo => repo.AddStudentAsync(new Student { Id = 10, FirstName = "" })).Throws(new Exception());
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.PostStudent(new Student { Id = 10, FirstName = "arezoo" });
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

    }
}
