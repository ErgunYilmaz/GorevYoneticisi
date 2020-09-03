using DAL;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface DailyPlanService
    {
        List<DailyPlan> GetAll();
        void Add(DailyPlan dailyPlan);
        void Update(DailyPlan dailyPlan);
        void Remove(Guid id);
        DailyPlan GetById(Guid id);
        void RemoveAll(Expression<Func<DailyPlan, bool>> exp);



    }
}
