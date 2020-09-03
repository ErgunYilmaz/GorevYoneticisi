using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MVC.Controllers
{
    public class MountlyController : Controller
    {
        private readonly MountlyPlanService mountlyPlanService;

        public MountlyController(MountlyPlanService mountlyPlanService)
        {
            this.mountlyPlanService = mountlyPlanService;
        }
        public IActionResult Index()
        {
            return View(mountlyPlanService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MontlyPlan model)
        {
            if (ModelState.IsValid)
            {
                mountlyPlanService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(Guid id)
        {
          MontlyPlan  mountlyPlan  = mountlyPlanService.GetById(id);

            return View(mountlyPlan);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MontlyPlan model)
        {
            if (ModelState.IsValid)
            {
                mountlyPlanService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        public ActionResult Delete(Guid id)
        {
            return View(mountlyPlanService.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(MontlyPlan model)
        {
            try
            {
                mountlyPlanService.Remove(model.ID);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
