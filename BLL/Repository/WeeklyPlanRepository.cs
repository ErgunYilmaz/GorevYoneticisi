
using BLL.Abstract;
using DAL;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class WeeklyPlanRepository : WeeklyPlanService
    {
        private readonly AppDbContext context;

        public WeeklyPlanRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(WeeklyPlan weeklyPlan)
        {
            context.WeeklyPlans.Add(weeklyPlan);
            context.SaveChanges();
        }

        public List<WeeklyPlan> GetAll()
        {
            return context.WeeklyPlans.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public WeeklyPlan GetById(Guid id)
        {
            return context.WeeklyPlans.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Guid id)
        {
            WeeklyPlan weeklyPlan = GetById(id);
            weeklyPlan.Status = DAL.Entity.Enum.Status.Deleted;
            Update(weeklyPlan);
        }

        public void RemoveAll(Expression<Func<WeeklyPlan, bool>> exp)
        {
            foreach (var item in GetAll())
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(WeeklyPlan weeklyPlan)
        {
            context.Entry(weeklyPlan).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
