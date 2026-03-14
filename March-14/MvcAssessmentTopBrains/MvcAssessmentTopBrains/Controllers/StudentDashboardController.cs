using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAssessmentTopBrains.Models;
using MvcAssessmentTopBrains.ViewModels;
using System.Linq;

namespace MvcAssessmentTopBrains.Controllers
{
    public class StudentDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Check if student is logged in
            if (HttpContext.Session.GetString("Role") != "Student")
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = int.Parse(HttpContext.Session.GetString("UserId"));
            var user = _context.Users.Find(userId);

            var student = _context.Students.Include(s => s.Department).Include(s => s.Course).FirstOrDefault(s => s.Email == user.Email);

            if (student == null)
            {
                // Student record not found, perhaps redirect to create profile or something
                ViewBag.Message = "Student profile not found.";
                return View();
            }

            var viewModel = new StudentProfileViewModel
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber,
                Address = student.Address,
                DepartmentName = student.Department?.DepartmentName,
                CourseName = student.Course?.CourseName,
                CourseDuration = student.Course?.Duration,
                CourseFees = student.Course?.Fees ?? 0
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Profile()
        {
            if (HttpContext.Session.GetString("Role") != "Student")
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = int.Parse(HttpContext.Session.GetString("UserId"));
            var user = _context.Users.Find(userId);

            var student = _context.Students.FirstOrDefault(s => s.Email == user.Email);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult Profile(Student student)
        {
            if (HttpContext.Session.GetString("Role") != "Student")
            {
                return RedirectToAction("Login", "Account");
            }

            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}