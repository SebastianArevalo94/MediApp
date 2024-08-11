using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediApp_API.Migrations
{
    /// <inheritdoc />
    public partial class AzureMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_Clinics_ClinicId",
                table: "Clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Doctors_DoctorId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Patients_PatientId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_DoctorId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Clinics_ClinicId",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "Clinics");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "Clinics",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientId",
                table: "Patients",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DoctorId",
                table: "Doctors",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_ClinicId",
                table: "Clinics",
                column: "ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_Clinics_ClinicId",
                table: "Clinics",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Doctors_DoctorId",
                table: "Doctors",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Patients_PatientId",
                table: "Patients",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }
    }
}
