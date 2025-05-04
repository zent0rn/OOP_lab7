using OOP_Lab7.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7.model.repository
{
    /// <summary>
    /// Интерфейс репозитория для хранения сущностей класса Student
    /// </summary>
    public interface IStudentRepository
    {
        /// <summary>
        /// Добавить студента в "базу данных"
        /// </summary>
        /// <param name="student">Объект класса "Student" для сохранения</param>
        public void AddStudent(Student student);

        /// <summary>
        /// Получить студента по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор студента</param>
        /// <returns>Объект класса Student, если студент найден, иначе - null</returns>
        public Student? GetStudentById(int id);

        /// <summary>
        /// Получить список всех студентов из "базы данных"
        /// </summary>
        /// <returns>Список студентов, сохраненных в "БД"</returns>
        public List<Student> GetAllStudents();

        /// <summary>
        /// Удалить студента
        /// </summary>
        /// <param name="id">Идентификатор удаляемого студента</param>
        /// <returns>true - студент удален успешно, false - студент не найден в БД</returns>
        public bool RemoveStudentById(int id);
    }
}
