using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class TestDetailCF : IEntityTypeConfiguration<TestDetail>
    {
        public void Configure(EntityTypeBuilder<TestDetail> builder)
        {
            builder.ToTable("TestDetail");

            builder.HasKey(x => x.TD_Id);

            builder.Property(x => x.TD_Id).HasMaxLength(5);

            builder.Property(x => x.TD_Time).IsRequired();

            builder.HasOne(x => x.Class).WithMany(x => x.TestDetails).HasForeignKey(x => x.C_Id);

            builder.HasOne(x => x.Test).WithMany(x => x.TestDetails).HasForeignKey(x => x.T_Id);
        }
    }
}
