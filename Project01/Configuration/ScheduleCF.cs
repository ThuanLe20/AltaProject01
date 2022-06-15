using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class ScheduleCF : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("Schedule");

            builder.HasKey(x=>x.SD_Id);

            builder.Property(x => x.SD_Id).HasMaxLength(5);

            builder.Property(x => x.SD_Name).IsRequired();

            builder.Property(x => x.SD_Status).HasDefaultValue(1);

            builder.HasOne(x=>x.Class).WithOne(x=>x.Schedule).HasForeignKey<Class>(x=>x.C_Id);
        }
    }
}
