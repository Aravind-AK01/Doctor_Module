using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor_Module.Migrations
{
    /// <inheritdoc />
    public partial class AddFeedbackField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "Appointments",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "Appointments");
        }
    }
}
