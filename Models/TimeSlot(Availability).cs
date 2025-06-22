using System;
using System.ComponentModel.DataAnnotations;
using Doctor_Module.Models.Doctor;

namespace Doctor_Module.Timeslots
{
    public class Timeslot
{
    public int TimeSlotID { get; set; }

    [Required]
    public string DoctorID { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public string Date { get; set; }

    [Required]
    [DataType(DataType.Time)]
    public string Start_Time { get; set; }

    [Required]
    [DataType(DataType.Time)]
    public string End_Time { get; set; }

    public int count { get; set; }
    public Doctor? doctor { get; set; }
}

}
