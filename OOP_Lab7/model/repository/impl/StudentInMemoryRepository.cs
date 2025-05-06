using OOP_Lab7.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Lab7.view;

namespace OOP_Lab7.model.repository.impl
{
    /// <summary>
    /// Класс для хранения объектов сущностей типа Student с помощью контейнера List (in-memory)
    /// </summary>
    public class StudentInMemoryRepository : IStudentRepository
    {
        public List<Student> Storage = new List<Student>();

        
        public void AddStudent(Student student) {
            Storage.Add(student);
         
        }

       
        public Student? GetStudentById(int id) {
            return Storage.Where(s => s.Id == id).FirstOrDefault();
        }


        public List<Student> GetAllStudents() {
            return Storage;
        }

        public bool RemoveStudentById(int id) {
            return Storage.RemoveAll(x => x.Id == id) == 1;

        }

        
    }
}
