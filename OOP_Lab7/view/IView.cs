using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IView.cs
namespace OOP_Lab7.view
{
    /// <summary>
    /// Интерфейс представления (View) для работы с данными студентов
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Получает имя студента из соответствующего поля ввода
        /// </summary>
        /// <returns>Строка с именем студента</returns>
        string GetStudentName();

        /// <summary>
        /// Получает название группы из поля ввода
        /// </summary>
        /// <returns>Строка с наименованием группы</returns>
        string GetGroup();

        /// <summary>
        /// Получает специальность студента из поля ввода
        /// </summary>
        /// <returns>Строка с названием специальности</returns>
        string GetSpeciality();

        /// <summary>
        /// Получает средний балл из числового поля ввода
        /// </summary>
        /// <returns>Числовое значение среднего балла (двойной точности)</returns>
        double GetAverageScore();

        /// <summary>
        /// Получает срок обучения из числового поля ввода
        /// </summary>
        /// <returns>Целое число лет обучения</returns>
        int GetDurationOfStudy();

        /// <summary>
        /// Получает идентификатор студента из поля ввода
        /// </summary>
        /// <returns>Целочисленный идентификатор студента</returns>
        int GetSelectedId();

        /// <summary>
        /// Отображает сообщение в интерфейсе
        /// </summary>
        /// <param name="message">Текст сообщения для отображения</param>
        void ShowMessage(string message);

    }
}
