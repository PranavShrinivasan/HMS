using System.ComponentModel.DataAnnotations;

namespace Management1.Models
{
    public class ScheduleAppoinment
    {
        [Key]
        public string AppointmnetID { get; set; }
        public string PatientName { get; set; }
        public string EmailId { get; set; }
        public string DoctorType { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string AppointmentDate { get; set; }
        public string BloodGroup { get; set; }
        public string Username { get; set; }
        public string Patientdetails { get; set; }
    }

    public class ViewPatient
    {
        [Key]
        public string AppointmnetID { get; set; }
        public string PatientName { get; set; }
        public string EmailId { get; set; }
        public string DoctorType { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string AppointmentDate { get; set; }
        public string BloodGroup { get; set; }
        public string PatientUserID { get; set; }
        public string DoctorId { get; set; }
        public string Description { get; set; }
        public string TechnicianDescription { get; set; }
    }

    public class ResponseReport
    {
        [Key]
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string appointmentDate { get; set; }
        public string DoctorID { get; set; }
        public string PhoneNumber { get; set; }
        public string TechnicianComment { get; set; }
        public string AttachmentName { get; set; }
        public string options { get; set; }
    }
}
