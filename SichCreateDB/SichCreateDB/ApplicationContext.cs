using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SichCreateDB.Models.EntityConfig;

namespace SichCreateDB
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DimasGotovsya;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DayTimeConfig());
            modelBuilder.ApplyConfiguration(new TypeConfig());
            modelBuilder.ApplyConfiguration(new SubjConfig());
            modelBuilder.ApplyConfiguration(new RoomConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new TeachSubjConfig());
            modelBuilder.ApplyConfiguration(new TeachTimeConfg());
            modelBuilder.ApplyConfiguration(new SubjectTypeConfig());
            modelBuilder.ApplyConfiguration(new RoomTimeConfig());
            modelBuilder.ApplyConfiguration(new RoomTypeConfig());
            modelBuilder.ApplyConfiguration(new CorseConfig());
            modelBuilder.ApplyConfiguration(new SpecializationConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new GroupTimeConfig());
            modelBuilder.ApplyConfiguration(new CourseSpecializationConfig());
            modelBuilder.ApplyConfiguration(new SubjectCourseSpecConfig());
            modelBuilder.ApplyConfiguration(new CouleConfig());
            modelBuilder.ApplyConfiguration(new CoupleGroupConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
