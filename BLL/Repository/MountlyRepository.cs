using BLL.Abstract;
using DAL;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repository
{
    public class MountlyRepository : MountlyPlanService
    {
        private readonly AppDbContext context;

        public MountlyRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(MontlyPlan montlyPlan)
        {
            context.MontlyPlans.Add(montlyPlan);
            context.SaveChanges();
        }

        public List<MontlyPlan> GetAll()
        {
            return context.MontlyPlans.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public MontlyPlan GetById(Guid id)
        {
            return context.MontlyPlans.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Guid id)
        {
            MontlyPlan montlyPlan = GetById(id);
            montlyPlan.Status = DAL.Entity.Enum.Status.Deleted;
            Update(montlyPlan);
        }

        public void RemoveAll(Expression<Func<MontlyPlan, bool>> exp)
        {
            foreach (var item in GetAll())
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(MontlyPlan montlyPlan)
        {
            context.Entry(montlyPlan).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
