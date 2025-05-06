using OOP_Lab7.controller;
using OOP_Lab7.model.entity;
using OOP_Lab7.model.service;
using OOP_Lab7.view;
using System.Xml.Linq;
using static OOP_Lab7.model.repository.impl.StudentInMemoryRepository;

namespace OOP_Lab7
{
    public partial class ViewImpl : Form, IView
    {
        private IStudentService _studentService;

        private StudentService.StudentAddedEventHandler _studentAddedHandler;
        private StudentService.StudentRemovedEventHandler _studentRemovedHandler;
        private StudentService.StudentNotFoundEventHandler _studentNotFoundHandler;

        public event EventHandler<StudentDataEventArgs> AddStudentRequested;
        public event EventHandler<int> RemoveStudentRequested;
        public event EventHandler<int> GetStudentInfoRequested;
        public event EventHandler<EventArgs> GetAllStudentsRequested;



        public ViewImpl(StudentService model)
        {
            InitializeComponent();
            _studentService = model;

            _studentAddedHandler = (sender, e) => { ShowMessage("Добавлен студент с id: " + e.id); };
            _studentRemovedHandler = (sender, e) => { ShowMessage("Удален студент с id: " + e.id); };
            _studentNotFoundHandler = (sender, e) => { ShowMessage($"Студент с id {e} не найден!" ); };

            _studentService.StudentAdded += _studentAddedHandler;
            _studentService.StudentRemoved += _studentRemovedHandler;
            _studentService.StudentNotFound += _studentNotFoundHandler;


        }




        // Реализация методов IView
        public string GetStudentName() => studentNameTextBox.Text;
        public string GetGroup() => studentGroupTextBox.Text;
        public string GetSpeciality() => studentSpecialityTextBox.Text;
        public double GetAverageScore() => (double)averageScoreNumericUpDown.Value;
        public int GetDurationOfStudy() => (int)durationOfStudyNumericUpDown.Value;
        public int GetSelectedId() => (int)studentIdNumericUpDown.Value;

        public void ShowMessage(string message)
        {
            logsRichTextBox.AppendText($"{message}\n\n");
        }


        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var args = new StudentDataEventArgs(studentNameTextBox.Text, studentGroupTextBox.Text,
                studentSpecialityTextBox.Text, (double)averageScoreNumericUpDown.Value,
                (int)durationOfStudyNumericUpDown.Value, null);
            AddStudentRequested?.Invoke(this, args);
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {

            RemoveStudentRequested?.Invoke(this, (int)studentIdNumericUpDown.Value);
        }

        private void getStudentInfoButton_Click(object sender, EventArgs e)
        {
            GetStudentInfoRequested?.Invoke(this, (int)studentIdNumericUpDown.Value);

        }

        private void getAllStudensInfoButton_Click(object sender, EventArgs e)
        {
            GetAllStudentsRequested?.Invoke(this, e);
        }
    }
}
