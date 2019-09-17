using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class TeachTimeConfg: IEntityTypeConfiguration<TeacherTime>
    {
        public void Configure(EntityTypeBuilder<TeacherTime> builder)
        {
            builder.HasKey(tt => tt.Id);
            builder.Property(tt => tt.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(tt => tt.DayTime)
                .WithMany(t => t.TeachersTimes)
                .HasForeignKey(tt => tt.DayTimeId);
            builder.HasOne(tt => tt.Teacher)
                .WithMany(t => t.TeachersTimes)
                .HasForeignKey(tt => tt.TeacherId);
        }
    }
}
