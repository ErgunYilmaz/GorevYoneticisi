using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class WeeklyPlan:CoreEntity
    {
        public AppUser AppUser { get; set; }
        public string weeklyPlan { get; set; }
    }
}
