
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {


        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo. SeedProjects();

            Console.WriteLine("LINQ Scenario Boilerplate Loaded");
            List<Employee> highestEarning = GetHighEarningEmployees(employees);

            Console.WriteLine("********************Highest Earning*******************");
            foreach(var item in highestEarning)
            {
                Console.WriteLine($"Name: {item.Name} with salary: {item.Salary}");
            }

            //Console.WriteLine();
            //Console.WriteLine();
            //List<string> employeeNames = GetEmployeeNames(employees);
            //Console.WriteLine("********************Employee Names*******************");
            //foreach (var name in employeeNames)
            //{
            //    Console.WriteLine($"Employee Name: {name}");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //bool hasHR = HasHREmployees(employees);
            //Console.WriteLine("********************Has HR Employees?*******************");
            //Console.WriteLine($"Has HR Employees: {hasHR}");



            //Console.WriteLine();
            //Console.WriteLine();
            //List<DepartmentCount> deptCounts = GetDepartmentWiseCount(employees);
            //Console.WriteLine("********************Department Wise Count*******************");
            //foreach (var dept in deptCounts)
            //{
            //    Console.WriteLine($"Department: {dept.Department} has {dept.Count} employees");
            //}


            //Console.WriteLine();
            //Console.WriteLine();


            //Employee highestPaidEmployee = GetHighestPaidEmployee(employees);
            //Console.WriteLine("********************Highest Paid Employee*******************");
            //Console.WriteLine($"Highest Paid Employee: {highestPaidEmployee.Name} with salary: {highestPaidEmployee.Salary}");

            //Console.WriteLine();
            //Console.WriteLine();

            //List<Employee> sortedEmployees = SortEmployeesBySalaryAndName(employees);
            //Console.WriteLine("********************Sorted Employees by Salary and Name*******************");
            //foreach (var emp in sortedEmployees)
            //{
            //    Console.WriteLine($"Employee: {emp.Name} with salary: {emp.Salary}");
            //}



            //Console.WriteLine();
            //Console.WriteLine();

            //List<EmployeeProject> empProjMappings = GetEmployeeProjectMappings(employees, projects);
            //Console.WriteLine("********************Employee Project Mappings*******************");
            //foreach (var mapping in empProjMappings)
            //{
            //    Console.WriteLine($"Employee: {mapping.EmployeeName} is working on Project: {mapping.ProjectName}");
            //}


            //Console.WriteLine();
            //Console.WriteLine();
            //List<Employee> unassignedEmployees = GetUnassignedEmployees(employees, projects);
            //Console.WriteLine("********************Unassigned Employees*******************");
            //foreach (var emp in unassignedEmployees)
            //{
            //    Console.WriteLine($"Unassigned Employee: {emp.Name}");
            //}


            //Console.WriteLine();
            //Console.WriteLine();

            //List<string> uniqueSkills = GetAllUniqueSkills(employees);
            //Console.WriteLine("********************Unique Skills in Organization*******************");
            //foreach (var skill in uniqueSkills)
            //{
            //    Console.WriteLine($"Skill: {skill}");
            //}



            Console.WriteLine();
        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var highEarningEmployees = employees.Where(x => x.Salary >= 60000);

            return highEarningEmployees.ToList();

        }

        // TODO 1.2: Get list of employee names only
        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            // TODO: Write LINQ query here

            var employeeNames = employees.Select(x => x.Name);
            return employeeNames.ToList();
        }

        // TODO 1.3: Check if any employee belongs to HR department
        static bool HasHREmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var IsHREmployee = employees.Select(x => x.Department == "HR");
            return IsHREmployee.Any();


        }

        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        // TODO 2.1: Get department-wise employee count
        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var result = from emp in employees
                         group emp by emp.Department into deptGroup
                         select new DepartmentCount
                         {
                             Department = deptGroup.Key,
                             Count = deptGroup.Count()
                         };

            return result.ToList();




            //throw new NotImplementedException();
        }

        // TODO 2.2: Find the highest paid employee
        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var HighestPaid =( from emp in employees
                             orderby emp.Salary descending 
                             select emp).FirstOrDefault();

            return HighestPaid;


            //throw new NotImplementedException();
        }

        // TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var sortedEmployees = from emp in employees
                                  orderby emp.Salary descending, emp.Name ascending
                                  select emp;

            return sortedEmployees.ToList();

        }

        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        // TODO 3.1: Join employees with projects
        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
        {

            var result = from emp in employees
                         join proj in projects
                         on emp.Id equals proj.EmployeeId
                         select new EmployeeProject
                            {
                                EmployeeName = emp.Name,
                                ProjectName = proj.ProjectName
                            };
             
            return result.ToList();
           
        }

        // TODO 3.2: Find employees who are NOT assigned to any project
        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
        {
            var EmployeesNotAssigned = from emp in employees
                                       where !(from proj in projects
                                               select proj.EmployeeId).Contains(emp.Id)
                                       select emp;

            return EmployeesNotAssigned.ToList();


        }

        // TODO 3.3: Get all unique skills across the organization
        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var uniqueSkills = (from emp in employees
                                from skill in emp.Skills
                                select skill).Distinct();
            return uniqueSkills.ToList();

        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        // TODO 4.1: Get top 3 highest-paid employees per department
        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 4.2: Remove duplicate employees based on Id
        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var employee = (from emp in employees
                            select emp).Distinct();

            return employee.ToList();
  
        }

        // TODO 4.3: Implement pagination
        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }


    }
}
