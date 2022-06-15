using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class SemesterCF : IEntityTypeConfiguration<Semester>
    {
        public void Configure(EntityTypeBuilder<Semester> builder)
        {
            builder.ToTable("Semester");

            builder.HasKey(x=>x.SMT_Id);

            builder.Property(x => x.SMT_Id).HasMaxLength(5);

            builder.Property(x=>x.SMT_Name).IsRequired().HasMaxLength(50);


        }
    }
}
