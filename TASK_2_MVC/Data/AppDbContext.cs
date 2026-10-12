
using ASS_2.Models;
using Microsoft.EntityFrameworkCore;

namespace ASS_2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Composite Primary Key for StuCrsRes
            modelBuilder.Entity<StuCrsRes>()
                .HasKey(x => new { x.StudentId, x.CourseId });

            // 2. Break multiple cascade paths between Teachers, Courses, and Departments
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Course)
                .WithMany(c => c.Teachers)
                .HasForeignKey(t => t.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            // 3. Break multiple cascade paths between StuCrsRes, Courses, and Departments
            modelBuilder.Entity<StuCrsRes>()
                .HasOne(s => s.Course)
                .WithMany(c => c.StuCrsRes)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
