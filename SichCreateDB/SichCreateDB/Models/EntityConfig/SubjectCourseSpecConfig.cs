using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class SubjectCourseSpecConfig : IEntityTypeConfiguration<SubjectCourseSpecialization>
    {
        public void Configure(EntityTypeBuilder<SubjectCourseSpecialization> builder)
        {
            builder.HasKey(scs => new { scs.SubjectId, scs.CourseSpecId });
            builder.HasOne(scs => scs.CourseSpecialization)
                .WithMany(cs => cs.SubjectCourseSpecializations)
                .HasForeignKey(scs => scs.CourseSpecId);
            builder.HasOne(scs => scs.Subject)
                .WithMany(s => s.SubjectCourseSpecializations)
                .HasForeignKey(scs => scs.SubjectId);
        }
    }
}
