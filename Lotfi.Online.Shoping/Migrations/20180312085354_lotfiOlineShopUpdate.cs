using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Lotfi.OnlineShoping.Migrations
{
    public partial class lotfiOlineShopUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Peyment",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Order",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Category",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Peyment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Peyment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Peyment");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Peyment");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Peyment",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Order",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "CategoryID");
        }
    }
}
