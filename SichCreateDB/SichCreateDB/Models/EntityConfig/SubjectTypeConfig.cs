using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class SubjectTypeConfig : IEntityTypeConfiguration<SubjectType>
    {
        public void Configure(EntityTypeBuilder<SubjectType> builder)
        {
            builder.HasKey(st => new { st.SubjectId, st.TypeId });
            builder.HasOne(st => st.Subject)
                .WithMany(s => s.SubjectTypes)
                .HasForeignKey(st => st.SubjectId);
            builder.HasOne(st => st.Type)
                .WithMany(t => t.SubjectTypes)
                .HasForeignKey(st => st.TypeId);
        }
    }
}
