using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Models
{
    public enum RoomNumber { One, Two,Three, Four };
    public enum HourlySlot { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Eleven, Thirteen, Fourteen, Fifteen, Sixteen, Seventeen, Eigthteen};
    public enum SlotStatus { Filled, Open };

    public class Interview
    {
        public Int32 InterviewID { get; set; }

        [Display(Name = "Room Number")]
        public RoomNumber RoomNumber { get; set;}

        [Display(Name = "Hour Slot")]
        public HourlySlot HourlySlot { get; set; }

        [Display(Name = "Interview Time")]
        public DateTime InterviewTime { get; set; }

        [DefaultValue("Open")]
        public SlotStatus SlotStatus { get; set; }

        public string IntervieweeName { get; set; }
        public string InterviewerName { get; set; }


        public Position Positions { get; set; }
        public Company Company { get; set; }

        //App User as Student
        //One app User Student can have only one interview with for each positon
        public AppUser Interviewee { get; set; }
        public AppUser Interviewer { get; set; }


    }
}
