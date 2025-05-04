using OOP_Lab7.controller;
using OOP_Lab7.model.service;
using OOP_Lab7.view;
using System.Xml.Linq;

namespace OOP_Lab7
{
    public partial class ViewImpl : Form, IView
    {
        private readonly StudentController _controller;

        public ViewImpl(StudentService model)
        {
            InitializeComponent();
            _controller = new StudentController(model, this);

            // Привязка обработчиков кнопок к методам контроллера
            addStudentButton.Click += (s, e) => _controller.AddStudent();
            removeStudentButton.Click += (s, e) => _controller.RemoveStudent();
            getStudentInfoButton.Click += (s, e) => _controller.GetStudentInfo();
            getAllStudensInfoButton.Click += (s, e) => _controller.GetAllStudentsInfo();
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

    }
}
