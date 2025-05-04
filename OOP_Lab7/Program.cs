using OOP_Lab7.model.repository.impl;
using OOP_Lab7.model.service;
using OOP_Lab7.controller;

namespace OOP_Lab7
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var repository = new StudentInMemoryRepository();
            var service = new StudentService(repository);
            var view = new ViewImpl(service);
            var controller = new StudentController(service, view);

            Application.Run(view);
        }
    }
}