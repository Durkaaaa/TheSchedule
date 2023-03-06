using Microsoft.EntityFrameworkCore;
using TheSchedule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchedule.Date
{
    public class ApplicationDbContext : DbContext
    {
        
        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<Cabinet> Cabinets { get; set; }
        public virtual DbSet<DayOfTheWeek> DayOfTheWeeks { get; set; }
        public virtual DbSet<LessonPeriod> LessonPeriods { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=PC-232-09\\SQLEXPRESS;Initial Catalog=Schedule;User ID=sa;Password=0$sa");
            }
        }
    }
}
