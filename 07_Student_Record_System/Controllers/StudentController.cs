using _07_Student_Record_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07_Student_Record_System.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentInfo()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    StudentId = 1,
                    StudentName = "Dhiraj Padhiyar",
                    Age = 22,
                    Course = "Computer Science",
                    Email="dhiraj@example.com"
                },
                new Student()
                {
                    StudentId = 2,
                    StudentName = "John Doe",
                    Age = 20,
                    Course = "Commerce",
                    Email="john@example.com"
                },
                new Student()
                {
                    StudentId = 3,
                    StudentName = "Jane Smith",
                    Age = 21,
                    Course = "Engineering",
                    Email="jane@example.com"
                }
            };
            return View(students);
        }
    }
}
