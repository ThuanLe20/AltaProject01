using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class SchoolYearCF : IEntityTypeConfiguration<SchoolYear>
    {
        public void Configure(EntityTypeBuilder<SchoolYear> builder)
        {
            builder.ToTable("SchoolYear");

            builder.HasKey(x => x.SY_Id);

            builder.Property(x=>x.SY_Id).HasMaxLength(5);

            builder.Property(x=>x.SY_Year).IsRequired().HasMaxLength(10);

            builder.HasOne(x => x.Class).WithOne(x => x.SchoolYear).HasForeignKey<SchoolYear>(x => x.C_Id);

            builder.HasMany(x=>x.Semesters).WithOne(x=>x.SchoolYears).HasForeignKey(x => x.SMT_Id);
        }
    }
}
