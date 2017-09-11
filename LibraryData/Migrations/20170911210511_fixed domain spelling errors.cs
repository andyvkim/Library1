using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class fixeddomainspellingerrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibiraryBranches_BranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibiraryBranches_LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibiraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibiraryBranches",
                table: "LibiraryBranches");

            migrationBuilder.DropColumn(
                name: "LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.RenameTable(
                name: "LibiraryBranches",
                newName: "LibraryBranches");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "LibraryAssets",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBranches",
                table: "LibraryBranches",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAssets",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets",
                column: "LocationId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBranches",
                table: "LibraryBranches");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "LibraryAssets");

            migrationBuilder.RenameTable(
                name: "LibraryBranches",
                newName: "LibiraryBranches");

            migrationBuilder.AddColumn<int>(
                name: "LibraryBranchId",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibiraryBranches",
                table: "LibiraryBranches",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_LibraryBranchId",
                table: "LibraryAssets",
                column: "LibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibiraryBranches_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibiraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibiraryBranches_LibraryBranchId",
                table: "LibraryAssets",
                column: "LibraryBranchId",
                principalTable: "LibiraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibiraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibiraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
