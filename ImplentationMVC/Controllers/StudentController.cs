using StudentManagement.DAL;
using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImplentationMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentRepository student;
        public StudentController()
        {
            student = new StudentRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<StudentDetails> students = student.GetStudentDetails();
            return View(students);
        }
        public ActionResult DataPassing()
        {
            IEnumerable<StudentDetails> students = student.GetStudentDetails();
            ViewBag.student = students;
            ViewData["students"] = students;
            return View();
        }
        public ActionResult TempDataChecking()
        {
            IEnumerable<StudentDetails> students = student.GetStudentDetails();
            TempData["students"] = students;
            return View();
        }
    }
}