using Microsoft.EntityFrameworkCore;
using Project01.Configuration;
using Project01.Entity;

namespace Project01.EF
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountCF());
            modelBuilder.ApplyConfiguration(new AdminCF());
            modelBuilder.ApplyConfiguration(new ClassCF());
            modelBuilder.ApplyConfiguration(new CourseCF());
            modelBuilder.ApplyConfiguration(new DocumentCF());
            modelBuilder.ApplyConfiguration(new GradeCF());
            modelBuilder.ApplyConfiguration(new PositionCF());
            modelBuilder.ApplyConfiguration(new ScheduleCF());
            modelBuilder.ApplyConfiguration(new SchoolYearCF());
            modelBuilder.ApplyConfiguration(new SemesterCF());
            modelBuilder.ApplyConfiguration(new StudentCF());
            modelBuilder.ApplyConfiguration(new SubjectCF());
            modelBuilder.ApplyConfiguration(new TestCategoryCF());
            modelBuilder.ApplyConfiguration(new TestDetailCF());
            modelBuilder.ApplyConfiguration(new TestCF());
            modelBuilder.ApplyConfiguration(new TestPointCF());
            modelBuilder.ApplyConfiguration(new TranscriptCF());
            modelBuilder.ApplyConfiguration(new ScheduleCourseCF());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestCategory> TestCategories { get; set; }
        public DbSet<TestDetail> TestDetails { get; set; }
        public DbSet<TestPoint> TestPoints { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
        
        public DbSet<ScheduleCourse> ScheduleCourses { get; set; }
    }
   
}
