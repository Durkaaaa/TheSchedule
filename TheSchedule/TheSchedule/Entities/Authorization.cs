using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchedule.Entities
{
    public class Authorization
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
