﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project4.Models;

namespace Project4.Migrations
{
    [DbContext(typeof(EmployeeDataContext))]
    [Migration("20221027035142_Initital")]
    partial class Initital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30");

            modelBuilder.Entity("Project4.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AuthToWorkEmailSentDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ByuId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ByuName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassCode")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EFormSubmissionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmplRecord")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExpectedHours")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IncreaseInputDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("International")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastPayIncrease")
                        .HasColumnType("TEXT");

                    b.Property<bool>("NameChangeCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PayGradTuition")
                        .HasColumnType("INTEGER");

                    b.Property<float>("PayIncreaseAmount")
                        .HasColumnType("REAL");

                    b.Property<float>("PayRate")
                        .HasColumnType("REAL");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PositionType")
                        .HasColumnType("TEXT");

                    b.Property<bool>("QualtricsSurveySent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Semester")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SubmittedEForm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Supervisor")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Terminated")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TerminationDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("WorkAuthReceived")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.Property<string>("YearInProgram")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.ToTable("employees");
                });
#pragma warning restore 612, 618
        }
    }
}