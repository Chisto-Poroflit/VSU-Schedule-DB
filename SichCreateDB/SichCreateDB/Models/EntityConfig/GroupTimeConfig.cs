using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class GroupTimeConfig : IEntityTypeConfiguration<GroupTime>
    {
        public void Configure(EntityTypeBuilder<GroupTime> builder)
        {
            builder.HasKey(gt => new { gt.DayTimeId, gt.GroupId });
            builder.HasOne(gt => gt.DayTime)
                .WithMany(dt => dt.GroupTimes)
                .HasForeignKey(gt => gt.DayTimeId);
            builder.HasOne(gt => gt.Group)
                .WithMany(g => g.GroupTimes)
                .HasForeignKey(gt => gt.GroupId);
        }
    }
}
