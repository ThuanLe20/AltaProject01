using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class StudentCF : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");

            builder.HasKey(x=>x.S_Id);

            builder.Property(x => x.S_Id).HasMaxLength(5);

            builder.Property(x => x.S_FName).IsRequired().HasMaxLength(100);

            builder.Property(x=>x.S_LName).IsRequired().HasMaxLength(100);

            builder.Property(x=>x.S_Phone).IsRequired().HasMaxLength(11);

            builder.Property(x=>x.S_Email).IsRequired().IsUnicode(false).HasMaxLength(100);

            builder.Property(x=>x.S_Address).IsRequired().HasMaxLength(1000);

            builder.HasOne(x => x.Accountt).WithOne(x => x.Student).HasForeignKey<Account>(x => x.ACC_Id);
        }
    }
}
