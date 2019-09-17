using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class TypeConfig : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.HasKey(t => t.TypeId);
            builder.Property(t => t.TypeId)
                .ValueGeneratedNever();
            builder.Property(t => t.TypeId).HasMaxLength(100);
            builder.HasData(new Type[]
            {
                new Type{TypeId = "Лекционная"},
                new Type{TypeId = "Практическая"},
                new Type{TypeId = "С компьютерами"}
            });
        }
    }
}
