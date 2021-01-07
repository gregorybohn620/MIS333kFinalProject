using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;
using Microsoft.AspNetCore.Authorization;
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

    public class RecruiterController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private readonly AppDbContext _db;

        
        

        //This needs to bring the recruiter to a view that lists out all students
        [Authorize(Roles = "Recruiter, CSO")]
        public async Task<IActionResult> Index(string SearchString)
        {


            var query = from s in _db.Users
                       where s.GPA > 0
                       select s;

            if (!String.IsNullOrEmpty(SearchString))
            {
                query = query.Where(s => s.FirstName.Contains(SearchString) || s.LastName.Contains(SearchString));
            }

            //List < AppUser > Users = new List<AppUser>();
            //var query = _db.Users.Where(User.Contains(GPA)).ToList();


            return View(query);
        }

        //public SelectList GetAllStudent()
        //{
            //var query = from p in _db.Users.Where(User.IsInRole("Student"))
            //            select p;

            //List<AppUser> SelectStudents = query.ToList();
            //return View("Index", SelectStudents.OrderByDescending(b => b.FirstName));


            //List<AppUser> Users = _db.Users.Where(Users.IsInRole("Student").ToList();
            //SelectList AllStudents = new SelectList(AppUser.Order);
        //}

        public RecruiterController(AppDbContext db, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }
        
        //GET Method
        public IActionResult RecruiterRegister()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RecruiterRegister([Bind("UserName, Email, FirstName, LastName, Password, ConfirmPassword, CompanyName")] RegisterRecruiterViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    //TODO: Add the rest of the user fields here
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CompanyName = model.CompanyName
                    

                };
                //_db.Add(model);
                _db.SaveChanges();
                
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //TODO: Add user to desired role. This example adds the user to the customer role
                    await _userManager.AddToRoleAsync(user, "Recruiter");
                    _db.SaveChanges();
                    Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
                    return RedirectToAction("Index", "Home");
                }
           
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    

        public ActionResult DetailedSearch()
        {
            ViewBag.AllStudents = GetAllStudents();
            return View();
        }


        public ActionResult RecruiterSearch(String SearchFirstName, String SearchLastName, DateTime SearchGraduationDate, int SelectedMajor, String SearchGPA, PositionType SelectedPosition)
        {
            decimal decGPA;

            var query = from p in _db.Users.Include(p => p.Positions).ThenInclude(p => p.MajorPositions).ThenInclude(p => p.Major)
                        select p;

            if (SearchFirstName != null && SearchFirstName != "")
            {
                query = query.Where(j => j.FirstName.Contains(SearchFirstName));
            }

            if (SearchLastName != null && SearchLastName != "")
            {
                query = query.Where(t => t.LastName.Contains(SearchLastName));
            }

            if (SearchGraduationDate != null)
            {
                query = query.Where(d => d.GraduationDate >= SearchGraduationDate);
            }

            if (SelectedMajor != 0)
            {
                query = query.Where(g => g.MajorName.MajorID == SelectedMajor);
            }

            if (SelectedPosition == PositionType.I)
            {
                query = query.Where(p => p.Position == PositionType.I);
            }
            else if (SelectedPosition == PositionType.FT)
            {
                query = query.Where(p => p.Position == PositionType.FT);
            }

            if (SearchGPA != null && SearchGPA != "")
            {
                try
                {
                    decGPA = Convert.ToDecimal(SearchGPA);
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Error");
                }
                query = query.Where(c => c.GPA >= decGPA);

            }



            List<AppUser> SelectedStudents = query.ToList();
            return View("Index", SelectedStudents.OrderByDescending(b => b.FirstName));
        }

        public SelectList GetAllStudents()
        {
            List<AppUser> Users = _db.Users.ToList();

            //Major SelectNone = new Major() { MajorID = 0, MajorName = "All Majors" };
            //Majors.Add(SelectNone);
            SelectList AllStudents = new SelectList(Users.OrderBy(g => g.UserName), "UserID", "UserName");

            return AllStudents;
        }
    }
}