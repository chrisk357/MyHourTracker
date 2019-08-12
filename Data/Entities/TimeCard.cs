using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHourTracker.Data.Entities
{
    public class TimeCard
    {
        public int Id { get; set; }
        public int ClockInH { get; set; }
        public int ClockInM { get; set; }
        public int ClockOutH { get; set; }
        public int ClockOutM { get; set; }
        public DateTime ShiftDate { get; set; }
    }
}
