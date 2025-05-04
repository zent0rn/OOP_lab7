using OOP_Lab7.model.entity;
using OOP_Lab7.model.repository.impl;

namespace Lab7_Tests
{
    [TestClass]
    public sealed class StudentRepositoryTest
    {
        StudentInMemoryRepository repo = new StudentInMemoryRepository();

        Student expectedStudent = new Student(
                "Имя",
                "Группа",
                "Специальность",
                4.3,
                5
            );

        [TestMethod]
        public void AddStudentWorksCorrectly()
        {
            repo.AddStudent(expectedStudent);

            Student actualStudent = repo.GetAllStudents()[0];

            Assert.AreEqual(expectedStudent, actualStudent);
        }

        [TestMethod]
        public void GetStudentById_WhenWrongId_ThenReturnNull()
        {

            Student? actualStudent = repo.GetStudentById(-1);

            Assert.IsNull(actualStudent);
        }

        [TestMethod]
        public void GetStudentById_WhenCorrectId_ThenReturnStudent()
        {
            int correctId = expectedStudent.Id;
            repo.AddStudent(expectedStudent);

            Student? actualStudent = repo.GetStudentById(correctId);

            Assert.AreEqual(expectedStudent, actualStudent);
        }

        [TestMethod]
        public void RemoveStudentById_WhenWrongId_ThenReturnFalse()
        {
            bool result = repo.RemoveStudentById(-1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetStudentById_WhenCorrectId_ThenReturnTrue()
        {
            int correctId = expectedStudent.Id;

            bool result = repo.RemoveStudentById(correctId);

            Assert.IsFalse(result);
        }
    }
}
