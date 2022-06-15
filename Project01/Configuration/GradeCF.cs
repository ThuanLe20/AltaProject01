using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class GradeCF : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grade");

            builder.HasKey(x=>x.G_Id);

            builder.Property(x=>x.G_Id).HasMaxLength(5);

            builder.Property(x=>x.G_Name).IsRequired().HasMaxLength(100);

            builder.HasMany(x=>x.Class).WithOne(x=>x.Grade).HasForeignKey(x=>x.G_Id);
        }
    }
}
