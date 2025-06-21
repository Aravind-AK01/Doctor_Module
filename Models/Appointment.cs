using System;
using System.ComponentModel.DataAnnotations;
using Doctor_Module.Models.Doctor;

public class Appointment
{
    // [Required(false)]
    // public string? ID { get; set; }
    [Key]
    public int AppointmentID { get; set; }
    public string DoctorID { get; set; }
    public string DoctorName { get; set; }
    public string Specialization { get; set; }
    // public DateTime Date_Time { get; set; }
    public string Emergency { get; set; }
    public string Status { get; set; } = "Pending";
    public string? Prescription { get; set; } = "none";
    public string Prescription_ID { get; set; } = Guid.NewGuid().ToString();
    public string Patient_ID { get; set; }
    public string Issue { get; set; }
    public string?Feedback{ get; set; }
}
