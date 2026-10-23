using ASS_2.Models;

namespace ASS_2.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Students.Any())
            {
                return; // DB has been seeded already
            }

            var csDept = new Department { Name = "Computer Science", MgrName = "Dr. Ahmed Hassan" };
            var isDept = new Department { Name = "Information Systems", MgrName = "Dr. Sara Adel" };

            context.Departments.AddRange(csDept, isDept);
            context.SaveChanges();

            var csharpCourse = new Course { Name = "C# Programming", Degree = 100, MinDegree = 50, DepartmentId = csDept.Id };
            var mvcCourse = new Course { Name = "ASP.NET Core MVC", Degree = 100, MinDegree = 60, DepartmentId = csDept.Id };
            var dbCourse = new Course { Name = "Database Systems", Degree = 100, MinDegree = 50, DepartmentId = isDept.Id };

            context.Courses.AddRange(csharpCourse, mvcCourse, dbCourse);
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
                new Teacher { Name = "Eng. Tarek Yasser", Salary = 15000, Address = "Cairo", CourseId = csharpCourse.Id, DepartmentId = csDept.Id },
                new Teacher { Name = "Eng. Mostafa Nabil", Salary = 16000, Address = "Giza", CourseId = mvcCourse.Id, DepartmentId = csDept.Id }
            };
            context.Teachers.AddRange(teachers);

            var s1 = new Student { Name = "Ali Mohamed", Age = 21, DepartmentId = csDept.Id };
            var s2 = new Student { Name = "Mona Mahmoud", Age = 22, DepartmentId = isDept.Id };
            var s3 = new Student { Name = "Omar Khaled", Age = 20, DepartmentId = csDept.Id };
            var s4 = new Student { Name = "Hassan Ibrahim", Age = 27, DepartmentId = csDept.Id };
            var s5 = new Student { Name = "Nouran Ahmed", Age = 26, DepartmentId = csDept.Id };

            context.Students.AddRange(s1, s2, s3, s4, s5);
            context.SaveChanges();

            var results = new List<StuCrsRes>
            {
                new StuCrsRes { StudentId = s1.Id, CourseId = csharpCourse.Id, Grade = 88 },
                new StuCrsRes { StudentId = s2.Id, CourseId = dbCourse.Id, Grade = 92 },
                new StuCrsRes { StudentId = s3.Id, CourseId = csharpCourse.Id, Grade = 95 },
                new StuCrsRes { StudentId = s3.Id, CourseId = mvcCourse.Id, Grade = 90 },
                new StuCrsRes { StudentId = s4.Id, CourseId = csharpCourse.Id, Grade = 85 },
                new StuCrsRes { StudentId = s5.Id, CourseId = mvcCourse.Id, Grade = 91 }
            };
            context.StuCrsRes.AddRange(results);
            context.SaveChanges();
        }
    }
}
