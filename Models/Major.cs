using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
   
{
    public class Major
    {
        public int MajorID { get; set; }

        public String MajorName { get; set; }

        [Required]
        public List<MajorPosition> MajorPositions { get; set; }

        public List<AppUser> Students { get; set; }

        public Major()
        {
            if (MajorPositions == null)
            {
                MajorPositions = new List<MajorPosition>();
            }

        }
    }
}
