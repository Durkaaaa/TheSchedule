using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchedule.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumberOfHours { get; set; }
        public int Load { get; set; }
    }
}