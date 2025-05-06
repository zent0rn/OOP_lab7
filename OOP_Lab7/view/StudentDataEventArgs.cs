using OOP_Lab7.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7.view
{
    // <summary>
    /// Класс-контейнер для передачи данных о студенте при возникновении события
    /// </summary>
    /// <remarks>
    /// Используется для передачи данных из View в Controller 
    /// при выполнении действий пользователя (например, добавлении студента)
    /// </remarks>
    public class StudentDataEventArgs : EventArgs
    {
        /// <summary>
        /// Полное имя студента
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Учебная группа студента
        /// </summary>
        public string Group { get; }

        /// <summary>
        /// Специальность студента
        /// </summary>
        public string Speciality { get; }

        /// <summary>
        /// Средний балл успеваемости
        /// </summary>
        public double AverageScore { get; }

        /// <summary>
        /// Продолжительность обучения (в годах)
        /// </summary>
        public int DurationOfStudy { get; }

        public int? id { get; }
        /// <summary>
        /// Создает новый экземпляр данных о студенте
        /// </summary>
        /// <param name="name">ФИО студента</param>
        /// <param name="group">Номер/название группы</param>
        /// <param name="speciality">Специальность обучения</param>
        /// <param name="score">Средний балл (допускается дробное значение)</param>
        /// <param name="duration">Срок обучения в годах</param>
        public StudentDataEventArgs(
            string name,
            string group,
            string speciality,
            double score,
            int duration,
            int? id)
        {
            Name = name;
            Group = group;
            Speciality = speciality;
            AverageScore = score;
            DurationOfStudy = duration;
            this.id = id;
        }
    }
}
