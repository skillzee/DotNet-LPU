using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class InstructorRepository(UniversityContext db) : IInstructor
    {
        // Implement your code here  
        public bool AddInstructor(Instructor instructor)
        {
            var exists = db.Instructors
                   .Any(i => i.Name == instructor.Name);

            if (exists)
            {
                return false;
            }

            db.Instructors.Add(instructor);
            db.SaveChanges();

            return true;
        }

        public IEnumerable<Instructor> GetInstructorsWithCourseCountAbove(int count)
        {
            return db.Instructors.Where(c => c.InstructorCourses.Count() > count).ToList();
        }

        public IEnumerable<Instructor> GetInstructorsWithMostEnrollments()
        {
            var instructorWithCounts = db.Instructors
                .Select(i => new
                {
                    Instructor = i,
                    EnrollmentCount = i.InstructorCourses
                                       .SelectMany(ic => ic.Course.Enrollments)
                                       .Count()
                })
                .ToList();

            var maxCount = instructorWithCounts.Max(i => i.EnrollmentCount);

            return instructorWithCounts
                    .Where(i => i.EnrollmentCount == maxCount)
                    .Select(i => i.Instructor);
        }
    }
}
