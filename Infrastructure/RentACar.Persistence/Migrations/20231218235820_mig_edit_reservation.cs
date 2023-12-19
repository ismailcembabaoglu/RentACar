using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_edit_reservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Reservations_ReservationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Reservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ReservationId",
                table: "Reservations",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationId",
                table: "Reservations",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Reservations_ReservationId",
                table: "Reservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id");
        }
    }
}
