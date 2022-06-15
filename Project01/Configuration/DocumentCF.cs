using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class DocumentCF : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Document");

            builder.HasKey(x => x.D_Id);

            builder.Property(x => x.D_Id).HasMaxLength(5);

            builder.Property(x =>x.D_Name).IsRequired().HasMaxLength(1000);

            builder.HasOne(x => x.Subjectt).WithMany(x => x.Documents).HasForeignKey(x => x.SJ_Id);
        }
    }
}
