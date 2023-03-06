using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchedule.Entities
{
    public class LessonPeriod
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
