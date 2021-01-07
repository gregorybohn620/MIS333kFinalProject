//SeedRecruiter.cs

using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

//TODO: Change these using statements to match your project
using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;

//TODO: Change this namespace to match your project
namespace Final_Project_Group20_1.Seeding
{
    //add identity data
    public static class SeedRecruiter
    {
        public static async Task AddRecruiter(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            //check to see if the Recruiter has been added
            AppUser r1 = _db.Users.FirstOrDefault(u => u.Email == "michelle@example.com");
            //if Recruiter hasn't been created, then add them
            if (r1 == null)
            {
                r1 = new AppUser();
                r1.UserName = "michelle@example.com";
                r1.Email = "michelle@example.com";
                r1.FirstName = "Michelle";
                r1.LastName = "Banks";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r1.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Accenture");
            try 
            {
                IdentityResult result = await _userManager.CreateAsync(r1, "jVb0Z6");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r1 = _db.Users.FirstOrDefault(u => u.UserName == "michelle@example.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r1, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r1, "Recruiter");
            }
            //save changes
            _db.SaveChanges();





            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r2 = _db.Users.FirstOrDefault(u => u.Email == "toddy@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r2 == null)
            {
                r2 = new AppUser();
                r2.UserName = "toddy@aool.com";
                r2.Email = "toddy@aool.com";
                r2.FirstName = "Todd";
                r2.LastName = "Jacobs";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r2.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Accenture");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r2, "1PnrBV");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r2 = _db.Users.FirstOrDefault(u => u.UserName == "toddy@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r2, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r2, "Recruiter");
            }
            //save changes
            _db.SaveChanges();






            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r3 = _db.Users.FirstOrDefault(u => u.Email == "elowe@netscrape.net");
            //if Recruiter hasn't been created, then add them
            if (r3 == null)
            {
                r3 = new AppUser();
                r3.UserName = "elowe@netscrape.net";
                r3.Email = "elowe@netscrape.net";
                r3.FirstName = "Ernest";
                r3.LastName = "Lowe";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r3.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Shell");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r3, "v3n5AV");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r3 = _db.Users.FirstOrDefault(u => u.UserName == "elowe@netscrape.net");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r3, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r3, "Recruiter");
            }
            //save changes
            _db.SaveChanges();





            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r4 = _db.Users.FirstOrDefault(u => u.Email == "mclarence@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r4 == null)
            {
                r4 = new AppUser();
                r4.UserName = "mclarence@aool.com";
                r4.Email = "mclarence@aool.com";
                r4.FirstName = "Clarence";
                r4.LastName = "Martin";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r4.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Deloitte");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r4, "zBLq3S");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r4 = _db.Users.FirstOrDefault(u => u.UserName == "mclarence@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r4, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r4, "Recruiter");
            }
            //save changes
            _db.SaveChanges();








            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r5 = _db.Users.FirstOrDefault(u => u.Email == "nelson.Kelly@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r5 == null)
            {
                r5 = new AppUser();
                r5.UserName = "nelson.Kelly@aool.com";
                r5.Email = "nelson.Kelly@aool.com";
                r5.FirstName = "Kelly";
                r5.LastName = "Nelson";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r5.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Deloitte");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r5, "FSb8rA");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r5 = _db.Users.FirstOrDefault(u => u.UserName == "nelson.Kelly@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r5, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r5, "Recruiter");
            }
            //save changes
            _db.SaveChanges();




            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r6 = _db.Users.FirstOrDefault(u => u.Email == "megrhodes@freezing.co.uk");
            //if Recruiter hasn't been created, then add them
            if (r6 == null)
            {
                r6 = new AppUser();
                r6.UserName = "megrhodes@freezing.co.uk";
                r6.Email = "megrhodes@freezing.co.uk";
                r6.FirstName = "Megan";
                r6.LastName = "Rhodes";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r6.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Deloitte");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r6, "1xVfHp");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r6 = _db.Users.FirstOrDefault(u => u.UserName == "megrhodes@freezing.co.uk");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r6, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r6, "Recruiter");
            }
            //save changes
            _db.SaveChanges();






            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r7 = _db.Users.FirstOrDefault(u => u.Email == "sheff44@ggmail.com");
            //if Recruiter hasn't been created, then add them
            if (r7 == null)
            {
                r7 = new AppUser();
                r7.UserName = "sheff44@ggmail.com";
                r7.Email = "sheff44@ggmail.com";
                r7.FirstName = "Martin";
                r7.LastName = "Sheffield";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r7.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Texas Instruments");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r7, "4XKLsd");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r7 = _db.Users.FirstOrDefault(u => u.UserName == "sheff44@ggmail.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r7, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r7, "Recruiter");
            }
            //save changes
            _db.SaveChanges();






            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r8 = _db.Users.FirstOrDefault(u => u.Email == "peterstump@hootmail.com");
            //if Recruiter hasn't been created, then add them
            if (r8 == null)
            {
                r8 = new AppUser();
                r8.UserName = "peterstump@hootmail.com";
                r8.Email = "peterstump@hootmail.com";
                r8.FirstName = "Peter";
                r8.LastName = "Stump";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r8.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Texas Instruments");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r8, "1XdmSV");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r8 = _db.Users.FirstOrDefault(u => u.UserName == "peterstump@hootmail.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r8, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r8, "Recruiter");
            }
            //save changes
            _db.SaveChanges();





            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r9 = _db.Users.FirstOrDefault(u => u.Email == "yhuik9.Taylor@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r9 == null)
            {
                r9 = new AppUser();
                r9.UserName = "yhuik9.Taylor@aool.com";
                r9.Email = "yhuik9.Taylor@aool.com";
                r9.FirstName = "Rachel";
                r9.LastName = "Taylor";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r9.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Hilton Worldwide");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r9, "9yhFS3");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r9 = _db.Users.FirstOrDefault(u => u.UserName == "yhuik9.Taylor@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r9, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r9, "Recruiter");
            }
            //save changes
            _db.SaveChanges();


            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r10 = _db.Users.FirstOrDefault(u => u.Email == "tuck33@ggmail.com");
            //if Recruiter hasn't been created, then add them
            if (r10 == null)
            {
                r10 = new AppUser();
                r10.UserName = "tuck33@ggmail.com";
                r10.Email = "tuck33@ggmail.com";
                r10.FirstName = "Clent";
                r10.LastName = "Tucker";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r10.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Aon");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r10, "I6BgsS");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r10 = _db.Users.FirstOrDefault(u => u.UserName == "tuck33@ggmail.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r10, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r10, "Recruiter");
            }
            //save changes
            _db.SaveChanges();









            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r11 = _db.Users.FirstOrDefault(u => u.Email == "taylordjay@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r11 == null)
            {
                r11 = new AppUser();
                r11.UserName = "taylordjay@aool.com";
                r11.Email = "taylordjay@aool.com";
                r11.FirstName = "Allison";
                r11.LastName = "Taylor";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r11.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Adlucent");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r11, "Vjb1wI");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r11 = _db.Users.FirstOrDefault(u => u.UserName == "taylordjay@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r11, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r11, "Recruiter");
            }
            //save changes
            _db.SaveChanges();





            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r12 = _db.Users.FirstOrDefault(u => u.Email == "jojoe@ggmail.com");
            //if Recruiter hasn't been created, then add them
            if (r12 == null)
            {
                r12 = new AppUser();
                r12.UserName = "jojoe@ggmail.com";
                r12.Email = "jojoe@ggmail.com";
                r12.FirstName = "Joe";
                r12.LastName = "Nguyen";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r12.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Stream Realty Partners");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r12, "xI8Brg");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r12 = _db.Users.FirstOrDefault(u => u.UserName == "jojoe@ggmail.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r12, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r12, "Recruiter");
            }
            //save changes
            _db.SaveChanges();







            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r13 = _db.Users.FirstOrDefault(u => u.Email == "hicks43@ggmail.com");
            //if Recruiter hasn't been created, then add them
            if (r13 == null)
            {
                r13 = new AppUser();
                r13.UserName = "hicks43@ggmail.com";
                r13.Email = "hicks43@ggmail.com";
                r13.FirstName = "Anthony";
                r13.LastName = "Hicks";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r13.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Microsoft");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r13, "s33WOz");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r13 = _db.Users.FirstOrDefault(u => u.UserName == "hicks43@ggmail.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r13, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r13, "Recruiter");
            }
            //save changes
            _db.SaveChanges();






            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r14 = _db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");
            //if Recruiter hasn't been created, then add them
            if (r14 == null)
            {
                r14 = new AppUser();
                r14.UserName = "orielly@foxnets.com";
                r14.Email = "orielly@foxnets.com";
                r14.FirstName = "Bill";
                r14.LastName = "O'Reilly";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r14.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Microsoft");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r14, "pS2OJh");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r14 = _db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r14, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r14, "Recruiter");
            }
            //save changes
            _db.SaveChanges();







            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r15 = _db.Users.FirstOrDefault(u => u.Email == "louielouie@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r15 == null)
            {
                r15 = new AppUser();
                r15.UserName = "louielouie@aool.com";
                r15.Email = "louielouie@aool.com";
                r15.FirstName = "Louis";
                r15.LastName = "Winthorpe";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r15.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Microsoft");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r15, "fq7yDw");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r15 = _db.Users.FirstOrDefault(u => u.UserName == "louielouie@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r15, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r15, "Recruiter");
            }
            //save changes
            _db.SaveChanges();



            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r16 = _db.Users.FirstOrDefault(u => u.Email == "smartinmartin.Martin@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r16 == null)
            {
                r16 = new AppUser();
                r16.UserName = "smartinmartin.Martin@aool.com";
                r16.Email = "smartinmartin.Martin@aool.com";
                r16.FirstName = "Gregory";
                r16.LastName = "Martinez";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r16.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Capital One");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r16, "1rKkMW");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r16 = _db.Users.FirstOrDefault(u => u.UserName == "smartinmartin.Martin@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r16, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r16, "Recruiter");
            }
            //save changes
            _db.SaveChanges();







            ////AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            //UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ////check to see if the Recruiter has been added
            AppUser r17 = _db.Users.FirstOrDefault(u => u.Email == "or@aool.com");
            //if Recruiter hasn't been created, then add them
            if (r17 == null)
            {
                r17 = new AppUser();
                r17.UserName = "or@aool.com";
                r17.Email = "or@aool.com";
                r17.FirstName = "Anka";
                r17.LastName = "Radkovich";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r17.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Capital One");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r17, "8K0cAh");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r17 = _db.Users.FirstOrDefault(u => u.UserName == "or@aool.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r17, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r17, "Recruiter");
            }
            //save changes
            _db.SaveChanges();





            AppUser r18 = _db.Users.FirstOrDefault(u => u.Email == "tanner@ggmail.com");
            //if Recruiter hasn't been created, then add them
            if (r18 == null)
            {
                r18 = new AppUser();
                r18.UserName = "tanner@ggmail.com";
                r18.Email = "tanner@ggmail.com";
                r18.FirstName = "Jeremy";
                r18.LastName = "Tanner";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r18.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "United Airlines");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r18, "w9wPff");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r18 = _db.Users.FirstOrDefault(u => u.UserName == "tanner@ggmail.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r18, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r18, "Recruiter");
            }
            //save changes
            _db.SaveChanges();





            AppUser r19 = _db.Users.FirstOrDefault(u => u.Email == "tee_frank@hootmail.com");
            //if Recruiter hasn't been created, then add them
            if (r19 == null)
            {
                r19 = new AppUser();
                r19.UserName = "tee_frank@hootmail.com";
                r19.Email = "tee_frank@hootmail.com";
                r19.FirstName = "Frank";
                r19.LastName = "Tee";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r19.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Academy Sports & Outdoors");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r19, "1EIwbx");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r19 = _db.Users.FirstOrDefault(u => u.UserName == "tee_frank@hootmail.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r19, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r19, "Recruiter");
            }
            //save changes
            _db.SaveChanges();



            AppUser r20 = _db.Users.FirstOrDefault(u => u.Email == "target_spot@example.com");
            //if Recruiter hasn't been created, then add them
            if (r20 == null)
            {
                r20 = new AppUser();
                r20.UserName = "target_spot@example.com";
                r20.Email = "target_spot@example.com";
                r20.FirstName = "Spot";
                r20.LastName = "Dog";
                //TODO: figure out the error that happens when I uncomment out the line beneath
                //cso.ApproverID = "OriginalCSOID";
                //TODO: Add additional fields that you created on the AppUser class
            }
            r20.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Target");
            try
            {
                IdentityResult result = await _userManager.CreateAsync(r20, "spotthedog");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            r20 = _db.Users.FirstOrDefault(u => u.UserName == "target_spot@example.com");
            //make sure user is in role
            if (await _userManager.IsInRoleAsync(r19, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(r19, "Recruiter");
            }
            //save changes
            _db.SaveChanges();
        }

    }
}