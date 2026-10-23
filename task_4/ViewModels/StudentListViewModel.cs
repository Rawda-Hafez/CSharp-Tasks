using ASS_2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASS_2.ViewModels
{
    public class StudentListViewModel
    {
        public List<Student> Students { get; set; } = new();

        // Search & Filter
        public string? SearchString { get; set; }
        public int? DepartmentId { get; set; }
        public SelectList? DepartmentList { get; set; }

        // Pagination
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 5;
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
    }
}
