using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class CouleConfig : IEntityTypeConfiguration<Couple>
    {
        public void Configure(EntityTypeBuilder<Couple> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(c => c.DayTime)
                .WithOne(dt => dt.Couple)
                .HasForeignKey<Couple>(c => c.DayTimeId);
            builder.HasOne(c => c.Room)
                .WithOne(r => r.Couple)
                .HasForeignKey<Couple>(c => c.RoomId);
            builder.HasOne(c => c.Subject)
                .WithOne(s => s.Couple)
                .HasForeignKey<Couple>(c => c.SubjectId);
            builder.HasOne(c => c.Teacher)
                .WithOne(t => t.Couple)
                .HasForeignKey<Couple>(c => c.TeacherId);
        }
    }
}
