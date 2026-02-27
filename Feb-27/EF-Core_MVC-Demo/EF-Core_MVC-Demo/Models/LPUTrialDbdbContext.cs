using Microsoft.EntityFrameworkCore;

namespace EF_Core_MVC_Demo.Models
{
    public class LPUTrialDbdbContext: DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\sqlexpress;Initial Catalog=lpu-trial-db-asp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


    }
}
