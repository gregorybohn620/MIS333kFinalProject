using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public class MajorPosition
    {
        [Required]
        public int MajorPositionID { get; set; }
        public Major Major { get; set; }
        public Position Position { get; set; }
    }
}
