using System;
using Doctor_Module.Models.Doctor;

namespace Doctor_Module.Timeslots
{
    public class Timeslot
    {
        public int TimeSlotID { get; set; }
        public string DoctorID { get; set; }
        public string Date { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public int count { get; set; }
        public Doctor doctor { get; set; }
    }
}
