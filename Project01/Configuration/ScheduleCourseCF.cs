using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class ScheduleCourseCF : IEntityTypeConfiguration<ScheduleCourse>
    {
        public void Configure(EntityTypeBuilder<ScheduleCourse> builder)
        {
            builder.ToTable("ScheduleCourse");

            builder.HasKey(x => x.SC_Id);

            builder.HasOne(x => x.Courses).WithMany(x=>x.ScheduleCourses).HasForeignKey(x=>x.CR_Id).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Schedules).WithMany(x => x.ScheduleCourses).HasForeignKey(x => x.SD_Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
