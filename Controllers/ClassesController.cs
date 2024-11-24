using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThunderGym.Models;
using ThunderGym.Repositories.Interfaces;
using ThunderGym.Services.Interfaces;

namespace ThunderGym.Controllers
{
    public class ClassesController : Controller
    {
        private readonly IClassService _classService;
        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        // GET: Classes
        public ActionResult Index()
        {
            var classes = _classService.GetClasses();
            
            return View(classes);
        }

        // GET: Classes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classes = _classService.GetClasses()
                .FirstOrDefault(m => m.ClassId == id);
            if (classes == null)
            {
                return NotFound();
            }

            return View(classes);
        }

        // GET: Classes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Classes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassId,TrainerId,ClassName,Schedule")] Class sclass)
        {
            if (ModelState.IsValid)
            {
                _classService.AddClass(sclass);
                _classService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(sclass);
        }

        // GET: Classes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classes = _classService.GetClasses().FirstOrDefault(m => m.ClassId == id);
            if (classes == null)
            {
                return NotFound();
            }
            return View(classes);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClassId,TrainerId,ClassName,Schedule")] Class sclass)
        {
            if (id != sclass.ClassId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _classService.UpdateClass(sclass);
                _classService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(sclass);
        }

        // GET: Classes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classes = _classService.GetClasses().FirstOrDefault(m => m.ClassId == id);
            if (classes == null)
            {
                return NotFound();
            }

            return View(classes);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var classes = _classService.GetClasses().FirstOrDefault(m => m.ClassId == id);
            _classService.DeleteClass(classes);
            _classService.Save();

            return RedirectToAction(nameof(Index));
        }

        private bool ClassExists(int id)
        {
            return _classService.GetClasses().Any(e => e.ClassId == id);
        }
    }
}
