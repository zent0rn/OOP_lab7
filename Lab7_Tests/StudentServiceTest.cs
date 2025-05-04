using Moq;
using OOP_Lab7.model.entity;
using OOP_Lab7.model.repository;
using OOP_Lab7.model.repository.impl;
using OOP_Lab7.model.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7_Tests
{
    [TestClass]
    public sealed class StudentServiceTest
    {
        private Mock<IStudentRepository> _repositoryMock;
        private StudentService _studentService;

        Student expectedStudent = new Student(
                "Имя",
                "Группа",
                "Специальность",
                4.3,
                5
            );

        [TestInitialize]
        public void setup() {
            _repositoryMock = new Mock<IStudentRepository>();
            _studentService = new StudentService(_repositoryMock.Object);
        }

        [TestMethod]
        public void GetStudentInfo_WhenStudentNotFound_ThenReturnErrorMessage()
        {
            int id = 1;
            Student? result = null;
            string expected = $"Студент с id {id} не найден";
            _repositoryMock.Setup(d => d.GetStudentById(id)).Returns(result);

            string studentInfo = _studentService.GetStudentInfo(id);

            Assert.AreEqual(expected, studentInfo);
        }

        [TestMethod]
        public void GetStudentInfo_WhenStudentWasFound_ThenReturnStudentInfo()
        {
            int id = expectedStudent.Id;
            string expected = $"""
                Студент {expectedStudent.Name} (id: {expectedStudent.Id}), группа {expectedStudent.Group}
                Обучается по специальности {expectedStudent.Speciality} (срок обучения (лет): {expectedStudent.DurationOfStudy})
                Средний балл: {expectedStudent.AverageScore}
                """;
            _repositoryMock.Setup(d => d.GetStudentById(id)).Returns(expectedStudent);

            string studentInfo = _studentService.GetStudentInfo(id);

            Assert.AreEqual(expected, studentInfo);
        }

        [TestMethod]
        public void GetAllStudentsInfo_WhenStudentsExists_ThenReturnStudentsInfo()
        {
            string expected = expectedStudent.ToString() + '\n';
            _repositoryMock.Setup(d => d.GetAllStudents()).Returns(new List<Student> { expectedStudent });

            string studentInfo = _studentService.GetAllStudentsInfo();

            Assert.AreEqual(expected, studentInfo);
        }
    }
}
