using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class ClassCF : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class");

            builder.HasKey(x => x.C_Id);

            builder.Property(x =>x.C_Id).HasMaxLength(5);

            builder.Property(x =>x.C_Name).IsRequired().HasMaxLength(200);

            builder.HasMany(x => x.Students).WithOne(x => x.Class).HasForeignKey(x => x.C_Id);

        }
    }
}
