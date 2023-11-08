﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mixandmatchv3;

#nullable disable

namespace mixandmatchv3.Migrations
{
    [DbContext(typeof(MMContext))]
    partial class MMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DTO.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("zipcode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("ID");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("DTO.Job", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Hiring_Manageridid")
                        .HasColumnType("int");

                    b.Property<int>("companyidID")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("end")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.HasIndex("Hiring_Manageridid");

                    b.HasIndex("companyidID");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("DTO.hiring_manager", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("companyidID")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("phonenumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.HasIndex("companyidID");

                    b.ToTable("hiring_Managers");
                });

            modelBuilder.Entity("DTO.jobrequirements", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("jobIdid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("id");

                    b.HasIndex("jobIdid");

                    b.ToTable("jobrequirements");
                });

            modelBuilder.Entity("DTO.Job", b =>
                {
                    b.HasOne("DTO.hiring_manager", "Hiring_Managerid")
                        .WithMany()
                        .HasForeignKey("Hiring_Manageridid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Company", "companyid")
                        .WithMany()
                        .HasForeignKey("companyidID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hiring_Managerid");

                    b.Navigation("companyid");
                });

            modelBuilder.Entity("DTO.hiring_manager", b =>
                {
                    b.HasOne("DTO.Company", "companyid")
                        .WithMany()
                        .HasForeignKey("companyidID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("companyid");
                });

            modelBuilder.Entity("DTO.jobrequirements", b =>
                {
                    b.HasOne("DTO.Job", "jobId")
                        .WithMany()
                        .HasForeignKey("jobIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("jobId");
                });
#pragma warning restore 612, 618
        }
    }
}
