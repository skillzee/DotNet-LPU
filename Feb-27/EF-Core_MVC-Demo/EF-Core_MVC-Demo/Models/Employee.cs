using System.ComponentModel.DataAnnotations;

namespace EF_Core_MVC_Demo.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public string Address { get; set; }
        public int DeptID { get; set; }

        //Navigation Property
        public virtual Department Department { get; set; }
    }
}
