using System.ComponentModel.DataAnnotations;

namespace MvcAssessmentTopBrains.ViewModels
{
    public class StudentProfileViewModel
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

        public string DepartmentName { get; set; }

        public string CourseName { get; set; }

        public string CourseDuration { get; set; }

        public decimal CourseFees { get; set; }
    }
}