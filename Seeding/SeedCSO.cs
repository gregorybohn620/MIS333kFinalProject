using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;

namespace Final_Project_Group20_1.Seeding
{
    //add identity data
    public static class SeedCSO
    {
        public static async Task AddAdmin(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //TODO: Add the needed roles
            //if role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("Student") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Student"));
            }

            if (await _roleManager.RoleExistsAsync("Recruiter") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Recruiter"));
            }

            if (await _roleManager.RoleExistsAsync("CSO") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("CSO"));
            }
        }
        public static async Task AddCSO(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            //check to see if the CSO has been added
            AppUser c1 = _db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com");
            //if CSO hasn't been created, then add them
            if (c1 == null)
            {
                c1 = new AppUser();
                c1.UserName = "ra@aoo.com";
                c1.Email = "ra@aoo.com";
                c1.FirstName = "Allen";
                c1.LastName = "Rogers";



                var result = await _userManager.CreateAsync(c1, "3wCynC");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }

            c1 = _db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com");

            if (await _userManager.IsInRoleAsync(c1, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(c1, "CSO");
            }
                
            




            AppUser c2 = _db.Users.FirstOrDefault(u => u.Email == "rwood@voyager.net");
            //if CSO hasn't been created, then add them
            if (c2 == null)
            {
                c2 = new AppUser();
                c2.UserName = "rwood@voyager.net";
                c2.Email = "rwood@voyager.net";
                c2.FirstName = "Reagan";
                c2.LastName = "Wood";


                var result = await _userManager.CreateAsync(c2, "Pbon0r");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();



                c2 = _db.Users.FirstOrDefault(u => u.UserName == "rwood@voyager.net");
            }

            if (await _userManager.IsInRoleAsync(c2, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(c2, "CSO");
            }
          
    




            AppUser c3 = _db.Users.FirstOrDefault(u => u.Email == "westj@pioneer.net");
            //if CSO hasn't been created, then add them
            if (c3 == null)
            {
                c3 = new AppUser();
                c3.UserName = "westj@pioneer.net";
                c3.Email = "westj@pioneer.net";
                c3.FirstName = "Jake";
                c3.LastName = "West";


                var result = await _userManager.CreateAsync(c3, "jW5fPP");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();



                c3 = _db.Users.FirstOrDefault(u => u.UserName == "westj@pioneer.net");
            }
            if (await _userManager.IsInRoleAsync(c3, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(c3, "CSO");
            }
           
            





            AppUser c4 = _db.Users.FirstOrDefault(u => u.Email == "liz@ggmail.com");
            //if CSO hasn't been created, then add them
            if (c4 == null)
            {
                c4 = new AppUser();
                c4.UserName = "liz@ggmail.com";
                c4.Email = "liz@ggmail.com";
                c4.FirstName = "Elizabeth";
                c4.LastName = "Markham";



                var result = await _userManager.CreateAsync(c4, "0QyilL");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();


                c4 = _db.Users.FirstOrDefault(u => u.UserName == "liz@ggmail.com");
            }

            if (await _userManager.IsInRoleAsync(c4, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(c4, "CSO");
            }
             
            







            AppUser c5 = _db.Users.FirstOrDefault(u => u.Email == "chaley@thug.com");
            //if CSO hasn't been created, then add them
            if (c5 == null)
            {
                c5 = new AppUser();
                c5.UserName = "chaley@thug.com";
                c5.Email = "chaley@thug.com";
                c5.FirstName = "Charles";
                c5.LastName = "Haley";


                var result = await _userManager.CreateAsync(c5, "atLm6W");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();



                c5 = _db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com");
            }

            if (await _userManager.IsInRoleAsync(c5, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(c5, "CSO");
            }

        }

    }
}