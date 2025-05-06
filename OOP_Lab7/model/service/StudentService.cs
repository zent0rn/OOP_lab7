using OOP_Lab7.model.entity;
using OOP_Lab7.model.repository;
using OOP_Lab7.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        /// <summary>
        /// Делегат для ссылки на обработчик события добавления студента
        /// </summary>
        /// <param name="sender">отправитель сигнала</param>
        /// <param name="e">параметры</param>
        public delegate void StudentAddedEventHandler(object sender, StudentDataEventArgs e);
        /// <summary>
        /// Делегат для ссылки на обработчик события удаления студента
        /// </summary>
        /// <param name="sender">отправитель сигнала</param>
        /// <param name="e">параметры</param>
        public delegate void StudentRemovedEventHandler(object sender, StudentDataEventArgs e);

        public delegate void StudentNotFoundEventHandler(object sender, int id);

        /// <summary>
        /// Событие добавления студента
        /// </summary>
        public event StudentAddedEventHandler StudentAdded;
        /// <summary>
        /// Событие удаления студента
        /// </summary>
        public event StudentRemovedEventHandler StudentRemoved;

        public event StudentNotFoundEventHandler StudentNotFound;

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
            OnStudentAdded(student);
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
        public bool RemoveStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                var args = new StudentDataEventArgs(student.Name, student.Group,
                    student.Speciality, student.AverageScore, student.DurationOfStudy, student.Id);
                _repository.RemoveStudentById(id);
                OnStudentRemoved(student);
                return true;
            }
            OnStudentNotFound(id);
            return false;
        }

        /// <summary>
        /// Получить информацию о студенте в строковом виде
        /// </summary>
        /// <param name="id">Идентификатор студента</param>
        /// <returns>Если студент найден - информация о студенте, иначе - сообщение о неудаче</returns>
        public string GetStudentInfo(int id)
        {
            var student = _repository.GetStudentById(id);
            if (student != null)
            {
                return student.ToString();
            }

            return $"Студент с id {id} не найден";
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

        /// <summary>
        /// Событие при добавлении студента
        /// </summary>
        /// <param name="student">Студент</param>
        public void OnStudentAdded(Student student)
        {
            StudentAdded?.Invoke(this, new StudentDataEventArgs(student.Name, student.Group, 
                student.Speciality, student.AverageScore, student.DurationOfStudy, student.Id));
        }

        /// <summary>
        /// Событие при удалении студента
        /// </summary>
        /// <param name="student">Студент</param>
        public void OnStudentRemoved(Student student)
        {
            StudentRemoved?.Invoke(this, new StudentDataEventArgs(student.Name, student.Group,
                student.Speciality, student.AverageScore, student.DurationOfStudy, student.Id));
        }

        public void OnStudentNotFound(int id)
        {
            StudentNotFound?.Invoke(this, id);
        }
    }
}
