using DN.EnglishSchool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DN.EnglishSchool.Infra.Data.Mappings
{
    public class SchoolClassMap : IEntityTypeConfiguration<SchoolClass>
    {
        public void Configure(EntityTypeBuilder<SchoolClass> builder)
        {
            builder.HasKey(x => x.SchoolClassId);

            builder.Property(x => x.SchoolClassId)
                           .HasColumnName("SchoolClassId");

            builder.Property(x => x.ClassName)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
