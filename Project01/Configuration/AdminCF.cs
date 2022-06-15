using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class AdminCF : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admin");

            builder.HasKey(x => x.AD_Id);

            builder.Property(x => x.AD_Id).HasMaxLength(5);

            builder.Property(x => x.AD_FName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.AD_LName).IsRequired().HasMaxLength(100);

            builder.Property(x => x.AD_Email).IsRequired().IsUnicode(false).HasMaxLength(100);

            builder.Property(x => x.AD_Phone).IsRequired().HasMaxLength(11);

            builder.Property(x => x.AD_Address).IsRequired().HasMaxLength(1000);

            builder.HasOne<Account>(x=>x.Account)
                .WithOne(x=>x.Admin)
                .HasForeignKey<Account>(x=>x.ACC_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
