using OOP_Lab7.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7.model.service
{

    /// <summary>
    /// Интерфейс для создания моков в тестах
    /// </summary>
    public interface IStudentService
    {
        void AddStudent(Student student);
        bool RemoveStudent(int id);
        string GetStudentInfo(int id);
        string GetAllStudentsInfo();
    }
}
