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
    public class StudentController : Controller
    {

        private SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private readonly AppDbContext _db;


        public StudentController(AppDbContext db, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        //GET METHOD
        [Authorize(Roles = "Student")]
        public IActionResult Index()
        {

            return View();
        }
        public SelectList GetAllMajors()
        {
            List<Major> Majors = _db.Majors.ToList();

            //Major SelectNone = new Major() { MajorID = 0, MajorName = "Select A Major" };


            SelectList AllMajors = new SelectList(Majors.OrderBy(m => m.MajorID), "MajorID", "MajorName");

            return AllMajors; 

        }
        //GET Method
        public IActionResult StudentRegister()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StudentRegister([Bind("UserName, Email, FirstName, LastName, PhoneNumber, GPA, GraduationDate, Position, Password, ConfirmPassword")] RegisterStudentViewModel model, int SelectedMajor)
        {
            if (ModelState.IsValid)
            {
                //_db.Add(model);
                _db.SaveChanges();

               

            }
            AppUser user = new AppUser
            {

                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                GPA = model.GPA,
                GraduationDate = model.GraduationDate,
                Position = model.Position,
                MajorName = model.MajorName
            };
            _db.Add(user);
            
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                //if (await _userManager.IsInRoleAsync(user, "Student") == false)
                //{
                //    await _userManager.AddToRoleAsync(user, "Customer");
                //}
               
                await _userManager.AddToRoleAsync(user, "Student");
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
                _db.SaveChanges();
                ///return RedirectToAction("StudentDetails", "Student",  new { id = User.Identity.UserId() });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

        
            ViewBag.AllMajors = GetAllMajors();
            return View();


        }

        public IActionResult StudentDetails(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var student = _db.Users;

            if(student == null)
            {
                return NotFound();
            }
                
            return View(student);
        }

    }
}
