using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class RoomTypeConfig : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasKey(rt => new { rt.TypeId, rt.RoomNumber });
            builder.HasOne(rt => rt.Room)
                .WithMany(r => r.TypeRoom)
                .HasForeignKey(rt => rt.RoomNumber);
            builder.HasOne(rt => rt.Type)
                .WithMany(t => t.TypeRoom)
                .HasForeignKey(rt => rt.TypeId);
        }
    }
}
