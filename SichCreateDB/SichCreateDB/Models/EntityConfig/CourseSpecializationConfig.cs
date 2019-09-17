using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class CourseSpecializationConfig : IEntityTypeConfiguration<CourseSpecialization>
    {
        public void Configure(EntityTypeBuilder<CourseSpecialization> builder)
        {
            builder.HasKey(cs => cs.Id);
            builder.Property(cs => cs.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(cs => cs.Course)
                .WithMany(c => c.CourseSpecializations)
                .HasForeignKey(cs => cs.CourseId);
            builder.HasOne(cs => cs.Specialization)
                .WithMany(s => s.CourseSpecializations)
                .HasForeignKey(cs => cs.SpecName);
        }
    }
}
