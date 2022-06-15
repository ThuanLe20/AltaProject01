using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class TestCategoryCF : IEntityTypeConfiguration<TestCategory>
    {
        public void Configure(EntityTypeBuilder<TestCategory> builder)
        {
            builder.ToTable("TestCaterogy");

            builder.HasKey(x => x.TC_Id);

            builder.Property(x=>x.TC_Id).HasMaxLength(5);

            builder.Property(x=>x.TC_Name).IsRequired().HasMaxLength(1000);
        }
    }
}
