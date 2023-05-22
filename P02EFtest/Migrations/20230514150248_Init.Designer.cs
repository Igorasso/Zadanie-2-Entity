﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P02EFtest.Data;

#nullable disable

namespace P02EFtest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230514150248_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("P02EFtest.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Pracownicy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Krańcowa 2",
                            Email = "korwin@mikke.pl",
                            Name = "jan Kowalski"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Kuperowa 5",
                            Email = "korwin@kowalski.pl",
                            Name = "janita Marianka"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
