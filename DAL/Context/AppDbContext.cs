using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class AppDbContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {

        }
        public DbSet<DailyPlan> DailyPlans { get; set; }
        public DbSet<WeeklyPlan> WeeklyPlans { get; set; }
        public DbSet<MontlyPlan> MontlyPlans { get; set; }
    }
}
