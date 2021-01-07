using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Controllers
{
    public class CSOController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _db;

        //TODO: Should this CSO controller method take this many parameters? What parameters should it take
        public CSOController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _db = context;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }


        //GET Method
        public IActionResult CSORegister()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> CSORegister([Bind("UserName, Email, FirstName, LastName, Password, ConfirmPassword, CompanyName")] RegisterCSOViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        AppUser user = new AppUser
        //        {
        //            //TODO: Add the rest of the user fields here
        //            UserName = model.Email,
        //            Email = model.Email,
        //            FirstName = model.FirstName,
        //            LastName = model.LastName
                    


        //        };
        //        //_db.Add(model);
        //        _db.SaveChanges();

        //        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        //        if (result.Succeeded)
        //        {
        //            //TODO: Add user to desired role. This example adds the user to the customer role
        //            await _userManager.AddToRoleAsync(user, "CSO");
        //            _db.SaveChanges();
        //            Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
        //            _db.SaveChanges();
        //            return RedirectToAction("Index", "Home");
        //        }

        //        else
        //        {
        //            foreach (IdentityError error in result.Errors)
        //            {
        //                ModelState.AddModelError("", error.Description);
        //            }
        //        }
        //    }
        //    return View(model);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CSORegister([Bind("UserName, Email, FirstName, LastName,Password, Password, ConfirmPassword")] RegisterCSOViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                _db.SaveChanges();

                AppUser user = new AppUser
                {

                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,

                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //if (await _userManager.IsInRoleAsync(user, "Student") == false)
                    //{
                    //    await _userManager.AddToRoleAsync(user, "Customer");
                    //}

                    await _userManager.AddToRoleAsync(user, "CSO");
                    Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
                    return RedirectToAction("CSOIndex", "CSO");

                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();


        }



        /// Get Method
        public IActionResult CSOIndex()
        {
            return View();
        }









        public ActionResult DetailedSearch()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }
        //GET METHOD
        public IActionResult CSOSearch()
        {
            return View();
        }
       

        [HttpPost]
        public ActionResult CSOSearch(String SearchPositionName, String SearchPositionDescription,
            String SearchCompany, String SearchIndustry, PositionType SelectedPosition, int SelectedMajor,
            String SearchLocation, DateTime? SelectedDate)
        {
            var query = from p in _db.Positions.Include(p => p.Company).Include(mp => mp.MajorPositions).ThenInclude(mp => mp.Major)
                        select p;

            if (SearchPositionName != null && SearchPositionName != "")
            {
                query = query.Where(t => t.PositionTitle.Contains(SearchPositionName));
            }

            if (SearchPositionDescription != null && SearchPositionDescription != "")
            {
                query = query.Where(d => d.PositionDescription.Contains(SearchPositionDescription));
            }

            if (SearchCompany != null && SearchCompany != "")
            {
                query = query.Where(d => d.Company.CompanyName.Contains(SearchCompany));
            }

            if (SearchIndustry != null && SearchIndustry != "")
            {
                query = query.Where(d => d.Company.CompanyIndustry.Contains(SearchCompany));
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

            if (SelectedDate != null)
            {
                //DateTime SelectedDate = SelectedDate new DateTime(1900, 1, 1);
                query = query.Where(d => d.Deadline >= SelectedDate);
            }

            List<Position> SelectedPositions = query.ToList();

            return View("Index", SelectedPositions.OrderByDescending(b => b.Company.CompanyName).ThenByDescending(b => b.PositionTitle));


        }

        public SelectList GetAllMajors()
        {
            List<Major> Majors = _db.Majors.ToList();

            Major SelectNone = new Major() { MajorID = 0, MajorName = "All Majors" };
            Majors.Add(SelectNone);
            SelectList AllMajors = new SelectList(Majors.OrderBy(g => g.MajorID), "MajorID", "MajorName");

            return AllMajors;
        }

        //Get Methond
        //public Task<IActionResult> DeactivateAccount(int? id, AppUser user)
        //{
        //    if(id == null)
        //    {
        //        return NotFound();

        //    }
        //     user =  _db.AppUsers.Find(id);
        //}

    //    [HttpPost]
    //    public async Task<IActionResult> DeactivateAccount( AppUser user)
    //    {
    //        if(id != user.UserID)
    //    }
    }
}
