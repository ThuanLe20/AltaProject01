using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class TestPointCF : IEntityTypeConfiguration<TestPoint>
    {
        public void Configure(EntityTypeBuilder<TestPoint> builder)
        {
            builder.ToTable("TestPoint");

            builder.HasKey(x=>x.TP_Id);

            builder.Property(x => x.TP_Id).HasMaxLength(5);

            builder.Property(x=> x.TP_Name).IsRequired().HasMaxLength(1000);

            builder.Property(x => x.TP_Point).IsRequired();

            builder.HasOne(x => x.Students).WithMany(x => x.TestPoints).HasForeignKey(x => x.SD_Id);

            builder.HasOne(x=>x.TestDetails).WithOne(x => x.TestPoints).HasForeignKey<TestDetail>(x => x.TD_Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
