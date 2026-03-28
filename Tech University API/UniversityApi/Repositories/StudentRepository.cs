using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class StudentRepository(UniversityContext db) : IStudent
    {
        // Implement your code here  
        public bool DeleteStudent(int studentId)
        {
            var exist = db.Students.FirstOrDefault(s => s.StudentId == studentId);
            if (exist != null)
            {
                db.Students.Remove(exist);
                db.SaveChanges();
                return true;
            }

            return false;

        }

        public IEnumerable<Student> GetStudentsByCourseTitle(string courseTitle)
        {
            return db.Students.Where(c=> c.Enrollments.Any(e=> e.Course.Title == courseTitle)).ToList();
        }
    }
}
