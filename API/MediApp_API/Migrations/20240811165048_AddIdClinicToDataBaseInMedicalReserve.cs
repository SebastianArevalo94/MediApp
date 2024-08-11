using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediApp_API.Migrations
{
    /// <inheritdoc />
    public partial class AddIdClinicToDataBaseInMedicalReserve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Clinic",
                table: "MedicalReserves",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Clinic",
                table: "MedicalReserves");
        }
    }
}
