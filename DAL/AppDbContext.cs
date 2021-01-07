
using Final_Project_Group20_1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.DAL
{
 
    public class AppDbContext : IdentityDbContext<AppUser>   //<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<MajorPosition> MajorPositions { get; set; }
        public DbSet<Position> Positions { get; set; }

       // public DbSet<AppUser> AppUsers { get; set; }
    }
    
}
