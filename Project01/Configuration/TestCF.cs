using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class TestCF : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("Test");

            builder.HasKey(x=>x.T_Id);

            builder.Property(x => x.T_Id).HasMaxLength(5);

            builder.Property(x=>x.T_Name).IsRequired().HasMaxLength(1000);

            builder.HasOne(x => x.TestCategoryy).WithMany(x => x.Tests).HasForeignKey(x => x.TC_Id).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Subjectt).WithMany(x => x.Tests).HasForeignKey(x => x.SJ_Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
