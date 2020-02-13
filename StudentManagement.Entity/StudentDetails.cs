using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class StudentDetails
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentDept  { get; set; }
        public double StudentCGPA { get; set; }
        public StudentDetails(int studentId, string studentName, string studentDept, double studentCGPA)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentDept = studentDept;
            StudentCGPA = studentCGPA;
        }
    }
}
