using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class PositionCF : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Position");

            builder.HasKey(x=>x.PST_Id);

            builder.Property(x => x.PST_Id).HasMaxLength(5);

            builder.Property(x => x.PST_Name).IsRequired().HasMaxLength(100);

            builder.HasMany(x=>x.Accountt).WithOne(x=>x.Positionn).HasForeignKey(x=>x.PST_Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
