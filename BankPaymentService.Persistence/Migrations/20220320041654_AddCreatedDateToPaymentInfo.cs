using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankPaymentService.Persistence.Migrations
{
    public partial class AddCreatedDateToPaymentInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentInfos",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
