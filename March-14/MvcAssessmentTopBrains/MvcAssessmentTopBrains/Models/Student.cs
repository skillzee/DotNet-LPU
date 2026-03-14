using System.ComponentModel.DataAnnotations;

namespace MvcAssessmentTopBrains.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        public Department Department { get; set; }

        public Course Course { get; set; }
    }
}
