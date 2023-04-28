﻿// <auto-generated />
using System;
using AutoKomis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoKomis.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasIndex("IdKomisu");

                    b.HasIndex("IdSprzedazy");

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

                    b.Property<int>("SprzedazIdSprzedazy")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdKlienta");

                    b.HasIndex("SprzedazIdSprzedazy");

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

                    b.HasIndex("IdKomisu");

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

                    b.HasIndex("IdKlienta");

                    b.ToTable("Sprzedaze");
                });

            modelBuilder.Entity("AutoKomis.Models.Auto", b =>
                {
                    b.HasOne("AutoKomis.Models.Komis", "Komis")
                        .WithMany("Auta")
                        .HasForeignKey("IdKomisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoKomis.Models.Sprzedaz", "Sprzedaz")
                        .WithMany("Auta")
                        .HasForeignKey("IdSprzedazy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Komis");

                    b.Navigation("Sprzedaz");
                });

            modelBuilder.Entity("AutoKomis.Models.Klient", b =>
                {
                    b.HasOne("AutoKomis.Models.Sprzedaz", "Sprzedaz")
                        .WithMany()
                        .HasForeignKey("SprzedazIdSprzedazy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sprzedaz");
                });

            modelBuilder.Entity("AutoKomis.Models.Pracownik", b =>
                {
                    b.HasOne("AutoKomis.Models.Komis", "Komis")
                        .WithMany("Pracownicy")
                        .HasForeignKey("IdKomisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Komis");
                });

            modelBuilder.Entity("AutoKomis.Models.Sprzedaz", b =>
                {
                    b.HasOne("AutoKomis.Models.Klient", "Klient")
                        .WithMany("Sprzedaze")
                        .HasForeignKey("IdKlienta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klient");
                });

            modelBuilder.Entity("AutoKomis.Models.Klient", b =>
                {
                    b.Navigation("Sprzedaze");
                });

            modelBuilder.Entity("AutoKomis.Models.Komis", b =>
                {
                    b.Navigation("Auta");

                    b.Navigation("Pracownicy");
                });

            modelBuilder.Entity("AutoKomis.Models.Sprzedaz", b =>
                {
                    b.Navigation("Auta");
                });
#pragma warning restore 612, 618
        }
    }
}
