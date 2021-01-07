using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Final_Project_Group20_1.Controllers
{
    
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _db;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _db = context;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        [AllowAnonymous]
        // GET: /Account/Login
        public ActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                return Redirect(returnUrl ?? "/");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
        }

        // GET: /Account/Register
        [Authorize(Roles = "Student")]
        public ActionResult Register()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }

        //Don't think this is used, this looks like it's from HW7
        // POST: /Account/StudentRegister
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterStudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber


                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (await _userManager.IsInRoleAsync(user, "Manager") == false)
                    {
                        await _userManager.AddToRoleAsync(user, "Customer");
                    }

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

        //GET: Account/Index
        public ActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _db.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;


            return View(ivm);
        }

        //Logic for change password
        //GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, model.OldPassword, model.NewPassword);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                return RedirectToAction("Index", "Account");
            }

            AddErrors(result);
            return View(model);
        }

        //GET:/Account/AccessDenied
        public ActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        //POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        ///Moved to StudentController
        //GET Method 
        //public IActionResult StudentRegister()
        //{
        //    return View();
        //}

        ////POST Method
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> StudentRegister([Bind("UserID, Email, FirstName, LastName, StudentMajor, GraduationDate, Position, GPA, Password, ConfirmPassword")] RegisterStudentViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        AppUser user = new AppUser
        //        {
        //            UserName = model.Email,
        //            Email = model.Email,
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            PhoneNumber = model.PhoneNumber


        //        };

        //        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        //        if (result.Succeeded)
        //        {
        //            if (await _userManager.IsInRoleAsync(user, "Student") == false)
        //            {
        //                await _userManager.AddToRoleAsync(user, "Customer");
        //            }

        //            Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
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
        //    return RedirectToAction(nameof(StudentDetails));

        //}

        //public IActionResult StudentDetails()
        //{
        //    return View();
        //}

        ////GET Method
        //public IActionResult RecruiterRegister()
        //{
        //    return View();
        //}

        //POST Method
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult RecruiterRegister()
        //{

        //}

        ////GET Method
        //public IActionResult CSORegister()
        //{
        //    return View();
        //}

        //POST Method
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult CSORegister()
        //{

        //}


        public SelectList GetAllMajors()
        {
            List<Major> Majors = _db.Majors.ToList();

            Major SelectNone = new Major() { MajorID = 0, MajorName = "All Majors" };
            Majors.Add(SelectNone);
            SelectList AllMajors = new SelectList(Majors.OrderBy(g => g.MajorID), "MajorID", "MajorName");

            return AllMajors;
        }



        //GET: Account/LoginIndex
        //Need to route user to correct home view based on the User Role--shows different buttons on the top
        public ActionResult LoginIndex()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _db.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;


            return View(ivm);
        }
    }
}