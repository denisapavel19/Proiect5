﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect5.Data;

#nullable disable

namespace Proiect5.Migrations
{
    [DbContext(typeof(Proiect5Context))]
    partial class Proiect5ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect5.Models.Elev", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("clasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nr_tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("parinteid")
                        .HasColumnType("int");

                    b.Property<string>("prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scoala")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("varsta")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("parinteid");

                    b.ToTable("Elev");
                });

            modelBuilder.Entity("Proiect5.Models.Materie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("clasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Materie");
                });

            modelBuilder.Entity("Proiect5.Models.MaterieProfesor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("materieid")
                        .HasColumnType("int");

                    b.Property<int?>("profesorid")
                        .HasColumnType("int");

                    b.Property<string>("sedinta_fizica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sedinta_online")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("tarif")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("materieid");

                    b.HasIndex("profesorid");

                    b.ToTable("MaterieProfesor");
                });

            modelBuilder.Entity("Proiect5.Models.Parinte", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nr_tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Parinte");
                });

            modelBuilder.Entity("Proiect5.Models.Profesor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("adresa_sediu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adresa_zoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nr_tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("specializare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Proiect5.Models.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nota")
                        .HasColumnType("int");

                    b.Property<int?>("parinteid")
                        .HasColumnType("int");

                    b.Property<int?>("profesorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("parinteid");

                    b.HasIndex("profesorid");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Proiect5.Models.SedintaMeditatie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("inceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("sfarsit")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("SedintaMeditatie");
                });

            modelBuilder.Entity("Proiect5.Models.Elev", b =>
                {
                    b.HasOne("Proiect5.Models.Parinte", "parinte")
                        .WithMany("elev")
                        .HasForeignKey("parinteid");

                    b.Navigation("parinte");
                });

            modelBuilder.Entity("Proiect5.Models.MaterieProfesor", b =>
                {
                    b.HasOne("Proiect5.Models.Materie", "materie")
                        .WithMany("materieprofesor")
                        .HasForeignKey("materieid");

                    b.HasOne("Proiect5.Models.Profesor", "profesor")
                        .WithMany("materieprofesor")
                        .HasForeignKey("profesorid");

                    b.Navigation("materie");

                    b.Navigation("profesor");
                });

            modelBuilder.Entity("Proiect5.Models.Review", b =>
                {
                    b.HasOne("Proiect5.Models.Parinte", "parinte")
                        .WithMany("review")
                        .HasForeignKey("parinteid");

                    b.HasOne("Proiect5.Models.Profesor", "profesor")
                        .WithMany("review")
                        .HasForeignKey("profesorid");

                    b.Navigation("parinte");

                    b.Navigation("profesor");
                });

            modelBuilder.Entity("Proiect5.Models.Materie", b =>
                {
                    b.Navigation("materieprofesor");
                });

            modelBuilder.Entity("Proiect5.Models.Parinte", b =>
                {
                    b.Navigation("elev");

                    b.Navigation("review");
                });

            modelBuilder.Entity("Proiect5.Models.Profesor", b =>
                {
                    b.Navigation("materieprofesor");

                    b.Navigation("review");
                });
#pragma warning restore 612, 618
        }
    }
}
