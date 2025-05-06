using OOP_Lab7.model.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Lab7.view;
using static OOP_Lab7.model.service.StudentService;

namespace OOP_Lab7.model.service
{

    /// <summary>
    /// Интерфейс для создания моков в тестах
    /// </summary>
    public interface IStudentService 
    {
        /// <summary>
        /// Событие добавления студента
        /// </summary>
        public event StudentAddedEventHandler StudentAdded;
        /// <summary>
        /// Событие удаления студента
        /// </summary>
        public event StudentRemovedEventHandler StudentRemoved;

        public event StudentNotFoundEventHandler StudentNotFound;
        void AddStudent(Student student);
        bool RemoveStudent(int id);
        string GetStudentInfo(int id);
        string GetAllStudentsInfo();

        /// <summary>
        /// Событие при добавлении студента
        /// </summary>
        /// <param name="student">Студент</param>
        void OnStudentAdded(Student student);


        /// <summary>
        /// Событие при удалении студента
        /// </summary>
        /// <param name="student">Студент</param>
        void OnStudentRemoved(Student student);

    }
}
