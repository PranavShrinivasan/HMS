using NUnit.Framework;



namespace Management1UnitTesting.Test
{
    [TestFixture]
    public class ScheduleAppointmentEntityShould
    {
        [Test]
        public void CreateNew_ScheduleAppointment_VieConstructor()
        {
            //Arrange
            string AppointmnetID = "1";
            string PatientName = "pranav";
            string EmailId = "abc@gmail.com";
            string DoctorType= "Neurologist";
            string PhoneNumber = "192345678";
            string Gender = "male";
            string Age = "23";
            string AppointmentDate = "2022-09-02";
            string BloodGroup = "B";
            string Username = "pranav";
            string Patientdetails = "fever";


            //Act
            Management1.Models.ScheduleAppoinment test = new Management1.Models.ScheduleAppoinment();

            test.AppointmnetID = AppointmnetID;
            test.PatientName = PatientName;
            test.EmailId = EmailId;
            test.DoctorType = DoctorType;
            test.PhoneNumber = PhoneNumber;
            test.Gender = Gender;
            test.Age = Age;
            test.AppointmentDate = AppointmentDate;
            test.BloodGroup = BloodGroup;
            test.Username = Username;
            test.Patientdetails = Patientdetails;



            //Assert
            Assert.That(test, Is.Not.Null);
            Assert.That(test, Is.InstanceOf<Management1.Models.ScheduleAppoinment>());
            Assert.That(test.AppointmnetID, Is.EqualTo(AppointmnetID));
            Assert.That(test.PatientName, Is.EqualTo(PatientName));
            Assert.That(test.EmailId, Is.EqualTo(EmailId));
            Assert.That(test.DoctorType, Is.EqualTo(DoctorType));
            Assert.That(test.PhoneNumber, Is.EqualTo(PhoneNumber));
            Assert.That(test.Gender, Is.EqualTo(Gender));
            Assert.That(test.Age, Is.EqualTo(Age));
            Assert.That(test.AppointmentDate, Is.EqualTo(AppointmentDate));
            Assert.That(test.BloodGroup, Is.EqualTo(BloodGroup));
            Assert.That(test.Username, Is.EqualTo(Username));
            Assert.That(test.Patientdetails, Is.EqualTo(Patientdetails));

        }
    }
}