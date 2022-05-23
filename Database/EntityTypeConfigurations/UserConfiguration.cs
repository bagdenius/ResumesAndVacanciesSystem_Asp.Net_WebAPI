using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.EntityTypeConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);
            builder.HasIndex(user => user.Id).IsUnique();
            builder.HasMany(user => user.Resumes)
                .WithOne(resume => resume.User)
                .HasForeignKey(resume => resume.UserId)
                .IsRequired();
            builder.HasMany(user => user.Vacancies)
                .WithOne(vacancy => vacancy.User)
                .HasForeignKey(vacancy => vacancy.UserId)
                .IsRequired();
        }
    }
}
