using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7.model.entity
{
    /// <summary>
    /// Класс, определяющий сущность "Студент" в системе 
    /// </summary>
    public class Student
    {
        private static int AUTO_INCREMENT_ID = 0;
        /// <summary>
        /// Уникальный идентификатор студента
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Имя студента
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Группа студента
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Специальность студента
        /// </summary>
        public string Speciality { get; set; }
    
        /// <summary>
        /// Средняя оценка
        /// </summary>
        public double AverageScore { get; set; }

        /// <summary>
        /// Количество лет обучения
        /// </summary>
        public int DurationOfStudy { get; set; }

        public Student(
            string? name, 
            string? group, 
            string? speciality, 
            double? averageScore,
            int? durationOfStudy)
        {
            Id = ++AUTO_INCREMENT_ID;
            Name = (string.IsNullOrEmpty(name) ? "Неизвестно" : name);
            Group = (string.IsNullOrEmpty(group) ? "Неизвестно" : group);
            Speciality = (string.IsNullOrEmpty(speciality) ? "Неизвестно" : speciality);
            AverageScore = averageScore ?? 0.0;
            DurationOfStudy = durationOfStudy ?? 0;
        }

        public override string ToString()
        {
            return $"""
                Студент {Name} (id: {Id}), группа {Group}
                Обучается по специальности {Speciality} (срок обучения (лет): {DurationOfStudy})
                Средний балл: {AverageScore}
                """;
        }
    }
}
