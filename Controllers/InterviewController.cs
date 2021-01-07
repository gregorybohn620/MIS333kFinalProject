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

namespace Final_Project_Group20_1
{
    public class InterviewController : Controller
    {
        
        private readonly AppDbContext _context;

        public InterviewController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult ClaimInterviewSlot(int id)
        {
            //mark slot as filled
            Interview interv = _context.Interviews.Find(id);
            interv.SlotStatus = SlotStatus.Filled;
            _context.SaveChanges();
            return View("Index");

        }



        // GET: Interviews
        //list of interviews student has applied for
        //list of interviews recruiters have
        [Authorize]
        public async Task<IActionResult> Index()
        {
            List<Interview> Interviews = new List<Interview>();
            // TO DO
            return View(_context.Interviews.Include(x => x.Positions).Include(d => d.Company).ToList());
        }

        // GET: Interviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews
                .FirstOrDefaultAsync(m => m.InterviewID == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        // GET: Interviews/Create
        [Authorize(Roles = "Recruiter, CSO")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Interviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Recruiter, CSO")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterviewID,RoomNumber,InterviewTime,Interviewer,Interviewee, InterviewerName, IntervieweeName")] Interview interview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewBag.RoomNumber = GetRoomNumber();
            return View(interview);
        }

        // GET: Interviews/Edit/5
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews.FindAsync(id);
            if (interview == null)
            {
                return NotFound();
            }
            return View(interview);
        }

        // POST: Interviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Student")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InterviewID,RoomNumber,InterviewTime, InterviewerName, IntervieweeName")] Interview interview)
        {
            if (id != interview.InterviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterviewExists(interview.InterviewID))
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
            return View(interview);
        }

        // GET: Interviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews
                .FirstOrDefaultAsync(m => m.InterviewID == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        // POST: Interviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interview = await _context.Interviews.FindAsync(id);
            _context.Interviews.Remove(interview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterviewExists(int id)
        {
            return _context.Interviews.Any(e => e.InterviewID == id);
        }

        //public SelectList GetRoomNumber()
        //{
        //    rm = _context.Interviews.ToList();

        //    //Major SelectNone = new Major() { MajorID = 0, MajorName = "Select A Major" };


        //    SelectList RoomNumber = new SelectList(RoomNumbers);

        //    return RoomNumber;

        //}


    }
}
