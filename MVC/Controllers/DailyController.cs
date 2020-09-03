using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class DailyController : Controller
    {
        private readonly DailyPlanService dailyPlanService;

        public DailyController(DailyPlanService dailyPlanService)
        {
            this.dailyPlanService = dailyPlanService;
        }
        public IActionResult Index()
        {
            return View(dailyPlanService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DailyPlan model)
        {
            if (ModelState.IsValid)
            {
                dailyPlanService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(Guid id)
        {
            DailyPlan dailyPlan = dailyPlanService.GetById(id);
           
            return View(dailyPlan);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DailyPlan daily)
        {
            if (ModelState.IsValid)
            {
                dailyPlanService.Update(daily);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        public ActionResult Delete(Guid id)
        {
            return View(dailyPlanService.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DailyPlan daily)
        {
            try
            {
                dailyPlanService.Remove(daily.ID);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
