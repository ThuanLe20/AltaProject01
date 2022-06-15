using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class SubjectCF : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subject");

            builder.HasKey(x=>x.SJ_Id);

            builder.Property(x => x.SJ_Id).HasMaxLength(5);

            builder.Property(x => x.SJ_Name).IsRequired().HasMaxLength(1000);

            builder.Property(x =>x.SJ_Lesson).IsRequired();

        }
    }
}
