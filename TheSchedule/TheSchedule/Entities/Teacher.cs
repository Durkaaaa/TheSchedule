using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchedule.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return Surname + " " + Name[0] + ". " + Lastname[0]+".";
            }
        }
    }
}