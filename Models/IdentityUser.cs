using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public enum UserType { CSO, Student, Recruiter }

    public class IdentityUser
    {
        [Required(ErrorMessage = "Type of User is required.")]
        public UserType UserType { get; set; }
        
    }
}
