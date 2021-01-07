using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public enum PositionType { I, FT };

    public enum AccountStatusEnum { Active, Deactivated};

    public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser
    {


        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        // Attributes for Students
        [Display(Name = "Major")]
        public Major MajorName { get; set; }

        [Display(Name = "Graduation Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime GraduationDate { get; set; }

        [Display(Name = "Position Type")]
        public PositionType Position { get; set; }

        [Display(Name = "GPA")]
        public Decimal GPA { get; set; }

        [DefaultValue("Active")]
        public AccountStatusEnum AccountStatus { get; set; }


        //Attributes for Recruiter
        [Display(Name = "Company Name")]
        public String CompanyName { get; set; }



        public Company Company { get; set; }
        public List<Position> Positions { get; set; }

        [InverseProperty("Interviewee")]
        public List<Interview> Interviews { get; set; }

        [InverseProperty("Interviewer")]
        public List<Interview> InterviewsGiven { get; set; }

        //public AppUser()
        //{
        //    if (Positions == null)
        //    {
        //        Positions = new List<Position>();
        //    }
        //    if (Interviews == null)
        //    {
        //        Interviews = new List<Interview>();
        //    }
        //    if (Interviewers == null)
        //    {
        //        Interviewers = new List<Interview>();
        //    }

        //}
    }
}
