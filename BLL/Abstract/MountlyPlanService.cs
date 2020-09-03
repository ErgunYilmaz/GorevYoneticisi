using DAL;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface MountlyPlanService
    {
        List<MontlyPlan> GetAll();
        void Add(MontlyPlan montlyPlan);
        void Update(MontlyPlan montlyPlan);
        void Remove(Guid id);
        MontlyPlan GetById(Guid id);
        void RemoveAll(Expression<Func<MontlyPlan, bool>> exp);
    }
}
