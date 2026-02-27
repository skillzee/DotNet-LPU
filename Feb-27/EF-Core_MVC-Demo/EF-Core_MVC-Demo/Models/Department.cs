using System.ComponentModel.DataAnnotations;

namespace EF_Core_MVC_Demo.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        [Required(ErrorMessage ="Name is mandatory")]
        public string DeptName { get; set; }
        [Required]
        public string DeptLocation { get; set; }

        //One to many relation in department to employees
        public ICollection<Employee> Employees { get; set; }
    }
}
