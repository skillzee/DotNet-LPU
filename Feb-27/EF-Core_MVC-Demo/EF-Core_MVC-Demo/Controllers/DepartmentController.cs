using EF_Core_MVC_Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_MVC_Demo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: DepartmentController
        public ActionResult Index()
        {
            LPUTrialDbdbContext dbcon = new LPUTrialDbdbContext();
            var res = dbcon.Departments.ToList();
            return View(res);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
