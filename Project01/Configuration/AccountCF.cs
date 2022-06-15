using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Entity;

namespace Project01.Configuration
{
    public class AccountCF : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");

            builder.HasKey(x => x.ACC_Id);

            builder.Property(x => x.ACC_Id).HasMaxLength(5);

            builder.Property(x => x.ACC_Name).IsRequired();

            builder.Property(x => x.ACC_Pw).IsRequired();

        }
    }
}
