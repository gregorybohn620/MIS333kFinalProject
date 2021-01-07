using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;

namespace Final_Project_Group20_1.Controllers
{
    public class SeedController : Controller
    {
        private AppDbContext _db;
        private IServiceProvider sp;

        public SeedController(AppDbContext context, IServiceProvider service)
        {
            _db = context;
            sp = service;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeedCompany()
        {
            try
            {
                Seeding.SeedCompany.AddCompany(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The Companies have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding Companies to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedCSO()
        {
            try
            {
                Seeding.SeedCSO.AddCSO(sp);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The CSOs have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding CSOs to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedIdentity()
        {
            try
            {
                Seeding.SeedIdentity.AddAdmin(sp);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The Identities have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding Identities to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedMajor()
        {
            try
            {
                Seeding.SeedMajor.SeedAllMajor(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The Majors have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding Majors to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedPosition()
        {
            try
            {
               Seeding.SeedPosition.AddPosition(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The Positions have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding Positions to the database", ex.Message });
            }

            return View("Confirm");
        }


        public IActionResult SeedRecruiter()
        {
            try
            {
                Seeding.SeedRecruiter.AddRecruiter(sp);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The Recruiters have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding Recruiters to the database", ex.Message });
            }
            return View("Confirm");
        }


        public IActionResult SeedStudent()
        {
            try
            {
                Seeding.SeedStudent.AddStudent(sp);
                //Seeding.SeedStudent.AddStudent(sp);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The Students have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding Students to the database", ex.Message });
            }
            return View("Confirm");
        }

        public IActionResult SeedInterview()
        {
            try
            {
                Seeding.SeedInterview.AddInterview(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The Interviews have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding Interviews to the database", ex.Message });
            }
            return View("Confirm");
        }
    }
}