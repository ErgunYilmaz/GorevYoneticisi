using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class dropApUsrI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyPlans_AspNetUsers_AppUserID",
                table: "DailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_MontlyPlans_AspNetUsers_AppUserID",
                table: "MontlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeeklyPlans_AspNetUsers_AppUserID",
                table: "WeeklyPlans");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "WeeklyPlans",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_WeeklyPlans_AppUserID",
                table: "WeeklyPlans",
                newName: "IX_WeeklyPlans_AppUserId");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "MontlyPlans",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MontlyPlans_AppUserID",
                table: "MontlyPlans",
                newName: "IX_MontlyPlans_AppUserId");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "DailyPlans",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyPlans_AppUserID",
                table: "DailyPlans",
                newName: "IX_DailyPlans_AppUserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "WeeklyPlans",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "MontlyPlans",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "DailyPlans",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyPlans_AspNetUsers_AppUserId",
                table: "DailyPlans",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MontlyPlans_AspNetUsers_AppUserId",
                table: "MontlyPlans",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeeklyPlans_AspNetUsers_AppUserId",
                table: "WeeklyPlans",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyPlans_AspNetUsers_AppUserId",
                table: "DailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_MontlyPlans_AspNetUsers_AppUserId",
                table: "MontlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeeklyPlans_AspNetUsers_AppUserId",
                table: "WeeklyPlans");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "WeeklyPlans",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_WeeklyPlans_AppUserId",
                table: "WeeklyPlans",
                newName: "IX_WeeklyPlans_AppUserID");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "MontlyPlans",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_MontlyPlans_AppUserId",
                table: "MontlyPlans",
                newName: "IX_MontlyPlans_AppUserID");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "DailyPlans",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_DailyPlans_AppUserId",
                table: "DailyPlans",
                newName: "IX_DailyPlans_AppUserID");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserID",
                table: "WeeklyPlans",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserID",
                table: "MontlyPlans",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserID",
                table: "DailyPlans",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyPlans_AspNetUsers_AppUserID",
                table: "DailyPlans",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MontlyPlans_AspNetUsers_AppUserID",
                table: "MontlyPlans",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeeklyPlans_AspNetUsers_AppUserID",
                table: "WeeklyPlans",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
