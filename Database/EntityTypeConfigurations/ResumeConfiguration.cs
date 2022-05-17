using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.EntityTypeConfigurations
{
    public class ResumeConfiguration : IEntityTypeConfiguration<ResumeEntity>
    {
        public void Configure(EntityTypeBuilder<ResumeEntity> builder)
        {
            builder.HasKey(resume => resume.Id);
            builder.HasIndex(resume => resume.Id).IsUnique();
        }
    }
}
