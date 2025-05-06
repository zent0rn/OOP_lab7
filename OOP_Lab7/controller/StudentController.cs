using OOP_Lab7.model.entity;
using OOP_Lab7.model.service;
using OOP_Lab7.view;

namespace OOP_Lab7.controller
{
    /// <summary>
    /// Контроллер для управления взаимодействием между Model и View в паттерне MVC
    /// </summary>
    /// <remarks>
    /// Реализует логику обработки действий пользователя и координации данных между компонентами
    /// </remarks>
    public class StudentController
    {
        private readonly IStudentService _model; // Используем интерфейс
        private readonly IView _view;


        /// <summary>
        /// Инициализирует новый экземпляр контроллера
        /// </summary>
        /// <param name="model">Сервис для работы с данными студентов (Model)</param>
        /// <param name="view">Представление для отображения данных (View)</param>
        public StudentController(IStudentService model, IView view)
        {
            _model = model;
            _view = view;

            _view.AddStudentRequested += new EventHandler<StudentDataEventArgs>(AddStudent);
            _view.RemoveStudentRequested += new EventHandler<int>(RemoveStudent);
            _view.GetStudentInfoRequested += new EventHandler<int>(GetStudentInfo);
            _view.GetAllStudentsRequested += new EventHandler<EventArgs>(GetAllStudentsInfo);
        }

        /// <summary>
        /// Обрабатывает добавление нового студента
        /// </summary>
        /// <remarks>
        /// 1. Получает данные из View
        /// 2. Создает объект Student
        /// 3. Сохраняет в Model через сервис
        /// 4. Обновляет View
        /// </remarks>
        public void AddStudent(object? sender, StudentDataEventArgs eventArgs)
        {
            var student = new Student(
                eventArgs.Name,
                eventArgs.Group,
                eventArgs.Speciality,
                eventArgs.AverageScore,
                eventArgs.DurationOfStudy
            );

            _model.AddStudent(student);
        
        }

        /// <summary>
        /// Обрабатывает удаление студента по ID
        /// </summary>
        /// <remarks>
        /// 1. Получает ID из View
        /// 2. Вызывает удаление в Model
        /// 3. Отображает результат в View
        /// </remarks>
        public void RemoveStudent(object? sender, int id)
        {
            bool result = _model.RemoveStudent(id);


        }

        /// <summary>
        /// Получает и отображает информацию о студенте
        /// </summary>
        /// <remarks>
        /// 1. Запрашивает данные из Model
        /// 2. Форматирует результат
        /// 3. Передает в View для отображения
        /// </remarks>
        public void GetStudentInfo(object? sender, int id)
        {
            string info = _model.GetStudentInfo(id);
            _view.ShowMessage(info);
        }

        /// <summary>
        /// Получает и отображает информацию о всех студентах
        /// </summary>
        public void GetAllStudentsInfo(object? sender, EventArgs eventArgs)
        {
            string info = _model.GetAllStudentsInfo();
            _view.ShowMessage(info);
        }
    }
}