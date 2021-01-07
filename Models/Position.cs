using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public class Position
    {
        [Display(Name = "Position ID")]
        [Required(ErrorMessage = "Position ID Required")]
        public Int32 PositionID { get; set; }


        [Display(Name = "Position Title")]
        [Required(ErrorMessage = "Position Title Required")]
        public String PositionTitle { get; set; }


        [Display(Name = "Position Type")]
        [Required(ErrorMessage = "Position Type Required")]
        public PositionType PositionType { get; set; }


        [Display(Name = "Position Location")]
        [Required(ErrorMessage = "Position Location Required")]
        public String Location { get; set; }


        [Display(Name = "Applicable Majors")]
        [Required(ErrorMessage = "Applicable Majors Required")]
        public List<Major>Majors { get; set; }

        [Display(Name = "Deadline")]
        [Required(ErrorMessage = " Deadline Required")]
        public DateTime Deadline { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description Required")]
        public String PositionDescription { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name Required")]

        public Company Company { get; set; }
        public AppUser AppUser { get; set; }
        public List<Application> Applications { get; set; }
        public List<MajorPosition> MajorPositions { get; set; }
        public List<Interview> Interviews { get; set; }
        //public List<Interview> Interviewers { get; set; }

        public Position()
        {
            if (Applications == null)
            {
                Applications = new List<Application>();
            }
            if (MajorPositions == null)
            {
                MajorPositions = new List<MajorPosition>();
            }
            if (Interviews == null)
            {
                Interviews = new List<Interview>();
            }
        }


    }
}
