using BLL.Abstract;
using DAL;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL.Repository
{
    public class DailyPlanRepository : DailyPlanService
    {
        private readonly AppDbContext context;

        public DailyPlanRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(DailyPlan dailyPlan)
        {
            context.DailyPlans.Add(dailyPlan);
            context.SaveChanges();
        }

        public List<DailyPlan> GetAll()
        {
            return context.DailyPlans.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public DailyPlan GetById(Guid id)
        {
            return context.DailyPlans.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Guid id)
        {
            DailyPlan dailyPlan = GetById(id);
            dailyPlan.Status = DAL.Entity.Enum.Status.Deleted;
            Update(dailyPlan);
        }

        public void RemoveAll(Expression<Func<DailyPlan, bool>> exp)
        {
            foreach (var item in GetAll())
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(DailyPlan dailyPlan)
        {
            context.Entry(dailyPlan).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
