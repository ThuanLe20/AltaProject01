using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class CourseCF : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            
            builder.HasKey(x=>x.CR_Id);

            builder.Property(x=>x.CR_Id).HasMaxLength(5);

            builder.Property(x=>x.CR_Name).IsRequired().HasMaxLength(200);

            builder.Property(x=>x.CR_Link).IsRequired().HasMaxLength(1000);

            builder.Property(x => x.CR_Status).IsRequired().HasDefaultValue(1);

            builder.HasOne(x => x.Subjectt).WithMany(x => x.Course).HasForeignKey(x => x.SJ_Id);

        }
    }
}
