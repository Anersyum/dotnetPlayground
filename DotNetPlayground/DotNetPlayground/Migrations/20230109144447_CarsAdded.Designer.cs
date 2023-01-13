﻿// <auto-generated />
using System;
using DotNetPlayground.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetPlayground.Migrations
{
    [DbContext(typeof(Baza))]
    [Migration("20230109144447_CarsAdded")]
    partial class CarsAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("DotNetPlayground.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DatumKreiranja")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumKreiranja = new DateOnly(2023, 1, 9),
                            Marka = "Audi",
                            Tip = "Karavan"
                        },
                        new
                        {
                            Id = 2,
                            DatumKreiranja = new DateOnly(2023, 1, 9),
                            Marka = "Škoda",
                            Tip = "Limuzina"
                        },
                        new
                        {
                            Id = 3,
                            DatumKreiranja = new DateOnly(2023, 1, 9),
                            Marka = "Toyota",
                            Tip = "Džip"
                        },
                        new
                        {
                            Id = 4,
                            DatumKreiranja = new DateOnly(2023, 1, 9),
                            Marka = "VW",
                            Tip = "SUV"
                        });
                });

            modelBuilder.Entity("DotNetPlayground.Models.Maca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Godine")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vrsta")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Mace");
                });

            modelBuilder.Entity("DotNetPlayground.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FavouriteFood")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FavouriteFood = "Krompir",
                            FirstName = "Amor",
                            LastName = "Osmić"
                        },
                        new
                        {
                            Id = 2,
                            FavouriteFood = "Pizza",
                            FirstName = "Sara",
                            LastName = "Šahinpašić"
                        },
                        new
                        {
                            Id = 3,
                            FavouriteFood = "Špagete",
                            FirstName = "Ines",
                            LastName = "Osmić"
                        },
                        new
                        {
                            Id = 4,
                            FavouriteFood = "Burek",
                            FirstName = "Jasko",
                            LastName = "Kreho"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
