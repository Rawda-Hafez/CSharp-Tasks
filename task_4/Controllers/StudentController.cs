using ASS_2.Data;
using ASS_2.Models;
using ASS_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ASS_2.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Student/GetAll or /Student/ShowAll
        public IActionResult GetAll(string? searchString, int? departmentId, int page = 1, int pageSize = 5)
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 5;

            var query = _context.Students
                .Include(s => s.Department)
                .AsQueryable();

            // 1. Search by student name
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                query = query.Where(s => s.Name.Contains(searchString.Trim()));
            }

            // 2. Filter by Department
            if (departmentId.HasValue && departmentId.Value > 0)
            {
                query = query.Where(s => s.DepartmentId == departmentId.Value);
            }

            // 3. Pagination calculation
            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            if (totalPages == 0) totalPages = 1;
            if (page > totalPages) page = totalPages;

            var students = query
                .OrderBy(s => s.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var departments = _context.Departments.OrderBy(d => d.Name).ToList();

            var viewModel = new StudentListViewModel
            {
                Students = students,
                SearchString = searchString,
                DepartmentId = departmentId,
                DepartmentList = new SelectList(departments, "Id", "Name", departmentId),
                CurrentPage = page,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = totalPages
            };

            return View(viewModel);
        }

        // Backward compatibility for previous tasks
        public IActionResult ShowAll(string? searchString, int? departmentId, int page = 1)
        {
            return RedirectToAction(nameof(GetAll), new { searchString, departmentId, page });
        }

        // GET: /Student/GetById?id=1 or /Student/GetById/1
        public IActionResult GetById(int id)
        {
            var student = _context.Students
                .Include(s => s.Department)
                .Include(s => s.StuCrsRes)
                    .ThenInclude(sc => sc.Course)
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound($"Student with ID = {id} was not found.");
            }

            return View(student);
        }

        // Alias for previous task
        public IActionResult ShowDetails(int id)
        {
            return RedirectToAction(nameof(GetById), new { id });
        }

        // GET: /Student/Add
        [HttpGet]
        public IActionResult Add()
        {
            PopulateDepartmentsDropDownList();
            return View();
        }

        // POST: /Student/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Student student)
        {
            ModelState.Remove(nameof(student.Department));

            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(GetAll));
            }

            PopulateDepartmentsDropDownList(student.DepartmentId);
            return View(student);
        }

        // GET: /Student/Edit/5 or /Student/Edit?id=5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound($"Student with ID = {id} was not found.");
            }

            PopulateDepartmentsDropDownList(student.DepartmentId);
            return View(student);
        }

        // POST: /Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest("ID mismatch.");
            }

            ModelState.Remove(nameof(student.Department));

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Students.Update(student);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(GetAll));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Students.Any(s => s.Id == student.Id))
                    {
                        return NotFound();
                    }
                    throw;
                }
            }

            PopulateDepartmentsDropDownList(student.DepartmentId);
            return View(student);
        }

        // GET: /Student/Delete/5 (Warning View)
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _context.Students
                .Include(s => s.Department)
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound($"Student with ID = {id} was not found.");
            }

            return View(student); // Returns warning view
        }

        // POST: /Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students
                .Include(s => s.StuCrsRes)
                .FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                // Remove enrollments if any to maintain referential integrity
                if (student.StuCrsRes != null && student.StuCrsRes.Any())
                {
                    _context.StuCrsRes.RemoveRange(student.StuCrsRes);
                }

                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(GetAll));
        }

        private void PopulateDepartmentsDropDownList(object? selectedDepartment = null)
        {
            var departments = _context.Departments
                .OrderBy(d => d.Name)
                .ToList();

            ViewBag.DepartmentId = new SelectList(departments, "Id", "Name", selectedDepartment);
        }
    }
}
