﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id)
                .ValueGeneratedOnAdd();
            builder.HasOne(g => g.Course)
                .WithOne(c => c.Group)
                .HasForeignKey<Group>(g => g.CourseId);
            builder.HasOne(g => g.Specialization)
                .WithOne(s => s.Group)
                .HasForeignKey<Group>(g => g.SpecializatioName);
        }
    }
}