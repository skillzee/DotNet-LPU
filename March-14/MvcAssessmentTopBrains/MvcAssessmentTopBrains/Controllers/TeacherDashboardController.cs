using Microsoft.AspNetCore.Mvc;
using MvcAssessmentTopBrains.Models;

namespace MvcAssessmentTopBrains.Controllers
{
    public class TeacherDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Check if teacher is logged in
            if (HttpContext.Session.GetString("Role") != "Teacher")
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.FullName = HttpContext.Session.GetString("FullName");
            return View();
        }
    }
}