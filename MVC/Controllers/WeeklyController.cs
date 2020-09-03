using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using BLL.Repository;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class WeeklyController : Controller
    {
        private readonly WeeklyPlanService weeklyPlanService;

        public WeeklyController(WeeklyPlanService weeklyPlanService)
        {
            this.weeklyPlanService = weeklyPlanService;
        }
        public IActionResult Index()
        {
            return View(weeklyPlanService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WeeklyPlan model)
        {
            if (ModelState.IsValid)
            {
               weeklyPlanService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(Guid id)
        {
            WeeklyPlan weeklyPlan = weeklyPlanService.GetById(id);

            return View(weeklyPlan);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WeeklyPlan model)
        {
            if (ModelState.IsValid)
            {
                weeklyPlanService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        public ActionResult Delete(Guid id)
        {
            return View(weeklyPlanService.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(WeeklyPlan model)
        {
            try
            {
                weeklyPlanService.Remove(model.ID);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
