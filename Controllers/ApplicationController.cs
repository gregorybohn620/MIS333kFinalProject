using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.NetworkInformation;

namespace Final_Project_Group20_1
{
    public class ApplicationController : Controller
    {
        private readonly AppDbContext _context;
        private int positionID;

        public ApplicationController(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// ////I MADE EDITS TO THIS THAT WILL MESSS SOMETHINGUP
        /// Was initially  View(_context.Applications.Include(x => x.Company).Include(x => x.Position).ToList());    but Caitie deleted company from position model class bc that is wrong
        /// </summary>
        /// <returns></returns>
        // GET: Application

        
        
        [Authorize]
        public async Task<IActionResult> ApplicationIndex ()
        {

            return View(_context.Applications.Include(x => x.Position.Company).Include(x => x.Position).ToList());

        }

        [Authorize(Roles = "Recruiter")]
        public IActionResult AcceptApp(int id)
        {
            Application app = _context.Applications.Find(id);
            app.AppStatus = ApplicationStatusList.Accepted;
            _context.SaveChanges();
            return View("ApplicationIndex");
        }

        [Authorize(Roles = "Recruiter")]
        public IActionResult DenyApp(int id)
        {
            Application app = _context.Applications.Find(id);
            app.AppStatus = ApplicationStatusList.Rejected;
            _context.SaveChanges();
            return View("ApplicationIndex");
        }



        // GET: Application/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: Application/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Application/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationID, CompanyName, PositionTitle")] Application application)
        {
            if (ModelState.IsValid)
            {
                _context.Add(application);
                await _context.SaveChangesAsync();
                application.AppStatus = ApplicationStatusList.Pending;
                _context.SaveChanges();
                return RedirectToAction(nameof(ApplicationIndex));
            }
            return View(application);
        }

        // GET: Application/Edit/5
        [Authorize(Roles = "Recruiter")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        // POST: Application/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Recruiter")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationID")] Application application)
        {
            if (id != application.ApplicationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.ApplicationID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ApplicationIndex));
            }
            return View(application);
        }

        // GET: Application/Delete/5
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Application/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ApplicationIndex));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.ApplicationID == id);
        }



        //private MultiSelectList GetAllApplications()
        //{
        //    List<Application> Applications = _context.Applications.ToList();
        //    //create the new multiselect list.  Note that DepartmentID and DepartmentName are the names of fields on the Department model class
        //    MultiSelectList AllApplications = new MultiSelectList(Applications, "ApplicationID", "ApplicationName");
        //    return AllApplications;
        //}

        //private MultiSelectList GetAllApplications(Int32 positionID)
        //{
        //    //make a new list of all the applications
        //    List<Application> Applications = _context.Applications.ToList();

        //    //get the list of applications for this list
        //    List<Position> positions = _context.Positions.Where(cd => cd.Position.PositionID == positionID).ToList();

        //    //loop through this list to convert to a list of integers
        //    List<Int32> selectedApplications = new List<Int32>();

        //    foreach (Position cd in positions)
        //    {
        //        selectedApplications.Add(cd.PositionID);
        //    }

        //    //create the multiselect list with the previously selected departments highlighted
        //    MultiSelectList AllApplications = new MultiSelectList(Applications, "ApplicationID", "ApplicationName", selectedApplications);

        //    //return the multiselect list
        //    return AllApplications;

        //public IActionResult Withdraw()
        //{
        //    Needs to Delete the application
        //}

        [Authorize(Roles = "Student")]
        //int positionID, int InterviewID
        public IActionResult ScheduleInterview(int id)
        {
            var query = from p in _context.Applications.Include(p => p.Position).ThenInclude(i => i.Interviews)
                        select p;

            //if (SlotStatus != SlotStatus.Filled)
            //{
            //    query = query.Where(t => t.Position.PositionID == positionID); //.Contains(InterviewID.SlotStatus == NotFilled);
            //}

            query = query.Where(t => t.Position.PositionID == id);

            List<Application> SelectedInterviews = query.ToList();
            return RedirectToAction("Index", "Interview", SelectedInterviews.OrderByDescending(b => b.Position.PositionTitle));

            //all positions that match position id and slot status is open--meaning can schedule interview
        }



        // [HttpPost]
        //public ActionResult Apply(int PositionID)
        //{
        //    //get user info
        //    String id = User.Identity.Name;
        //    AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

        //    Position position = _context.Positions.Find(PositionID);

        //    Application app = new Application();
        //    app.Position = position;
        //    app.AppUser = user;
        //    app.AppStatus = ApplicationStatusList.Pending;

        //    _context.Add(app);
        //    _context.SaveChanges();

        //    //where do they go from here
        //    return RedirectToAction("ApplicationHomeForStudent","Application", new { id } );

        //}
    }
}
