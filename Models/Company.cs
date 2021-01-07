using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public class Company
    {
        [Display(Name = "Company ID")]
        [Required(ErrorMessage = "Company ID is required")]
        public Int32 CompanyID { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name is required")]
        public String CompanyName { get; set; }

        public List<Interview> Interviews { get; set; }

        //Should Industry be a string or an enum??
        [Display(Name = "Company Industry")]
        [Required(ErrorMessage = "Industry is required")]
        public String CompanyIndustry { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "Company Description is required")]
        public String CompanyDescription { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Company Email is required")]
        public String CompanyEmail { get; set; }


        //AppUser as Recruiter
        public List<AppUser> AppUsers { get; set; }
        public List<Position> Positions { get; set; }

        public Company()
        {
            if (AppUsers == null)
            {
                AppUsers = new List<AppUser>();
            }
            if (Positions == null)
            {
                Positions = new List<Position>();
            }
        }

    }
}
