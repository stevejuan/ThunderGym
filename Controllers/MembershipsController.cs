using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThunderGym.Models;
using ThunderGym.Services;
using ThunderGym.Services.Interfaces;

namespace ThunderGym.Controllers
{
    public class MembershipsController : Controller
    {
        private readonly IMembershipService _membershipService;

        public MembershipsController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        // GET: Memberships

        public ActionResult Index()
        {
            var memberships = _membershipService.GetMemberships();
            return View(memberships);
        }

        // GET: Memberships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = _membershipService.GetMemberships()
                .FirstOrDefault(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // GET: Memberships/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Memberships/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MembershipId,MembershipName,Price,Duration,ExpirationDate")] Membership membership)
        {
            if (ModelState.IsValid)
            {
                _membershipService.AddMembership(membership);
                _membershipService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(membership);
        }

        // GET: Memberships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = _membershipService.GetMemberships().FirstOrDefault(m => m.MembershipId == id); ;
            if (membership == null)
            {
                return NotFound();
            }
            return View(membership);
        }

        // POST: Memberships/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MembershipId,MembershipName,Price,Duration,ExpirationDate")] Membership membership)
        {
            if (id != membership.MembershipId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _membershipService.UpdateMembership(membership);
                _membershipService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(membership);
        }

        // GET: Memberships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = _membershipService.GetMemberships().FirstOrDefault(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // POST: Memberships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var membership = _membershipService.GetMemberships().FirstOrDefault(m => m.MembershipId == id);
            _membershipService.DeleteMembership(membership);
            _membershipService.Save();
            return RedirectToAction(nameof(Index));
        }
        private bool MembershipExists(int id)
        {
            return _membershipService.GetMemberships().Any(e => e.MembershipId == id);
        }
    }
}
