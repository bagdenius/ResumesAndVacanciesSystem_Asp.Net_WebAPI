using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.EntityTypeConfigurations
{
    public class VacancyConfiguration : IEntityTypeConfiguration<VacancyEntity>
    {
        public void Configure(EntityTypeBuilder<VacancyEntity> builder)
        {
            builder.HasKey(vacancy => vacancy.Id);
            builder.HasIndex(vacancy => vacancy.Id).IsUnique();
        }
    }
}
