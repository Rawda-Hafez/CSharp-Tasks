using ASS_2.Data;
using ASS_2.Models;
using ASS_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ASS_2.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Department/ShowAll
        public IActionResult ShowAll()
        {
            var departments = _context.Departments
                .Include(d => d.Students)
                .ToList();

            return View(departments);
        }

        // GET: /Department/ShowDetails?id=1 or /Department/ShowDetails/1
        public IActionResult ShowDetails(int id)
        {
            var department = _context.Departments
                .Include(d => d.Students)
                .FirstOrDefault(d => d.Id == id);

            if (department == null)
            {
                return NotFound($"Department with ID = {id} was not found.");
            }

            var totalStudents = department.Students.Count;

            // ViewModel mapping
            var viewModel = new DepartmentDetailsViewModel
            {
                DepartmentId = department.Id,
                DepartmentName = department.Name,
                ManagerName = department.MgrName,
                StudentCount = totalStudents,
                // Main if > 50, branch if < 50
                DepartmentState = totalStudents > 50 ? "Main" : "branch",
                // Students exceeding 25 years
                StudentsAbove25 = department.Students
                    .Where(s => s.Age > 25)
                    .Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = $"{s.Name} - (Age: {s.Age})"
                    })
                    .ToList()
            };

            return View(viewModel);
        }

        // GET: /Department/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Department/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return RedirectToAction(nameof(ShowAll));
            }

            return View(department);
        }
    }
}
