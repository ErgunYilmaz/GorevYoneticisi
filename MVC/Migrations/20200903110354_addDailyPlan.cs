using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class addDailyPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "weeklyPlan",
                table: "WeeklyPlans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mountlyPlan",
                table: "MontlyPlans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dailyPlan",
                table: "DailyPlans",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "weeklyPlan",
                table: "WeeklyPlans");

            migrationBuilder.DropColumn(
                name: "mountlyPlan",
                table: "MontlyPlans");

            migrationBuilder.DropColumn(
                name: "dailyPlan",
                table: "DailyPlans");
        }
    }
}
