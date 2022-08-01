using Microsoft.EntityFrameworkCore.Migrations;

namespace Management1.Migrations
{
    public partial class _scheduleAppt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Resporpt",
                columns: table => new
                {
                    PatientID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    appointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicianComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    options = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Resporpt", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "_scheduleAppt",
                columns: table => new
                {
                    AppointmnetID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patientdetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__scheduleAppt", x => x.AppointmnetID);
                });

            migrationBuilder.CreateTable(
                name: "_viewpt",
                columns: table => new
                {
                    AppointmnetID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicianDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__viewpt", x => x.AppointmnetID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Resporpt");

            migrationBuilder.DropTable(
                name: "_scheduleAppt");

            migrationBuilder.DropTable(
                name: "_viewpt");
        }
    }
}
