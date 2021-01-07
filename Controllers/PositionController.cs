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
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Positions
        [Authorize(Roles = "Student, CSO")]
        public async Task<IActionResult> Index()
        {
            return View(_context.Positions.Include(x => x.MajorPositions)
                .ThenInclude(x => x.Major)
                .Include(x => x.Company)
                .ToList());
        }

        // GET: Positions/Details/5
        public async Task<IActionResult> PositionDetails (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position position = await _context.Positions.Include(p => p.Company)
                .Include(mp => mp.MajorPositions).ThenInclude(m => m.Major)
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (position == null)
            {
                return NotFound();
            }

            //Need to edit this return line of code,
            //it needs to output the company name, industry, and applicable majors
            //on the position details view
            return View(position);
            //return View(position);
        }

        //[HttpPost]
        //public  Task<IActionResult> PositionDetails([Bind("PositionID, PositionTitle, PositionType")] Position position)
        //{
            


        //    return RedirectToAction("Create", "Application", new { positionID = position.PositionID });
            
        //}


        // GET: Positions/Create
        [Authorize(Roles = "Recruiter, CSO")]
        public IActionResult Create()
        {

            return View();
        }

        // POST: Positions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Recruiter, CSO")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionID,PositionTitle,PositionType,Location,Deadline,PositionDescription")] Position position)
        {
            if (ModelState.IsValid)
            {
                _context.Add(position);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(position);
        }

        // GET: Positions/Edit/5
        [Authorize(Roles = "Recruiter, CSO")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                return NotFound();
            }
            return View(position);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Recruiter, CSO")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PositionID,PositionTitle,PositionType,Location,Deadline,PositionDescription")] Position position)
        {
            if (id != position.PositionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(position);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PositionExists(position.PositionID))
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
            return View(position);
        }

        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _context.Positions
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (position == null)
            {
                return NotFound();
            }

            return View(position);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var position = await _context.Positions.FindAsync(id);
            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PositionExists(int id)
        {
            return _context.Positions.Any(e => e.PositionID == id);
        }


        public IActionResult PositionIndex()
        {
            return View(_context.Positions.ToList());
        }

        public ActionResult DetailedSearch()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }


        public ActionResult DisplaySearchResults(String SearchName, String SearchIndustry, String SearchPosition, int SelectedMajor, String SearchLocation, PositionType SelectedPosition)
        {
            var query = from p in _context.Positions.Include(p => p.Company).Include(mp => mp.MajorPositions).ThenInclude(mp => mp.Major)
                        select p;

            if (SearchName != null && SearchName != "")
            {
                query = query.Where(t => t.Company.CompanyName.Contains(SearchName));
            }

            if (SearchIndustry != null && SearchIndustry != "")
            {
                query = query.Where(d => d.Company.CompanyIndustry.Contains(SearchIndustry));
            }

            if (SelectedPosition == PositionType.I)
            {
                query = query.Where(p => p.PositionType == PositionType.I);
            }
            else if (SelectedPosition == PositionType.FT)
            {
                query = query.Where(p => p.PositionType == PositionType.FT);
            }

            if (SelectedMajor != 0)
            {
                query = query.Where(g => g.MajorPositions.Any(p => p.Major.MajorID == SelectedMajor));
            }

            if (SearchLocation != null && SearchLocation != "")
            {
                query = query.Where(d => d.Location.Contains(SearchLocation));
            }

            List<Position> SelectedPositions = query.ToList();

            return View("Index", SelectedPositions.OrderByDescending(b => b.Company.CompanyName).ThenByDescending(b => b.PositionTitle));


        }

        public SelectList GetAllMajors()
        {
            List<Major> Majors = _context.Majors.ToList();

            Major SelectNone = new Major() { MajorID = 0, MajorName = "All Majors" };
            Majors.Add(SelectNone);
            SelectList AllMajors = new SelectList(Majors.OrderBy(g => g.MajorID), "MajorID", "MajorName");

            return AllMajors;
        }

        //GET

        //
        //GET
        //public async Task<IActionResult> Apply(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var position = await _context.Positions
        //        .FirstOrDefaultAsync(m => m.PositionID == id);
        //    if (position == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(position);
        //}
        //public IActionResult Apply()
        //{
        //    return View();
        //}

        //public IActionResult Apply()
        //{
        //    return View();
        //}



        ///[HttpPost]
        //public IActionResult Apply()
        //{

        //}
    }

    
}