using System.ComponentModel.DataAnnotations;

namespace MvcAssessmentTopBrains.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Fees { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
