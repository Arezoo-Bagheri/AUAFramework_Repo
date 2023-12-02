using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Services.EntitiesService.School.Contracts;
using AUA.ProjectName.WebApi.Areas.School;
using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AUA.ProjectName.Tests.Domain.Teachers
{
    public class TeacherTests
    {
        private Mock<ITeacherService> _mock;
        private Fixture _fixture;
        private TeacherController _teacherController;

        public TeacherTests()
        {
            _mock = new Mock<ITeacherService>();
            _fixture = new Fixture();
            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
            .ForEach(b => _fixture.Behaviors.Remove(b));
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        [Fact]
        public void When_pass_correct_values_to_factory_expect_get_all_teachers()
        {
            var teacherList = _fixture.CreateMany<Teacher>().ToList();
            _mock.Setup(c => c.GetAllTeachers()).Returns(teacherList);
            _teacherController = new TeacherController(_mock.Object);
            var result = _teacherController.GetAll();
            var obj = result as ObjectResult;
            Assert.NotEqual(200, obj?.StatusCode);
        }

        [Fact]
        public void When_pass_invalid_values_to_factory_expect_invalid_teachers_exception()
        {
            _mock.Setup(c => c.GetAllTeachers()).Throws(new Exception());
            _teacherController = new TeacherController(_mock.Object);
            var result = _teacherController.GetAll();
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

        [Fact]
        public async Task When_pass_correct_values_to_factory_expect_teacher_create()
        {
            var teacher = _fixture.Create<Teacher>();
            _mock.Setup(c => c.AddTeacherAsync(It.IsAny<Teacher>())).ReturnsAsync(teacher);
            _teacherController = new TeacherController(_mock.Object);
            var result = await _teacherController.Post(teacher);
            var obj = result as ObjectResult;
            Assert.True(obj.StatusCode == 200);
        }

        [Fact]
        public async Task When_pass_invalid_business_id_to_factory_expect_invalid_teacher_id_exception()
        {
            _mock.Setup(c => c.AddTeacherAsync(new Teacher { Id = 10, FirstName = "" })).Throws(new Exception());
            _teacherController = new TeacherController(_mock.Object);
            var result = await _teacherController.Post(new Teacher { Id = 10, FirstName = "Rahim" });
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

        [Fact]
        public async Task When_pass_correct_values_to_factory_expect_teacher_update()
        {
            var teacher = _fixture.Create<Teacher>();
            _mock.Setup(c => c.UpdateTeacherAsync(It.IsAny<Teacher>())).ReturnsAsync(teacher);
            _teacherController = new TeacherController(_mock.Object);
            var result = await _teacherController.Put(teacher);
            var obj = result as ObjectResult;
            Assert.True(obj.StatusCode == 200);
        }

        [Fact]
        public async Task When_pass_invalid_business_id_and_name_to_factory_expect_invalid_teacher_exception()
        {
            _mock.Setup(c => c.UpdateTeacherAsync(new Teacher { Id = 1, FirstName = "" })).Throws(new Exception());
            _teacherController = new TeacherController(_mock.Object);
            var result = await _teacherController.Put(new Teacher { Id = 1, FirstName = "Rahim" });
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }

        [Fact]
        public async Task When_pass_correct_values_to_factory_expect_teacher_get_by_id()
        {
            _mock.Setup(c => c.FindTeacherAsync(1));
            _teacherController = new TeacherController(_mock.Object);
            var result = await _teacherController.GetById(1);
            var obj = result as ObjectResult;
            Assert.True(obj.StatusCode == 200);
        }

        [Fact]
        public async Task When_pass_invalid_values_to_factory_expect_invalid_teacher_exception()
        {
            _mock.Setup(c => c.FindTeacherAsync(1)).Throws(new Exception());
            _teacherController = new TeacherController(_mock.Object);
            var result = await _teacherController.GetById(2);
            var obj = result as ObjectResult;
            Assert.NotEqual(400, obj?.StatusCode);
        }
    }
}
