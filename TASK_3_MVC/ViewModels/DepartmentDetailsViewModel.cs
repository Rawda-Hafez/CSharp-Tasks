using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASS_2.ViewModels
{
    public class DepartmentDetailsViewModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string ManagerName { get; set; } = string.Empty;

        // Total count of students in this department
        public int StudentCount { get; set; }

        // State: "Main" if count > 50, otherwise "branch"
        public string DepartmentState { get; set; } = string.Empty;

        // Students whose age exceeds 25 years
        public List<SelectListItem> StudentsAbove25 { get; set; } = new();
    }
}
