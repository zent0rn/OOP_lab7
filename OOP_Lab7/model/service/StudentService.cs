using OOP_Lab7.model.entity;
using OOP_Lab7.model.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7.model.service
{
    /// <summary>
    /// Класс для взаимодействия с сущностями Student и их обработки
    /// </summary>
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Сохранить студента в системе
        /// </summary>
        /// <param name="student">Сохраняемый объект</param>
        public void AddStudent(Student student) {
            _repository.AddStudent(student);
        }

        /// <summary>
        /// Получить информацию о студенте по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор студента</param>
        /// <returns>Объект класса Student, если студент найден, иначе - null</returns>
        public Student? GetStudentById(int id) {
            return _repository.GetStudentById(id);
        }

        /// <summary>
        /// Получить всех сохраненных студентов
        /// </summary>
        /// <returns>Список студентов, сохраненных в системе</returns>
        public List<Student> GetAllStudents() {
            return _repository.GetAllStudents();
        }

        /// <summary>
        /// Удалить студента
        /// </summary>
        /// <param name="id">Идентификатор удаляемого студента</param>
        /// <returns>true - студент удален, false - студент не найден</returns>
        public bool RemoveStudent(int id) {
            return _repository.RemoveStudentById(id);
        }

        /// <summary>
        /// Получить информацию о студенте в строковом виде
        /// </summary>
        /// <param name="id">Идентификатор студента</param>
        /// <returns>Если студент найден - информация о студенте, иначе - сообщение о неудаче</returns>
        public string GetStudentInfo(int id) {
            return _repository.GetStudentById(id)?.ToString() ?? $"Студент с id {id} не найден";
        }

        /// <summary>
        /// Получить информацию о всех студентах в строковом виде
        /// </summary>
        /// <returns>Данные о студентах, если данных нет - сообщение с предупреждением</returns>
        public string GetAllStudentsInfo() {
            string result = "";
            foreach (Student student in _repository.GetAllStudents()) {
                result += student.ToString() + '\n';
            }
            if (string.IsNullOrEmpty(result)) {
                return "Нет данных о студентах";
            }
            return result;
        }
    }
}
