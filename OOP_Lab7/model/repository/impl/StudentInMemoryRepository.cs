using OOP_Lab7.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7.model.repository.impl
{
    /// <summary>
    /// Класс для хранения объектов сущностей типа Student с помощью контейнера List (in-memory)
    /// </summary>
    public class StudentInMemoryRepository : IStudentRepository
    {
        private readonly List<Student> _storage = new List<Student>();

       
        public void AddStudent(Student student) {
            _storage.Add(student);
        }

       
        public Student? GetStudentById(int id) {
            return _storage.Where(s => s.Id == id).FirstOrDefault();
        }


        public List<Student> GetAllStudents() {
            return _storage;
        }

        public bool RemoveStudentById(int id) {
            return _storage.RemoveAll(x => x.Id == id) == 1;
        }
    }
}
