using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;


namespace Final_Project_Group20_1.Seeding
{
    public class SeedStudent
    {
        public static async Task AddStudent(IServiceProvider serviceProvider)
        {

            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //String strStudent = "begin";

            AppUser s1 = _db.Users.FirstOrDefault(u => u.Email == "cbaker@example.com");

            if (s1 == null)
            {
                s1 = new AppUser();
                s1.FirstName = "Christopher";
                s1.LastName = "Baker";
                s1.Email = "cbaker@example.com";
                s1.UserName = "cbaker@example.com";
                s1.GraduationDate = new DateTime(2019);
                s1.Position = PositionType.FT;
                s1.GPA = 3.91m;
                s1.PhoneNumber = "1522757212";

            }


            s1.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s1, "bookworm");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s1 = _db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com");

            if (await _userManager.IsInRoleAsync(s1, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s1, "Student");
            }
            _db.SaveChanges();

            AppUser s2 = _db.Users.FirstOrDefault(u => u.Email == "banker@longhorn.net");

            if (s2 == null)
            {
                s2 = new AppUser();
                s2.FirstName = "Michelle";
                s2.LastName = "Banks";
                s2.Email = "banker@longhorn.net";
                s2.UserName = "banker@longhorn.net";
                s2.GraduationDate = new DateTime(2020);
                s2.Position = PositionType.I;
                s2.GPA = 3.52m;
                s2.PhoneNumber = "5962115872";

            }
            s2.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "International Business");

            try
            {
                var result = await _userManager.CreateAsync(s2, "aclfest2017");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }

            s2 = _db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net");
            if (await _userManager.IsInRoleAsync(s2, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s2, "Student");
            }
            _db.SaveChanges();


            AppUser s3 = _db.Users.FirstOrDefault(u => u.Email == "franco@example.com");

            if (s3 == null)
            {
                s3 = new AppUser();
                s3.FirstName = "Franco";
                s3.LastName = "Broccolo";
                s3.Email = "franco@example.com";
                s3.UserName = "franco@example.com";
                s3.GraduationDate = new DateTime(2019);
                s3.Position = PositionType.FT;
                s3.GPA = 3.2m;
                s3.PhoneNumber = "7569796344" ;
            }
            s3.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s3, "aggies");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);

            }
            s3 = _db.Users.FirstOrDefault(u => u.UserName == "franco@example.com");
            if (await _userManager.IsInRoleAsync(s3, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s3, "Student");
            }
            _db.SaveChanges();



            AppUser s4 = _db.Users.FirstOrDefault(u => u.Email == "wchang@example.com");

            if (s4 == null)
            {
                s4 = new AppUser();
                s4.FirstName = "Wendy";
                s4.LastName = "Chang";
                s4.Email = "wchang@example.com";
                s4.UserName = "wchang@example.com";
                s4.GraduationDate = new DateTime(2021);
                s4.Position = PositionType.I;
                s4.GPA = 3.56m;
                s4.PhoneNumber = "220-613-2686";
            }
            s4.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s4, "alaskaboy");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s4 = _db.Users.FirstOrDefault(u => u.UserName == "wchang@example.com");
            if (await _userManager.IsInRoleAsync(s4, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s4, "Student");
            }
            _db.SaveChanges();



            AppUser s5 = _db.Users.FirstOrDefault(u => u.Email == "limchou@gogle.com");

            if (s5 == null)
            {
                s5 = new AppUser();
                s5.FirstName = "Lim";
                s5.LastName = "Chou";
                s5.Email = "limchou@gogle.com";
                s5.UserName = "limchou@gogle.com";
                s5.GraduationDate = new DateTime(2020);
                s5.Position = PositionType.I;
                s5.GPA = 2.63m;
                s5.PhoneNumber = "7287179608";
            }

            s5.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s5, "allyrally");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s5 = _db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com");
            if (await _userManager.IsInRoleAsync(s5, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s5, "Student");
            }
            _db.SaveChanges();



            AppUser s6 = _db.Users.FirstOrDefault(u => u.Email == "shdixon@aoll.com");

            if (s6 == null)
            {
                s6 = new AppUser();
                s6.FirstName = "Shan";
                s6.LastName = "Dixon";
                s6.Email = "shdixon@aoll.com";
                s6.UserName = "shdixon@aoll.com";
                s6.GraduationDate = new DateTime(2022);
                s6.Position = PositionType.I;
                s6.GPA = 3.62m;
                s6.PhoneNumber = "3387967818";
            }
            s6.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "International Business");

            try
            {
                var result = await _userManager.CreateAsync(s6, "Anchorage");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s6 = _db.Users.FirstOrDefault(u => u.UserName == "shdixon@aoll.com");
            if (await _userManager.IsInRoleAsync(s6, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s6, "Student");
            }
            _db.SaveChanges();



            AppUser s7 = _db.Users.FirstOrDefault(u => u.Email == "j.b.evans@aheca.org");

            if (s7 == null)
            {
                s7 = new AppUser();
                s7.FirstName = "Jim Bob";
                s7.LastName = "Evans";
                s7.Email = "j.b.evans@aheca.org";
                s7.UserName = "j.b.evans@aheca.org";
                s7.GraduationDate = new DateTime(2019);
                s7.Position = PositionType.FT;
                s7.GPA = 2.64m;
                s7.PhoneNumber = "8789211122" ;
            
            }
            s7.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Accounting");

            try
            {
                var result = await _userManager.CreateAsync(s7, "billyboy");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s7 = _db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org");
            if (await _userManager.IsInRoleAsync(s7, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s7, "Student");
            }
            _db.SaveChanges();



            AppUser s8 = _db.Users.FirstOrDefault(u => u.Email == "feeley@penguin.org");

            if (s8 == null)
            {
                s8 = new AppUser();
                s8.FirstName = "Lou Ann";
                s8.LastName = "Feeley";
                s8.Email = "feeley@penguin.org";
                s8.UserName = "feeley@penguin.org";
                s8.GraduationDate = new DateTime(2020);
                s8.Position = PositionType.I;
                s8.GPA = 3.66m;
                s8.PhoneNumber = "3893643017";

            }


            s8.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Marketing");

            try
            {
                var result = await _userManager.CreateAsync(s8, "bunnyhop");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s8 = _db.Users.FirstOrDefault(u => u.UserName == "feeley@penguin.org");
            if (await _userManager.IsInRoleAsync(s8, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s8, "Student");
            }
            _db.SaveChanges();



            AppUser s9 = _db.Users.FirstOrDefault(u => u.Email == "tfreeley@minnetonka.ci.us");

            if (s9 == null)
            {
                s9 = new AppUser();
                s9.FirstName = "Tesa";
                s9.LastName = "Freeley";
                s9.Email = "tfreeley@minnetonka.ci.us";
                s9.UserName = "tfreeley@minnetonka.ci.us";
                s9.GraduationDate = new DateTime(2019);
                s9.Position = PositionType.FT;
                s9.GPA = 3.98m;
                s9.PhoneNumber = "3271054962";
            }
            s9.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Accounting");

            try
            {
                var result = await _userManager.CreateAsync(s9, "dustydusty");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s9 = _db.Users.FirstOrDefault(u => u.UserName == "tfreeley@minnetonka.ci.us");
            if (await _userManager.IsInRoleAsync(s9, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s9, "Student");
            }
            _db.SaveChanges();



            AppUser s10 = _db.Users.FirstOrDefault(u => u.Email == "mgarcia@gogle.com");

            if (s10 == null)
            {
                s10 = new AppUser();
                s10.FirstName = "Margaret";
                s10.LastName = "Garcia";
                s10.Email = "mgarcia@gogle.com";
                s10.UserName = "mgarcia@gogle.com";
                s10.GraduationDate = new DateTime(2019);
                s10.Position = PositionType.FT;
                s10.GPA = 3.22m;
                s10.PhoneNumber = "4809502469";
            }
            s10.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s10, "gowest");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s10 = _db.Users.FirstOrDefault(u => u.UserName == "mgarcia@gogle.com");
            if (await _userManager.IsInRoleAsync(s10, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s10, "Student");
            }
            _db.SaveChanges();


            AppUser s11 = _db.Users.FirstOrDefault(u => u.Email == "jeffh@sonic.com");

            if (s11 == null)
            {
                s11 = new AppUser();
                s11.FirstName = "Jeffrey";
                s11.LastName = "Hampton";
                s11.Email = "jeffh@sonic.com";
                s11.UserName = "jeffh@sonic.com";
                s11.GraduationDate = new DateTime(2020);
                s11.Position = PositionType.I;
                s11.GPA = 3.66m;
                s11.PhoneNumber = "2879892098" ;
            }
            s11.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Science and Technology Management");

            try
            {
                var result = await _userManager.CreateAsync(s11, "hickhickup");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s11 = _db.Users.FirstOrDefault(u => u.UserName == "jeffh@sonic.com");
            if (await _userManager.IsInRoleAsync(s11, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s11, "Student");
            }
            _db.SaveChanges();


            AppUser s12 = _db.Users.FirstOrDefault(u => u.Email == "wjhearniii@umich.org");
            if (s12 == null)
            {
                s12 = new AppUser();
                s12.FirstName = "John";
                s12.LastName = "Hearn";
                s12.Email = "wjhearniii@umich.org";
                s12.UserName = "wjhearniii@umich.org";
                s12.GraduationDate = new DateTime(2019);
                s12.Position = PositionType.FT;
                s12.GPA = 3.46m;
                s12.PhoneNumber = "7592476853";
            }
            s12.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Business Honors");

            try
            {
                var result = await _userManager.CreateAsync(s12, "ingram2015");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s12 = _db.Users.FirstOrDefault(u => u.UserName == "wjhearniii@umich.org");
            if (await _userManager.IsInRoleAsync(s12, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s12, "Student");
            }
            _db.SaveChanges();



            AppUser s13 = _db.Users.FirstOrDefault(u => u.Email == "ahick@yaho.com");

            if (s13 == null)
            {
                s13 = new AppUser();
                s13.FirstName = "Anthony";
                s13.LastName = "Hicks";
                s13.Email = "ahick@yaho.com";
                s13.UserName = "ahick@yaho.com";
                s13.GraduationDate = new DateTime(2020);
                s13.Position = PositionType.I;
                s13.GPA = 3.12m;
                s13.PhoneNumber = "6034479200" ;
            }
            s13.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Supply Chain Management");

            try
            {
                var result = await _userManager.CreateAsync(s13, "jhearn22");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s13 = _db.Users.FirstOrDefault(u => u.UserName == "ahick@yaho.com");
            if (await _userManager.IsInRoleAsync(s13, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s13, "Student");
            }
            _db.SaveChanges();



            AppUser s14 = _db.Users.FirstOrDefault(u => u.Email == "ingram@jack.com");

            if (s14 == null)
            {
                s14 = new AppUser();
                s14.FirstName = "Brad";
                s14.LastName = "Ingram";
                s14.Email = "ingram@jack.com";
                s14.UserName = "ingram@jack.com";
                s14.GraduationDate = new DateTime(2020);
                s14.Position = PositionType.I;
                s14.GPA = 3.72m;
                s14.PhoneNumber = "9659965936";
            }
            s14.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Supply Chain Management");

            try
            {
                var result = await _userManager.CreateAsync(s14, "joejoejoe");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s14 = _db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com");
            if (await _userManager.IsInRoleAsync(s14, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s14, "Student");
            }
            _db.SaveChanges();



            AppUser s15 = _db.Users.FirstOrDefault(u => u.Email == "toddj@yourmom.com");

            if (s15 == null)
            {
                s15 = new AppUser();
                s15.FirstName = "Todd";
                s15.LastName = "Jacobs";
                s15.Email = "toddj@yourmom.com";
                s15.UserName = "toddj@yourmom.com";
                s15.GraduationDate = new DateTime(2019);
                s15.Position = PositionType.FT;
                s15.GPA = 2.64m;
                s15.PhoneNumber = "1711551224" ;
            }
            s15.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s15, "jrod2017");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s15 = _db.Users.FirstOrDefault(u => u.UserName == "toddj@yourmom.com");
            if (await _userManager.IsInRoleAsync(s15, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s15, "Student");
            }
            _db.SaveChanges();



            AppUser s16 = _db.Users.FirstOrDefault(u => u.Email == "thequeen@aska.net");

            if (s16 == null)
            {
                s16 = new AppUser();
                s16.FirstName = "Victoria";
                s16.LastName = "Lawrence";
                s16.Email = "thequeen@aska.net";
                s16.UserName = "thequeen@aska.net";
                s16.GraduationDate = new DateTime(2021);
                s16.Position = PositionType.I;
                s16.GPA = 3.72m;
                s16.PhoneNumber = "3005643682";
            }
            s16.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s16, "longhorns");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s16 = _db.Users.FirstOrDefault(u => u.UserName == "thequeen@aska.net");
            if (await _userManager.IsInRoleAsync(s16, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s16, "Student");
            }
            _db.SaveChanges();



            AppUser s17 = _db.Users.FirstOrDefault(u => u.Email == "linebacker@gogle.com");

            if (s17 == null)
            {
                s17 = new AppUser();
                s17.FirstName = "Erik";
                s17.LastName = "Lineback";
                s17.Email = "linebacker@gogle.com";
                s17.UserName = "linebacker@gogle.com";
                s17.GraduationDate = new DateTime(2022);
                s17.Position = PositionType.I;
                s17.GPA = 3.15m;
                s17.PhoneNumber = "9683195113" ;
            }
            s17.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Accounting");

            try
            {
                var result = await _userManager.CreateAsync(s17, "louielouie");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s17 = _db.Users.FirstOrDefault(u => u.UserName == "linebacker@gogle.com");
            if (await _userManager.IsInRoleAsync(s17, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s17, "Student");
            }
            _db.SaveChanges();



            AppUser s18 = _db.Users.FirstOrDefault(u => u.Email == "elowe@netscare.net");

            if (s18 == null)
            {
                s18 = new AppUser();
                s18.FirstName = "Ernest";
                s18.LastName = "Lowe";
                s18.Email = "elowe@netscare.net";
                s18.UserName = "elowe@netscare.net";
                s18.GraduationDate = new DateTime(2019);
                s18.Position = PositionType.FT;
                s18.GPA = 3.07m;
                s18.PhoneNumber = "9324558010" ;
            }
            s18.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s18, "martin1234");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s18 = _db.Users.FirstOrDefault(u => u.UserName == "elowe@netscare.net");
            if (await _userManager.IsInRoleAsync(s18, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s18, "Student");
            }
            _db.SaveChanges();



            AppUser s19 = _db.Users.FirstOrDefault(u => u.Email == "cluce@gogle.com");

            if (s19 == null)
            {
                s19 = new AppUser();
                s19.FirstName = "Chuck";
                s19.LastName = "Luce";
                s19.Email = "cluce@gogle.com";
                s19.UserName = "cluce@gogle.com";
                s19.GraduationDate = new DateTime(2020);
                s19.Position = PositionType.I;
                s19.GPA = 3.87m;
                s19.PhoneNumber = "7826134758";
            }
            s19.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Accounting");

            try
            {
                var result = await _userManager.CreateAsync(s19, "meganr34");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s19 = _db.Users.FirstOrDefault(u => u.UserName == "cluce@gogle.com");
            if (await _userManager.IsInRoleAsync(s19, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s19, "Student");
            }
            _db.SaveChanges();



            AppUser s20 = _db.Users.FirstOrDefault(u => u.Email == "mackcloud@george.com");

            if (s20 == null)
            {
                s20 = new AppUser();
                s20.FirstName = "Jennifer";
                s20.LastName = "MacLeod";
                s20.Email = "mackcloud@george.com";
                s20.UserName = "mackcloud@george.com";
                s20.GraduationDate = new DateTime(2019);
                s20.Position = PositionType.FT;
                s20.GPA = 4m;
                s20.PhoneNumber = "2129419557" ;
            }

            s20.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s20, "meow88");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s20 = _db.Users.FirstOrDefault(u => u.UserName == "mackcloud@george.com");
            if (await _userManager.IsInRoleAsync(s20, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s20, "Student");
            }
            _db.SaveChanges();

            AppUser s21 = _db.Users.FirstOrDefault(u => u.Email == "cmartin@beets.com");

            if (s21 == null)
            {
                s21 = new AppUser();
                s21.FirstName = "Elizabeth";
                s21.LastName = "Markham";
                s21.Email = "cmartin@beets.com";
                s21.UserName = "cmartin@beets.com";
                s21.GraduationDate = new DateTime(2019);
                s21.Position = PositionType.FT;
                s21.GPA = 3.53m;
                s21.PhoneNumber = "7524570330" ;
            }
            s21.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Business Honors");

            try
            {
                var result = await _userManager.CreateAsync(s21, "mustangs");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s21 = _db.Users.FirstOrDefault(u => u.UserName == "cmartin@beets.com");
            if (await _userManager.IsInRoleAsync(s21, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s21, "Student");
            }
            _db.SaveChanges();



            AppUser s22 = _db.Users.FirstOrDefault(u => u.Email == "clarence@yoho.com");

            if (s22 == null)
            {
                s22 = new AppUser();
                s22.FirstName = "Clarence";
                s22.LastName = "Martin";
                s22.Email = "clarence@yoho.com";
                s22.UserName = "clarence@yoho.com";
                s22.GraduationDate = new DateTime(2020);
                s22.Position = PositionType.I;
                s22.GPA = 3.11m;
                s22.PhoneNumber = "5891468077" ;
            }
            s22.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Supply Chain Management");

            try
            {
                var result = await _userManager.CreateAsync(s22, "mydogspot");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s22 = _db.Users.FirstOrDefault(u => u.UserName == "clarence@yoho.com");
            if (await _userManager.IsInRoleAsync(s22, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s22, "Student");
            }
            _db.SaveChanges();



            AppUser s23 = _db.Users.FirstOrDefault(u => u.Email == "gregmartinez@drdre.com");

            if (s23 == null)
            {
                s23 = new AppUser();
                s23.FirstName = "Gregory";
                s23.LastName = "Martinez";
                s23.Email = "gregmartinez@drdre.com";
                s23.UserName = "gregmartinez@drdre.com";
                s23.GraduationDate = new DateTime(2021);
                s23.Position = PositionType.I;
                s23.GPA = 3.43m;
                s23.PhoneNumber = "6612897904" ;
            }
            s23.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Business Honors");

            try
            {
                var result = await _userManager.CreateAsync(s23, "nothinggood");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s23 = _db.Users.FirstOrDefault(u => u.UserName == "gregmartinez@drdre.com");
            if (await _userManager.IsInRoleAsync(s23, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s23, "Student");
            }
            _db.SaveChanges();



            AppUser s24 = _db.Users.FirstOrDefault(u => u.Email == "cmiller@bob.com");

            if (s24 == null)
            {
                s24 = new AppUser();
                s24.FirstName = "Charles";
                s24.LastName = "Miller";
                s24.Email = "cmiller@bob.com";
                s24.UserName = "cmiller@bob.com";
                s24.GraduationDate = new DateTime(2020);
                s24.Position = PositionType.I;
                s24.GPA = 3.14m;
                s24.PhoneNumber = "6658456330" ;
            }
            s24.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Management");

            try
            {
                var result = await _userManager.CreateAsync(s24, "onetime");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s24 = _db.Users.FirstOrDefault(u => u.UserName == "cmiller@bob.com");
            if (await _userManager.IsInRoleAsync(s24, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s24, "Student");
            }
            _db.SaveChanges();



            AppUser s25 = _db.Users.FirstOrDefault(u => u.Email == "knelson@aoll.com");

            if (s25 == null)
            {
                s25 = new AppUser();
                s25.FirstName = "Kelly";
                s25.LastName = "Nelson";
                s25.Email = "knelson@aoll.com";
                s25.UserName = "knelson@aoll.com";
                s25.GraduationDate = new DateTime(2019);
                s25.Position = PositionType.FT;
                s25.GPA = 3.03m;
                s25.PhoneNumber = "9305652673" ;
            }
            s25.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s25, "painting");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s25 = _db.Users.FirstOrDefault(u => u.UserName == "knelson@aoll.com");
            if (await _userManager.IsInRoleAsync(s25, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s25, "Student");
            }
            _db.SaveChanges();


            AppUser s26 = _db.Users.FirstOrDefault(u => u.Email == "joewin@xfactor.com");

            if (s26 == null)
            {
                s26 = new AppUser();
                s26.FirstName = "Joe";
                s26.LastName = "Nguyen";
                s26.Email = "joewin@xfactor.com";
                s26.UserName = "joewin@xfactor.com";
                s26.GraduationDate = new DateTime(2019);
                s26.Position = PositionType.FT;
                s26.GPA = 3.65m;
                s26.PhoneNumber = "4202569808" ;
            }
            s26.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Management");

            try
            {
                var result = await _userManager.CreateAsync(s26, "Password1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s26 = _db.Users.FirstOrDefault(u => u.UserName == "joewin@xfactor.com");
            if (await _userManager.IsInRoleAsync(s26, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s26, "Student");
            }
            _db.SaveChanges();



            AppUser s27 = _db.Users.FirstOrDefault(u => u.Email == "orielly@foxnews.cnn");

            if (s27 == null)
            {
                s27 = new AppUser();
                s27.FirstName = "Bill";
                s27.LastName = "O'Reilly";
                s27.Email = "orielly@foxnews.cnn";
                s27.UserName = "orielly@foxnews.cnn";
                s27.GraduationDate = new DateTime(2020);
                s27.Position = PositionType.I;
                s27.GPA = 3.46m;
                s27.PhoneNumber = "1753785467" ;
            }
            s27.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s27, "penguin12");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s27 = _db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnews.cnn");
            if (await _userManager.IsInRoleAsync(s27, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s27, "Student");
            }
            _db.SaveChanges();



            AppUser s28 = _db.Users.FirstOrDefault(u => u.Email == "ankaisrad@gogle.com");

            if (s28 == null)
            {
                s28 = new AppUser();
                s28.FirstName = "Anka";
                s28.LastName = "Radkovich";
                s28.Email = "ankaisrad@gogle.com";
                s28.UserName = "ankaisrad@gogle.com";
                s28.GraduationDate = new DateTime(2019);
                s28.Position = PositionType.FT;
                s28.GPA = 3.67m;
                s28.PhoneNumber = "1384661566";
            }
            s28.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Business Honors");

            try
            {
                var result = await _userManager.CreateAsync(s28, "pepperoni");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s28 = _db.Users.FirstOrDefault(u => u.UserName == "ankaisrad@gogle.com");

            if (await _userManager.IsInRoleAsync(s28, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s28, "Student");
            }
            _db.SaveChanges();

            AppUser s29 = _db.Users.FirstOrDefault(u => u.Email == "megrhodes@freserve.co.uk");

            if (s29 == null)
            {
                s29 = new AppUser();
                s29.FirstName = "Megan";
                s29.LastName = "Rhodes";
                s29.Email = "megrhodes@freserve.co.uk";
                s29.UserName = "megrhodes@freserve.co.uk";
                s29.GraduationDate = new DateTime(2020);
                s29.Position = PositionType.I;
                s29.GPA = 3.14m;
                s29.PhoneNumber = "6761638634" ;
            }
            s29.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Management");

            try
            {
                var result = await _userManager.CreateAsync(s29, "potato");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s29 = _db.Users.FirstOrDefault(u => u.UserName == "megrhodes@freserve.co.uk");
            if (await _userManager.IsInRoleAsync(s29, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s29, "Student");
            }
            _db.SaveChanges();



            AppUser s30 = _db.Users.FirstOrDefault(u => u.Email == "erynrice@aoll.com");

            if (s30 == null)
            {
                s30 = new AppUser();
                s30.FirstName = "Eryn";
                s30.LastName = "Rice";
                s30.Email = "erynrice@aoll.com";
                s30.UserName = "erynrice@aoll.com";
                s30.GraduationDate = new DateTime(2022);
                s30.Position = PositionType.I;
                s30.GPA = 3.92m;
                s30.PhoneNumber = "5892641451" ;
            }
            s30.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Marketing");

            try
            {
                var result = await _userManager.CreateAsync(s30, "radgirl");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s30 = _db.Users.FirstOrDefault(u => u.UserName == "erynrice@aoll.com");
            if (await _userManager.IsInRoleAsync(s30, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s30, "Student");
            }
            _db.SaveChanges();



            AppUser s31 = _db.Users.FirstOrDefault(u => u.Email == "jorge@noclue.com");

            if (s31 == null)
            {
                s31 = new AppUser();
                s31.FirstName = "Jorge";
                s31.LastName = "Rodriguez";
                s31.Email = "jorge@noclue.com";
                s31.UserName = "jorge@noclue.com";
                s31.GraduationDate = new DateTime(2021);
                s31.Position = PositionType.I;
                s31.GPA = 3.64m;
                s31.PhoneNumber = "5279194671" ;
            }
            s31.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s31, "raiders");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s31 = _db.Users.FirstOrDefault(u => u.UserName == "jorge@noclue.com");
            if (await _userManager.IsInRoleAsync(s31, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s31, "Student");
            }
            _db.SaveChanges();


            AppUser s32 = _db.Users.FirstOrDefault(u => u.Email == "mrrogers@lovelyday.com");

            if (s32 == null)
            {
                s32 = new AppUser();
                s32.FirstName = "Allen";
                s32.LastName = "Rogers";
                s32.Email = "mrrogers@lovelyday.com";
                s32.UserName = "mrrogers@lovelyday.com";
                s32.GraduationDate = new DateTime(2020);
                s32.Position = PositionType.I;
                s32.GPA = 3.01m;
                s32.PhoneNumber = "3935790324" ;
            }
            s32.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Marketing");

            try
            {
                var result = await _userManager.CreateAsync(s32, "ricearoni");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s32 = _db.Users.FirstOrDefault(u => u.UserName == "mrrogers@lovelyday.com");

            if (await _userManager.IsInRoleAsync(s32, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s32, "Student");
            }
            _db.SaveChanges();


            AppUser s33 = _db.Users.FirstOrDefault(u => u.Email == "stjean@athome.com");

            if (s33 == null)
            {
                s33 = new AppUser();
                s33.FirstName = "Olivier";
                s33.LastName = "Saint-Jean";
                s33.Email = "stjean@athome.com";
                s33.UserName = "stjean@athome.com";
                s33.GraduationDate = new DateTime(2019);
                s33.Position = PositionType.FT;
                s33.GPA = 3.24m;
                s33.PhoneNumber = "7219770922" ;
            }
            s33.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Science and Technology Management");

            try
            {
                var result = await _userManager.CreateAsync(s33, "rogerthat");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s33 = _db.Users.FirstOrDefault(u => u.UserName == "stjean@athome.com");
            if (await _userManager.IsInRoleAsync(s33, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s33, "Student");
            }
            _db.SaveChanges();


            AppUser s34 = _db.Users.FirstOrDefault(u => u.Email == "saunders@pen.com");

            if (s34 == null)
            {
                s34 = new AppUser();
                s34.FirstName = "Sarah";
                s34.LastName = "Saunders";
                s34.Email = "saunders@pen.com";
                s34.UserName = "saunders@pen.com";
                s34.GraduationDate = new DateTime(2020);
                s34.Position = PositionType.I;
                s34.GPA = 3.16m;
                s34.PhoneNumber = "7519398193" ;
            }
            s34.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Supply Chain Management");

            try
            {
                var result = await _userManager.CreateAsync(s34, "slowwind");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s34 = _db.Users.FirstOrDefault(u => u.UserName == "saunders@pen.com");
            if (await _userManager.IsInRoleAsync(s34, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s34, "Student");
            }
            _db.SaveChanges();



            AppUser s35 = _db.Users.FirstOrDefault(u => u.Email == "willsheff@email.com");

            if (s35 == null)
            {
                s35 = new AppUser();
                s35.FirstName = "William";
                s35.LastName = "Sewell";
                s35.Email = "willsheff@email.com";
                s35.UserName = "willsheff@email.com";
                s35.GraduationDate = new DateTime(2019);
                s35.Position = PositionType.FT;
                s35.GPA = 3.07m;
                s35.PhoneNumber = "2405366411";
            }
            s35.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s35, "smitty444");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s35 = _db.Users.FirstOrDefault(u => u.UserName == "willsheff@email.com");
            if (await _userManager.IsInRoleAsync(s35, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s35, "Student");
            }
            _db.SaveChanges();



            AppUser s36 = _db.Users.FirstOrDefault(u => u.Email == "sheffiled@gogle.com");

            if (s36 == null)
            {
                s36 = new AppUser();
                s36.FirstName = "Martin";
                s36.LastName = "Sheffield";
                s36.Email = "sheffiled@gogle.com";
                s36.UserName = "sheffiled@gogle.com";
                s36.GraduationDate = new DateTime(2020);
                s36.Position = PositionType.I;
                s36.GPA = 3.36m;
                s36.PhoneNumber = "3193248954";
            }
            s36.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s36, "snowsnow");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s36 = _db.Users.FirstOrDefault(u => u.UserName == "sheffiled@gogle.com");
            if (await _userManager.IsInRoleAsync(s36, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s36, "Student");
            }
            _db.SaveChanges();



            AppUser s37 = _db.Users.FirstOrDefault(u => u.Email == "johnsmith187@aoll.com");

            if (s37 == null)
            {
                s37 = new AppUser();
                s37.FirstName = "John";
                s37.LastName = "Smith";
                s37.Email = "johnsmith187@aoll.com";
                s37.UserName = "johnsmith187@aoll.com";
                s37.GraduationDate = new DateTime(2019);
                s37.Position = PositionType.FT;
                s37.GPA = 3.57m;
                s37.PhoneNumber = "8806737665" ;
            }
            s37.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s37, "something");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s37 = _db.Users.FirstOrDefault(u => u.UserName == "johnsmith187@aoll.com");
            if (await _userManager.IsInRoleAsync(s37, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s37, "Student");
            }
            _db.SaveChanges();



            AppUser s38 = _db.Users.FirstOrDefault(u => u.Email == "dustroud@mail.com");

            if (s38 == null)
            {
                s38 = new AppUser();
                s38.FirstName = "Dustin";
                s38.LastName = "Stroud";
                s38.Email = "dustroud@mail.com";
                s38.UserName = "dustroud@mail.com";
                s38.GraduationDate = new DateTime(2020);
                s38.Position = PositionType.I;
                s38.GPA = 3.49m;
                s38.PhoneNumber = "2246687934" ;
            }
            s38.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Marketing");

            try
            {
                var result = await _userManager.CreateAsync(s38, "spotmydog");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s38 = _db.Users.FirstOrDefault(u => u.UserName == "dustroud@mail.com");

            if (await _userManager.IsInRoleAsync(s38, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s38, "Student");
            }
            _db.SaveChanges();


            AppUser s39 = _db.Users.FirstOrDefault(u => u.Email == "estuart@anchor.net");

            if (s39 == null)
            {
                s39 = new AppUser();
                s39.FirstName = "Eric";
                s39.LastName = "Stuart";
                s39.Email = "estuart@anchor.net";
                s39.UserName = "estuart@anchor.net";
                s39.GraduationDate = new DateTime(2019);
                s39.Position = PositionType.FT;
                s39.GPA = 3.58m;
                s39.PhoneNumber = "7627728288";
            }
            s39.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Business Honors");

            try
            {
                var result = await _userManager.CreateAsync(s39, "stewball");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s39 = _db.Users.FirstOrDefault(u => u.UserName == "estuart@anchor.net");
            if (await _userManager.IsInRoleAsync(s39, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s39, "Student");
            }
            _db.SaveChanges();



            AppUser s40 = _db.Users.FirstOrDefault(u => u.Email == "peterstump@noclue.com");

            if (s40 == null)
            {
                s40 = new AppUser();
                s40.FirstName = "Peter";
                s40.LastName = "Stump";
                s40.Email = "peterstump@noclue.com";
                s40.UserName = "peterstump@noclue.com";
                s40.GraduationDate = new DateTime(2021);
                s40.Position = PositionType.I;
                s40.GPA = 2.55m;
                s40.PhoneNumber = "8375563954" ;
            }
            s40.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Supply Chain Management");

            try
            {
                var result = await _userManager.CreateAsync(s40, "tanner5454");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s40 = _db.Users.FirstOrDefault(u => u.UserName == "peterstump@noclue.com");
            
            if (await _userManager.IsInRoleAsync(s40, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s40, "Student");
            }
            _db.SaveChanges();



            AppUser s41 = _db.Users.FirstOrDefault(u => u.Email == "jtanner@mustang.net");

            if (s41 == null)
            {
                s41 = new AppUser();
                s41.FirstName = "Jeremy";
                s41.LastName = "Tanner";
                s41.Email = "jtanner@mustang.net";
                s41.UserName = "jtanner@mustang.net";
                s41.GraduationDate = new DateTime(2020);
                s41.Position = PositionType.I;
                s41.GPA = 3.16m;
                s41.PhoneNumber = "7726487173";

            }
            s41.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Management");

            try
            {
                var result = await _userManager.CreateAsync(s41, "taylorbaylor");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s41 = _db.Users.FirstOrDefault(u => u.UserName == "jtanner@mustang.net");

            if (await _userManager.IsInRoleAsync(s41, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s41, "Student");
            }
            _db.SaveChanges();


            AppUser s42 = _db.Users.FirstOrDefault(u => u.Email == "taylordjay@aoll.com");

            if (s42 == null)
            {
                s42 = new AppUser();
                s42.FirstName = "Allison";
                s42.LastName = "Taylor";
                s42.Email = "taylordjay@aoll.com";
                s42.UserName = "taylordjay@aoll.com";
                s42.GraduationDate = new DateTime(2019);
                s42.Position = PositionType.FT;
                s42.GPA = 3.07m;
                s42.PhoneNumber = "7999512316" ;
            }
            s42.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Marketing");

            try
            {
                var result = await _userManager.CreateAsync(s42, "teeoff22");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s42 = _db.Users.FirstOrDefault(u => u.UserName == "taylordjay@aoll.com");
            if (await _userManager.IsInRoleAsync(s42, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s42, "Student");
            }
            _db.SaveChanges();



            AppUser s43 = _db.Users.FirstOrDefault(u => u.Email == "rtaylor@gogle.com");

            if (s43 == null)
            {
                s43 = new AppUser();
                s43.FirstName = "Rachel";
                s43.LastName = "Taylor";
                s43.Email = "rtaylor@gogle.com";
                s43.UserName = "rtaylor@gogle.com";
                s43.GraduationDate = new DateTime(2020);
                s43.Position = PositionType.I;
                s43.GPA = 2.88m;
                s43.PhoneNumber = "6591890460";
            }
            s43.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s43, "texas1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s43 = _db.Users.FirstOrDefault(u => u.UserName == "rtaylor@gogle.com");

            if (await _userManager.IsInRoleAsync(s43, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s43, "Student");
            }
            _db.SaveChanges();


            AppUser s44 = _db.Users.FirstOrDefault(u => u.Email == "teefrank@noclue.com");

            if (s44 == null)
            {
                s44 = new AppUser();
                s44.FirstName = "Frank";
                s44.LastName = "Tee";
                s44.Email = "teefrank@noclue.com";
                s44.UserName = "teefrank@noclue.com";
                s44.GraduationDate = new DateTime(2019);
                s44.Position = PositionType.FT;
                s44.GPA = 3.5m;
                s44.PhoneNumber = "3242105709" ;
            }
            s44.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s44, "toddy25");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s44 = _db.Users.FirstOrDefault(u => u.UserName == "teefrank@noclue.com");

            if (await _userManager.IsInRoleAsync(s44, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s44, "Student");
            }

            _db.SaveChanges();

            AppUser s45 = _db.Users.FirstOrDefault(u => u.Email == "ctucker@alphabet.co.uk");

            if (s45 == null)
            {
                s45 = new AppUser();
                s45.FirstName = "Clent";
                s45.LastName = "Tucker";
                s45.Email = "ctucker@alphabet.co.uk";
                s45.UserName = "ctucker@alphabet.co.uk";
                s45.GraduationDate = new DateTime(2020);
                s45.Position = PositionType.I;
                s45.GPA = 3.04m;
                s45.PhoneNumber = "2998049719";
            }
            s45.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s45, "tucksack1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s45 = _db.Users.FirstOrDefault(u => u.UserName == "ctucker@alphabet.co.uk");

            if (await _userManager.IsInRoleAsync(s45, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s45, "Student");
            }
            _db.SaveChanges();


            AppUser s46 = _db.Users.FirstOrDefault(u => u.Email == "avelasco@yoho.com");

            if (s46 == null)
            {
                s46 = new AppUser();
                s46.FirstName = "Allen";
                s46.LastName = "Velasco";
                s46.Email = "avelasco@yoho.com";
                s46.UserName = "avelasco@yoho.com";
                s46.GraduationDate = new DateTime(2019);
                s46.Position = PositionType.FT;
                s46.GPA = 3.55m;
                s46.PhoneNumber = "7615192765" ;
            }

            s46.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "MIS");

            try
            {
                var result = await _userManager.CreateAsync(s46, "vinovino");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s46 = _db.Users.FirstOrDefault(u => u.UserName == "avelasco@yoho.com");
            if (await _userManager.IsInRoleAsync(s46, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s46, "Student");
            }
            _db.SaveChanges();



            AppUser s47 = _db.Users.FirstOrDefault(u => u.Email == "vinovino@grapes.com");

            if (s47 == null)
            {
                s47 = new AppUser();
                s47.FirstName = "Janet";
                s47.LastName = "Vino";
                s47.Email = "vinovino@grapes.com";
                s47.UserName = "vinovino@grapes.com";
                s47.GraduationDate = new DateTime(2021);
                s47.Position = PositionType.I;
                s47.GPA = 3.28m;
                s47.PhoneNumber = "7861517351" ;
            }
            s47.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Business Honors");

            try
            {
                var result = await _userManager.CreateAsync(s47, "whatever");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s47 = _db.Users.FirstOrDefault(u => u.UserName == "vinovino@grapes.com");
            if (await _userManager.IsInRoleAsync(s47, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s47, "Student");
            }
            _db.SaveChanges();


           

            AppUser s48 = _db.Users.FirstOrDefault(u => u.Email == "winner@hootmail.com");

            if (s48 == null)
            {
                s48 = new AppUser();
                s48.FirstName = "Louis";
                s48.LastName = "Winthorpe";
                s48.Email = "winner@hootmail.com";
                s48.UserName = "winner@hootmail.com";
                s48.GraduationDate = new DateTime(2019);
                s48.Position = PositionType.FT;
                s48.GPA = 2.57m;
                s48.PhoneNumber = "8658375028";
            }
            s48.MajorName = _db.Majors.FirstOrDefault(g => g.MajorName == "Finance");

            try
            {
                var result = await _userManager.CreateAsync(s48, "woodyman1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error adding user " + e.Message, e);
            }
            s48 = _db.Users.FirstOrDefault(u => u.UserName == "winner@hootmail.com");

            if (await _userManager.IsInRoleAsync(s48, "Student") == false)
            {
                await _userManager.AddToRoleAsync(s48, "Student");
            }

            _db.SaveChanges();



            //foreach (AppUser studentToAdd in AddStudent)
            //{
            //    strStudent = studentToAdd.UserName;
            //    AppUser dbStudent = _db.Users.FirstOrDefault(g => g.UserName == studentToAdd.UserName);
            //    if (dbStudent == null)
            //    {
            //        _db.Users.Add(studentToAdd);
            //        _db.SaveChanges();
            //    }
            //}


        }
    }
}