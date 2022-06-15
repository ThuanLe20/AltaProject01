using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class TranscriptCF : IEntityTypeConfiguration<Transcript>
    {
        public void Configure(EntityTypeBuilder<Transcript> builder)
        {
            builder.ToTable("Transcript");

            builder.HasKey(x => x.TS_Id);

            builder.Property(x => x.TS_Id).HasMaxLength(5);

            builder.Property(x=>x.TS_Name).IsRequired().HasMaxLength(1000);

            builder.Property(x => x.TS_Point).IsRequired();

            builder.Property(x => x.TS_Total).IsRequired();

            builder.HasMany(x => x.TestPoints).WithOne(x => x.Transcripts).HasForeignKey(x => x.TP_Id);
        }
    }
}
