using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public enum ApplicationStatusList {Accepted, Rejected, Pending, Withdrawn};
    public class Application
    {

        [Required(ErrorMessage = "Application ID Required")]
        public Int32 ApplicationID { get; set; }
        

        [DefaultValue("Pending")]
        public ApplicationStatusList AppStatus { get; set; }

        public Position Position { get; set; }
        //public Company Company { get; set; }
        public AppUser AppUser { get; set; }
    }
}
