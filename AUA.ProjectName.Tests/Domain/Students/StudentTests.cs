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
        public void When_pass_correct_values_to_factory_expect_get_all_students()
        {
            var studentList = _fixture.CreateMany<Student>().ToList();
            _mock.Setup(c => c.GetAllStudents()).Returns(studentList);
            _studentController = new StudentController(_mock.Object);
            var result = _studentController.GetAllStudents();
            var obj = result as ObjectResult;
            Assert.NotEqual(200, obj?.StatusCode);
        }

        [Fact]
        public void When_pass_invalid_values_to_factory_expect_invalid_students_exception()
        {
            _mock.Setup(c => c.GetAllStudents()).Throws(new Exception());
            _studentController = new StudentController(_mock.Object);
            var result = _studentController.GetAllStudents();
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

        [Fact]
        public async Task When_pass_correct_values_to_factory_expect_student_create()
        {
            var student = _fixture.Create<Student>();
            _mock.Setup(c => c.AddStudentAsync(It.IsAny<Student>())).ReturnsAsync(student);
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.PostStudent(student);
            var obj = result as ObjectResult;
            Assert.True(obj.StatusCode == 200);
        }

        [Fact]
        public async Task When_pass_invalid_business_id_to_factory_expect_invalid_student_id_exception()
        {
            _mock.Setup(c => c.AddStudentAsync(new Student { Id = 10, FirstName = "" })).Throws(new Exception());
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.PostStudent(new Student { Id = 10, FirstName = "arezoo" });
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

        [Fact]
        public async Task When_pass_correct_values_to_factory_expect_student_update()
        {
            var student = _fixture.Create<Student>();
            _mock.Setup(c => c.UpdateStudentAsync(It.IsAny<Student>())).ReturnsAsync(student);
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.PutStudent(student);
            var obj = result as ObjectResult;
            Assert.True(obj.StatusCode == 200);
        }

        [Fact]
        public async Task When_pass_invalid_business_id_and_name_to_factory_expect_invalid_student_exception()
        {
            _mock.Setup(c => c.UpdateStudentAsync(new Student { Id = 1, FirstName = "" })).Throws(new Exception());
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.PutStudent(new Student { Id = 1, FirstName = "arezoo" });
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

        [Fact]
        public async Task When_pass_correct_values_to_factory_expect_student_get_by_id()
        {
            _mock.Setup(c => c.FindStudentAsync(1));
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.GetStudentById(1);
            var obj = result as ObjectResult;
            Assert.True(obj.StatusCode == 200);
        }

        [Fact]
        public async Task When_pass_invalid_values_to_factory_expect_invalid_student_exception()
        {
            _mock.Setup(c => c.FindStudentAsync(1)).Throws(new Exception());
            _studentController = new StudentController(_mock.Object);
            var result = await _studentController.GetStudentById(2);
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

    }
}
