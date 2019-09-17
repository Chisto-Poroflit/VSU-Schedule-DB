using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SichCreateDB.Models.Entity;

namespace SichCreateDB.Models.EntityConfig
{
    public class DayTimeConfig: IEntityTypeConfiguration<DayTime>
    {
        public void Configure(EntityTypeBuilder<DayTime> builder)
        {
            builder.HasKey(dt => dt.Id);
            builder.Property(dt => dt.Id)
                .ValueGeneratedOnAdd();
            builder.Property(dt => dt.Day).HasMaxLength(100);
            builder.Property(dt => dt.NumerOrDenomin).HasMaxLength(40);
            builder.Property(dt => dt.StartTime).HasMaxLength(40);
            builder.Property(dt => dt.EndTime).HasMaxLength(40);
            builder.HasData(
                new DayTime[]
                {
                    new DayTime{Id = 1, StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Числитель", Day = "Понедельник"},
                    new DayTime{Id = 2,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Знаменатель", Day = "Понедельник"},

                    new DayTime{Id = 3,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Числитель", Day = "Понедельник"},
                    new DayTime{Id = 4,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Знаменатель", Day = "Понедельник"},

                    new DayTime{Id = 5,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Числитель", Day = "Понедельник"},
                    new DayTime{Id = 6,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Знаменатель", Day = "Понедельник"},

                    new DayTime{Id = 7,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Числитель", Day = "Понедельник"},
                    new DayTime{Id = 8,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Знаменатель", Day = "Понедельник"},

                    new DayTime{Id = 9,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Числитель", Day = "Понедельник"},
                    new DayTime{Id = 10,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Знаменатель", Day = "Понедельник"},

                    new DayTime{Id = 11,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Числитель", Day = "Понедельник"},
                    new DayTime{Id = 12,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Знаменатель", Day = "Понедельник"},

                    new DayTime{Id = 13,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Числитель", Day = "Понедельник"},
                    new DayTime{Id = 14,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Знаменатель", Day = "Понедельник"}
                });
            builder.HasData(
                new DayTime[]
                {
                    new DayTime{Id = 15,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Числитель", Day = "Вторник"},
                    new DayTime{Id = 16,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Знаменатель", Day = "Вторник"},

                    new DayTime{Id = 17,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Числитель", Day = "Вторник"},
                    new DayTime{Id = 18,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Знаменатель", Day = "Вторник"},

                    new DayTime{Id = 19,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Числитель", Day = "Вторник"},
                    new DayTime{Id = 20,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Знаменатель", Day = "Вторник"},

                    new DayTime{Id = 21,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Числитель", Day = "Вторник"},
                    new DayTime{Id = 22,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Знаменатель", Day = "Вторник"},

                    new DayTime{Id = 23,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Числитель", Day = "Вторник"},
                    new DayTime{Id = 24,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Знаменатель", Day = "Вторник"},

                    new DayTime{Id = 25,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Числитель", Day = "Вторник"},
                    new DayTime{Id = 26,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Знаменатель", Day = "Вторник"},

                    new DayTime{Id = 27,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Числитель", Day = "Вторник"},
                    new DayTime{Id = 28,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Знаменатель", Day = "Вторник"}
                });
            builder.HasData(
                new DayTime[]
                {
                    new DayTime{Id = 29,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Числитель", Day = "Среда"},
                    new DayTime{Id = 30,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Знаменатель", Day = "Среда"},

                    new DayTime{Id = 31,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Числитель", Day = "Среда"},
                    new DayTime{Id = 32,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Знаменатель", Day = "Среда"},

                    new DayTime{Id = 33,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Числитель", Day = "Среда"},
                    new DayTime{Id = 34,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Знаменатель", Day = "Среда"},

                    new DayTime{Id = 35,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Числитель", Day = "Среда"},
                    new DayTime{Id = 36,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Знаменатель", Day = "Среда"},

                    new DayTime{Id = 37,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Числитель", Day = "Среда"},
                    new DayTime{Id = 38,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Знаменатель", Day = "Среда"},

                    new DayTime{Id = 39,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Числитель", Day = "Среда"},
                    new DayTime{Id = 40,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Знаменатель", Day = "Среда"},

                    new DayTime{Id = 41,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Числитель", Day = "Среда"},
                    new DayTime{Id = 42,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Знаменатель", Day = "Среда"}
                });
            builder.HasData(
                new DayTime[]
                {
                    new DayTime{Id = 43,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Числитель", Day = "Четверг"},
                    new DayTime{Id = 44,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Знаменатель", Day = "Четверг"},

                    new DayTime{Id = 45,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Числитель", Day = "Четверг"},
                    new DayTime{Id = 46,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Знаменатель", Day = "Четверг"},

                    new DayTime{Id = 47,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Числитель", Day = "Четверг"},
                    new DayTime{Id = 48,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Знаменатель", Day = "Четверг"},

                    new DayTime{Id = 49,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Числитель", Day = "Четверг"},
                    new DayTime{Id = 50,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Знаменатель", Day = "Четверг"},

                    new DayTime{Id = 51,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Числитель", Day = "Четверг"},
                    new DayTime{Id = 52,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Знаменатель", Day = "Четверг"},

                    new DayTime{Id = 53,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Числитель", Day = "Четверг"},
                    new DayTime{Id = 54,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Знаменатель", Day = "Четверг"},

                    new DayTime{Id = 55,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Числитель", Day = "Четверг"},
                    new DayTime{Id = 56,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Знаменатель", Day = "Четверг"}
                });
            builder.HasData(
                new DayTime[]
                {
                    new DayTime{Id = 57,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Числитель", Day = "Пятница"},
                    new DayTime{Id = 58,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Знаменатель", Day = "Пятница"},

                    new DayTime{Id = 59,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Числитель", Day = "Пятница"},
                    new DayTime{Id = 60,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Знаменатель", Day = "Пятница"},

                    new DayTime{Id = 61,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Числитель", Day = "Пятница"},
                    new DayTime{Id = 62,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Знаменатель", Day = "Пятница"},

                    new DayTime{Id = 63,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Числитель", Day = "Пятница"},
                    new DayTime{Id = 64,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Знаменатель", Day = "Пятница"},

                    new DayTime{Id = 65,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Числитель", Day = "Пятница"},
                    new DayTime{Id = 66,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Знаменатель", Day = "Пятница"},

                    new DayTime{Id = 67,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Числитель", Day = "Пятница"},
                    new DayTime{Id = 68,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Знаменатель", Day = "Пятница"},

                    new DayTime{Id = 69,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Числитель", Day = "Пятница"},
                    new DayTime{Id = 70,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Знаменатель", Day = "Пятница"}
                });
            builder.HasData(
                new DayTime[]
                {
                    new DayTime{Id = 71,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Числитель", Day = "Суббота"},
                    new DayTime{Id = 72,StartTime = "8:00", EndTime = "9:35", NumerOrDenomin = "Знаменатель", Day = "Суббота"},

                    new DayTime{Id = 73,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Числитель", Day = "Суббота"},
                    new DayTime{Id = 74,StartTime = "9:45", EndTime = "11:20", NumerOrDenomin = "Знаменатель", Day = "Суббота"},

                    new DayTime{Id = 75,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Числитель", Day = "Суббота"},
                    new DayTime{Id = 76,StartTime = "11:30", EndTime = "13:05", NumerOrDenomin = "Знаменатель", Day = "Суббота"},

                    new DayTime{Id = 77,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Числитель", Day = "Суббота"},
                    new DayTime{Id = 78,StartTime = "13:25", EndTime = "15:00", NumerOrDenomin = "Знаменатель", Day = "Суббота"},

                    new DayTime{Id = 79,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Числитель", Day = "Суббота"},
                    new DayTime{Id = 80,StartTime = "15:10", EndTime = "16:45", NumerOrDenomin = "Знаменатель", Day = "Суббота"},

                    new DayTime{Id = 81,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Числитель", Day = "Суббота"},
                    new DayTime{Id = 82,StartTime = "16:55", EndTime = "18:30", NumerOrDenomin = "Знаменатель", Day = "Суббота"},

                    new DayTime{Id = 83,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Числитель", Day = "Суббота"},
                    new DayTime{Id = 84,StartTime = "18:40", EndTime = "20:15", NumerOrDenomin = "Знаменатель", Day = "Суббота"}
                });
        }
    }
}
