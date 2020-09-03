using DAL;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface WeeklyPlanService
    {
        List<WeeklyPlan> GetAll();
        void Add(WeeklyPlan weeklyPlan);
        void Update(WeeklyPlan weeklyPlan);
        void Remove(Guid id);
        WeeklyPlan GetById(Guid id);
        void RemoveAll(Expression<Func<WeeklyPlan, bool>> exp);
    }
}
