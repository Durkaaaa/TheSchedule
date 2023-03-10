using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSchedule.Date;
using TheSchedule.Entities;

namespace TheSchedule.Serves
{
    public class ScheduleServes
    {
        public List<Schedule> GetScheduleList()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Schedules
                    .Include(d => d.DayOfTheWeek)
                    .Include(s => s.Subject)
                    .Include(c => c.Cabinet)
                    .Include(l => l.LessonPeriod)
                    .Include(t => t.Teacher)
                    .ToList();
            }
        }

        public List<Schedule> GetDay(Class @class, int dayId)
        {
            return GetScheduleList()
                .Where(t => t.ClassId == @class.Id && t.DayOfTheWeek.Id == dayId)
                .ToList();
        }










        public bool CreateSchedule(Schedule schedule)
        {
            if (schedule == null)
                return false;


            return true;
        }

        public bool RemoveSchedule(Schedule schedule)
        {


            return true;
        }
    }
}
