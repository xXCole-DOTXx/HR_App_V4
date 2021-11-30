using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HR_App_V4.Models.DB;

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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,First_Name,Last_Name,Gender,Marital_Status,SSN,Address,Phone_Number,Org_Number,Hire_Date,Job_Title,Work_Schedule,Injury_Date,Injury_Time,Injury_Type,DOT_12,Start_Time,Injured_Body_Part,Side,Missing_Work,Missing_Work_Date,Begin_Missing_Date,Begin_Missing_Time,Return_To_Work_Date,Doctors_Release,Treatment,Treatment_Date,Treatment_Provider,Treatment_Provider_Phone,Transport_First_Treatment,Transport_City,Injury_Description,Equipment,Witness,Supervisor_Name,Supervisor_Phone,Questioned,Medical_History,Inbox_Submitted,Inbox_Reason,Comments,User_Email,Supervisor_Email,Safety_Specialist_Email,Optional_Email,Optional_Email2,Optional_Email3,HDHR_Manager_Email,Add_User,Date_Added")] WC_Inbox wC_Inbox)
        {
            DropDowns();
            if (ModelState.IsValid)
            {
                wC_Inbox.Add_User = User.Identity.Name;
                wC_Inbox.Date_Added = DateTime.Now;
                _context.Add(wC_Inbox);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wC_Inbox);
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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,First_Name,Last_Name,Gender,Marital_Status,Employment_Status,SSN,DOB,Hourly_Rate,Daily_Rate,Address,Phone_Number,EncovaID,EmployeeID,Org_Number,Hire_Date,Job_Title,Work_Schedule,Injury_Date,Injury_Time,DOT_12,Start_Time,Injured_Body_Part,Side,Missing_Work,Missing_Work_Date,Begin_Missing_Date,Begin_Missing_Time,Return_To_Work_Date,Doctors_Release,Treatment,Treatment_Date,Treatment_Provider,Treatment_Provider_Phone,Transport_First_Treatment,Transport_City,Injury_Description,Equipment,Witness,Supervisor_Name,Supervisor_Phone,Questioned,Medical_History,Inbox_Submitted,Inbox_Reason,Comments,User_Email,Supervisor_Email,Safety_Specialist_Email,Optional_Email,Optional_Email2,Optional_Email3,HDHR_Manager_Email,TX_EROI_Lag,Claim_Ruling,Injury_Type,TTD_Onset_Date,Restricted_RTW,Full_Duty_RTW,TTD_Award_Notice,RTW_Notice_Carrier,Lost_Time_Start1,Lost_Time_End1,Lost_Time_Start2,Lost_Time_End2,Lost_Time_Start3,Lost_Time_End3,Status,HR_Comments,Add_User,Date_Added,HR_User,Date_Modified")] WC_Inbox wC_Inbox)
        {
            DropDowns();
            if (id != wC_Inbox.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wC_Inbox);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WC_InboxExists(wC_Inbox.ID))
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
            return View(wC_Inbox);
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

           /* List<SelectListItem> employmentTypes = new()
            {
                new SelectListItem { Value = "Full Time", Text = "Full Time" },
                new SelectListItem { Value = "Temporary", Text = "Temporary" }
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
            ViewBag.claimResults = claimResults;*/
        }
    }
}
