using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public class Industry
    {
        [Key]
        public int IndustryID { get; set; }
        public String CompanyIndustry{ get; set; }

        public Company Company { get; set; }

    }
}
