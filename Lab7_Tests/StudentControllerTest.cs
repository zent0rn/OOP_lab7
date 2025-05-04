using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Lab7.controller;
using OOP_Lab7.model.entity;
using OOP_Lab7.model.repository.impl;
using OOP_Lab7.model.service;
using OOP_Lab7.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Tests
{
    [TestClass]
    public class StudentControllerTests
    {
        private Mock<IStudentService> _mockStudentService;
        private Mock<IView> _mockView;
        private StudentController _controller;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockStudentService = new Mock<IStudentService>();
            _mockView = new Mock<IView>();
            _controller = new StudentController(_mockStudentService.Object, _mockView.Object);
        }

        [TestMethod]
        public void AddStudent_ValidData_CallsServiceAndShowsMessage()
        {
            // Arrange
            _mockView.Setup(v => v.GetStudentName()).Returns("Иван Иванов");
            _mockView.Setup(v => v.GetGroup()).Returns("Группа 101");
            _mockView.Setup(v => v.GetSpeciality()).Returns("Информатика");
            _mockView.Setup(v => v.GetAverageScore()).Returns(4.5);
            _mockView.Setup(v => v.GetDurationOfStudy()).Returns(4);

            // Act
            _controller.AddStudent();

            // Assert
            _mockStudentService.Verify(s => s.AddStudent(It.IsAny<Student>()), Times.Once);
            _mockView.Verify(v => v.ShowMessage(It.IsRegex(@"Студент добавлен! ID: \d+")), Times.Once);
        }

        [TestMethod]
        public void GetStudentInfo_ExistingId_ShowsStudentInfo()
        {
            // Arrange
            const int testId = 1;
            var expectedStudent = new Student("Иван Иванов", "Группа 101", "Информатика", 4.5, 4);
            _mockView.Setup(v => v.GetSelectedId()).Returns(testId);
            _mockStudentService.Setup(s => s.GetStudentInfo(testId)).Returns(expectedStudent.ToString());

            // Act
            _controller.GetStudentInfo();

            // Assert
            _mockView.Verify(v => v.ShowMessage(expectedStudent.ToString()), Times.Once);
        }

        [TestMethod]
        public void GetStudentInfo_InvalidId_ShowsErrorMessage()
        {
            // Arrange
            const int invalidId = 999;
            _mockView.Setup(v => v.GetSelectedId()).Returns(invalidId);
            _mockStudentService.Setup(s => s.GetStudentInfo(invalidId)).Returns("Студент не найден");

            // Act
            _controller.GetStudentInfo();

            // Assert
            _mockView.Verify(v => v.ShowMessage("Студент не найден"), Times.Once);
        }

        [TestMethod]
        public void GetAllStudentsInfo_EmptyList_ShowsNoDataMessage()
        {
            // Arrange
            _mockStudentService.Setup(s => s.GetAllStudentsInfo()).Returns("Нет данных о студентах");

            // Act
            _controller.GetAllStudentsInfo();

            // Assert
            _mockView.Verify(v => v.ShowMessage("Нет данных о студентах"), Times.Once);
        }

        [TestMethod]
        public void GetAllStudentsInfo_WithStudents_ShowsFormattedList()
        {
            // Arrange
            var students = new List<Student>
        {
            new Student("Алексей Петров", "Группа 102", "Математика", 4.8, 3),
            new Student("Мария Сидорова", "Группа 103", "Физика", 4.9, 4)
        };

            var expectedMessage = string.Join("\n", students.Select(s => s.ToString()));
            _mockStudentService.Setup(s => s.GetAllStudentsInfo()).Returns(expectedMessage);

            // Act
            _controller.GetAllStudentsInfo();

            // Assert
            _mockView.Verify(v => v.ShowMessage(expectedMessage), Times.Once);
        }

        [TestMethod]
        public void RemoveStudent_ExistingId_ShowsSuccessMessage()
        {
            // Arrange
            const int testId = 1;
            _mockView.Setup(v => v.GetSelectedId()).Returns(testId);
            _mockStudentService.Setup(s => s.RemoveStudent(testId)).Returns(true);

            // Act
            _controller.RemoveStudent();

            // Assert
            _mockView.Verify(v => v.ShowMessage($"Студент {testId} удален"), Times.Once);
        }
    }
}
