﻿// <auto-generated />
using System;
using AutoKomis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoKomis.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220329160846_Init_Database")]
    partial class Init_Database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("AutoKomis.Models.Auto", b =>
                {
                    b.Property<int>("IdSamochodu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("CzyDostepny")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdKomisu")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdSprzedazy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IloscDrzwi")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Kolor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PojemnoscSilnika")
                        .HasColumnType("REAL");

                    b.Property<string>("Przebieg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RodzajPaliwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RokProdukcji")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("Segment")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypNadwozia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdSamochodu");

                    b.ToTable("Auta");
                });

            modelBuilder.Entity("AutoKomis.Models.Klient", b =>
                {
                    b.Property<int>("IdKlienta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NrDowodu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdKlienta");

                    b.ToTable("Klienci");
                });

            modelBuilder.Entity("AutoKomis.Models.Komis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImieWlasciciela")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KRS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KodPocztowy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("KosztyUtrzymanieMiesieczne")
                        .HasColumnType("TEXT");

                    b.Property<string>("Miasto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NIP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NazwiskoWlasciciela")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ulica")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Komis");
                });

            modelBuilder.Entity("AutoKomis.Models.Pracownik", b =>
                {
                    b.Property<int>("IdPracownika")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdKomisu")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NrDowodu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Stanowisko")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdPracownika");

                    b.ToTable("Pracownicy");
                });

            modelBuilder.Entity("AutoKomis.Models.Sprzedaz", b =>
                {
                    b.Property<int>("IdSprzedazy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataZawarciaUmowy")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdKlienta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPracownika")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdSamochodu")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Kwota")
                        .HasColumnType("TEXT");

                    b.HasKey("IdSprzedazy");

                    b.ToTable("Sprzedaze");
                });
#pragma warning restore 612, 618
        }
    }
}
