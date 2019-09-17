using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class RoomTimeConfig: IEntityTypeConfiguration<RoomTime>
    {
        public void Configure(EntityTypeBuilder<RoomTime> builder)
        {
            builder.HasKey(rt => new { rt.DayTimeId, rt.RoomId });
            builder.HasOne(rt => rt.DayTime)
                .WithMany(dt => dt.RoomTimes)
                .HasForeignKey(rt => rt.DayTimeId);
            builder.HasOne(rt => rt.Room)
                .WithMany(r => r.RoomTimes)
                .HasForeignKey(rt => rt.RoomId);
        }
    }
}
