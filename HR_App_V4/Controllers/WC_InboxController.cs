using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HR_App_V4.Models.DB;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using HR_App_V4.DTOs;

namespace HR_App_V4.Controllers
{
    public class WC_InboxController : Controller
    {
        private readonly Human_ResourcesContext _context;

        public WC_InboxController(Human_ResourcesContext context)
        {
            _context = context;
        }

        // GET: WC_Inbox
        public async Task<IActionResult> Index()
        {
            return View(await _context.WC_Inbox.ToListAsync());
        }

        // GET: WC_Inbox/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wC_Inbox = await _context.WC_Inbox
                .FirstOrDefaultAsync(m => m.ID == id);
            if (wC_Inbox == null)
            {
                return NotFound();
            }

            return View(wC_Inbox);
        }

        // GET: WC_Inbox/Create
        public IActionResult Create()
        {
            DropDowns();
            return View();
        }

        // POST: WC_Inbox/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateDTO dto)
        {
            DropDowns();
            dto.Date_Added = DateTime.Now;
            try
            {
                _context.Add(dto.ToWC_Inbox());
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("It didn't work.");
                System.Diagnostics.Debug.WriteLine(ex);
            }
            
            return View(dto.ToWC_Inbox());
        }

        // GET: WC_Inbox/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            DropDowns();
            if (id == null)
            {
                return NotFound();
            }

            var wC_Inbox = await _context.WC_Inbox.FindAsync(id);
            if (wC_Inbox == null)
            {
                return NotFound();
            }
            return View(wC_Inbox);
        }

        // POST: WC_Inbox/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ReviewDTO dto)
        {
            DropDowns();
            if (dto.TTD_Onset_Date != null && dto.Lost_Time_End1 != null)
            {
                TimeSpan difference = dto.Lost_Time_End1.Value - dto.TTD_Onset_Date.Value;
                double days = difference.TotalDays;
                System.Diagnostics.Debug.WriteLine("Days = " + days);
                dto.Number_Days_Missed = Convert.ToInt32(days);
            }
            System.Diagnostics.Debug.WriteLine("Hearing loss = " + dto.Hearing_Loss);
            System.Diagnostics.Debug.WriteLine("OP = " + dto.OP);
            if (id != dto.ID)
            {
                return NotFound();
            }

            try
            {
                _context.Update(dto.ToCompletedWC_Inbox());
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WC_InboxExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: WC_Inbox/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wC_Inbox = await _context.WC_Inbox
                .FirstOrDefaultAsync(m => m.ID == id);
            if (wC_Inbox == null)
            {
                return NotFound();
            }

            return View(wC_Inbox);
        }

        // POST: WC_Inbox/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wC_Inbox = await _context.WC_Inbox.FindAsync(id);
            _context.WC_Inbox.Remove(wC_Inbox);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WC_InboxExists(int id)
        {
            return _context.WC_Inbox.Any(e => e.ID == id);
        }

        public void DropDowns()
        {
            List<SelectListItem> options = new()
            {
                new SelectListItem { Value = "True", Text = "Yes" },
                new SelectListItem { Value = "False", Text = "No" }
            };
            options.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.options = options;

            List<SelectListItem> genders = new()
            {
                new SelectListItem { Value = "Male", Text = "Male" },
                new SelectListItem { Value = "Female", Text = "Female" }
            };
            genders.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.genders = genders;

            List<SelectListItem> maritalStatus = new()
            {
                new SelectListItem { Value = "Single", Text = "Single" },
                new SelectListItem { Value = "Married", Text = "Married" },
                new SelectListItem { Value = "Widowed", Text = "Widowed" },
                new SelectListItem { Value = "Divorced", Text = "Divorced" },
                new SelectListItem { Value = "Seperated", Text = "Seperated" },
                new SelectListItem { Value = "Registered Partnership", Text = "Registered Partnership" }
            };
            maritalStatus.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.maritalStatus = maritalStatus;

            List<SelectListItem> travelMethods = new()
            {
                new SelectListItem { Value = "Self", Text = "Self" },
                new SelectListItem { Value = "Land Ambulance", Text = "Land Ambulance" },
                new SelectListItem { Value = "Coworker", Text = "Coworker" },
                new SelectListItem { Value = "Other", Text = "Other" }
            };
            travelMethods.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.travelMethods = travelMethods;

            List<SelectListItem> sides = new()
            {
                new SelectListItem { Value = "Left", Text = "Left" },
                new SelectListItem { Value = "Right", Text = "Right" },
                new SelectListItem { Value = "Bilateral", Text = "Bilateral" },
                new SelectListItem { Value = "NA", Text = "NA" }
            };
            sides.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.sides = sides;

            List<SelectListItem> dot12Options = new()
            {
                new SelectListItem { Value = "Yes", Text = "Yes" },
                new SelectListItem { Value = "No", Text = "No" },
                new SelectListItem { Value = "Pending", Text = "Pending" }
            };
            dot12Options.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.dot12Options = dot12Options;

            List<SelectListItem> schedules = new()
            {
                new SelectListItem { Value = "8.0 hours per day, 5 days per week", Text = "8.0 hours per day, 5 days per week" },
                new SelectListItem { Value = "8.5 hours per day, 5 days per week", Text = "8.5 hours per day, 5 days per week" },
                new SelectListItem { Value = "9.0 hours per day, 5 days per week", Text = "9.0 hours per day, 5 days per week" },
                new SelectListItem { Value = "10.0 hours per day, 4 days per week", Text = "10.0 hours per day, 4 days per week" },
                new SelectListItem { Value = "10.0 hours per day, 5 days per week", Text = "10.0 hours per day, 5 days per week" },
                new SelectListItem { Value = "10.5 hours per day, 4 days per week", Text = "10.5 hours per day, 4 days per week" },
                new SelectListItem { Value = "10.5 hours per day, 5 days per week", Text = "10.5 hours per day, 5 days per week" },
                new SelectListItem { Value = "11.0 hours per day, 4 days per week", Text = "11.0 hours per day, 4 days per week" },
                new SelectListItem { Value = "11.0 hours per day, 5 days per week", Text = "11.0 hours per day, 5 days per week" },
                new SelectListItem { Value = "12.0 hours per day, 4 days per week", Text = "12.0 hours per day, 4 days per week" },
                new SelectListItem { Value = "12.0 hours per day, 5 days per week", Text = "12.0 hours per day, 5 days per week" }
            };
            schedules.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.schedules = schedules;

            List<SelectListItem> employmentTypes = new()
            {
                new SelectListItem { Value = "Full Time", Text = "Full Time" },
                new SelectListItem { Value = "Temporary", Text = "Temporary" },
                new SelectListItem { Value = "Co-op", Text = "Co-op" },
            };
            employmentTypes.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.employmentTypes = employmentTypes;

            List<SelectListItem> claimResults = new()
            {
                new SelectListItem { Value = "Rejected", Text = "Rejected" },
                new SelectListItem { Value = "Compensable", Text = "Compensable" },
                new SelectListItem { Value = "Tolled", Text = "Tolled" }
            };
            claimResults.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.claimResults = claimResults;
        }
    }
}
