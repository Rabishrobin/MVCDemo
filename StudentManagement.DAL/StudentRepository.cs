using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAL
{
    public class StudentRepository
    {
        public static List<StudentDetails> student = new List<StudentDetails>();
        static StudentRepository()
        {
            student.Add(new StudentDetails(1613179, "Rabish", "ECE", 8));
            student.Add(new StudentDetails(1613180, "Monisha", "CSE", 8.5));
            student.Add(new StudentDetails(1613179, "Saravanapriya", "IT", 9));
        }
        public IEnumerable<StudentDetails> GetStudentDetails()
        {
            return student;
        }
    }
}
