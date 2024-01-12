﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RentACar.Persistence.Context;

#nullable disable

namespace RentACar.Persistence.Migrations
{
    [DbContext(typeof(RentACarPsqlDbContext))]
    [Migration("20240110225247_mig_caroptions_update")]
    partial class mig_caroptions_update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RentACar.Domain.Models.BaseModels.BaseModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Decription")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("RentACar.Domain.Models.Car", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("CarPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("CarYear")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Depozit")
                        .HasColumnType("numeric");

                    b.Property<int>("Door")
                        .HasColumnType("integer");

                    b.Property<string>("DrivingLicense")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FuelType")
                        .HasColumnType("integer");

                    b.Property<bool>("IsAc")
                        .HasColumnType("boolean");

                    b.Property<string>("Luggage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Person")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<decimal>("TotalKm")
                        .HasColumnType("numeric");

                    b.Property<string>("gear")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("RentACar.Domain.Models.CarLocation", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid");

                    b.HasIndex("CarId");

                    b.HasIndex("LocationId");

                    b.ToTable("CarLocations");
                });

            modelBuilder.Entity("RentACar.Domain.Models.CarOption", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OptionId")
                        .HasColumnType("uuid");

                    b.HasIndex("CarId");

                    b.HasIndex("OptionId");

                    b.ToTable("CarOptions");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Location", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Option", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("OpsiyonName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("OpsiyonPrice")
                        .HasColumnType("numeric");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Reservation", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<decimal?>("AdditionalProductPrice")
                        .HasColumnType("numeric");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("RentPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasIndex("CarId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("RentACar.Domain.Models.ReservationOption", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<int?>("OptionCount")
                        .HasColumnType("integer");

                    b.Property<Guid>("OptionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("TotalOptionPrice")
                        .HasColumnType("numeric");

                    b.HasIndex("OptionId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationOptions");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Service", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("RentACar.Domain.Models.User", b =>
                {
                    b.HasBaseType("RentACar.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("EMailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RentACar.Domain.Models.CarLocation", b =>
                {
                    b.HasOne("RentACar.Domain.Models.Car", "Car")
                        .WithMany("CarLocations")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RentACar.Domain.Models.Location", "Location")
                        .WithMany("CarLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("RentACar.Domain.Models.CarOption", b =>
                {
                    b.HasOne("RentACar.Domain.Models.Car", "Car")
                        .WithMany("CarOptions")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RentACar.Domain.Models.Option", "Option")
                        .WithMany("CarOptions")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Option");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Reservation", b =>
                {
                    b.HasOne("RentACar.Domain.Models.Car", "Car")
                        .WithMany("Reservations")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("RentACar.Domain.Models.ReservationOption", b =>
                {
                    b.HasOne("RentACar.Domain.Models.Option", "Option")
                        .WithMany("ReservationOptions")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RentACar.Domain.Models.Reservation", "Reservation")
                        .WithMany("ReservationOptions")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Car", b =>
                {
                    b.Navigation("CarLocations");

                    b.Navigation("CarOptions");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Location", b =>
                {
                    b.Navigation("CarLocations");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Option", b =>
                {
                    b.Navigation("CarOptions");

                    b.Navigation("ReservationOptions");
                });

            modelBuilder.Entity("RentACar.Domain.Models.Reservation", b =>
                {
                    b.Navigation("ReservationOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
