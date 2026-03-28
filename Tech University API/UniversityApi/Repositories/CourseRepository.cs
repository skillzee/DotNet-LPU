using Microsoft.AspNetCore.Mvc;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class CourseRepository(UniversityContext db) : ICourse
    {
        public IEnumerable<Course> GetCoursesByInstructorName(string instructorName)
        {
            return db.Courses.Where(c => c.InstructorCourses.Any(i => i.Instructor.Name == instructorName)).ToList();


        }

        public IEnumerable<Course> GetCoursesWithEnrollmentsAboveGrade(int grade)
        {

            return db.Courses.Where(c => c.Enrollments.Any(c => c.Grade == grade)).ToList();


        }

        public bool UpdateCourse(Course course)
        {
            int id = course.CourseId;
            var foundCourse = db.Courses.FirstOrDefault(c => c.CourseId == id);
            if (foundCourse != null)
            {
          
                foundCourse.Title = course.Title;
                db.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
