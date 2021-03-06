﻿// <auto-generated />
using System;
using HolidaySlug.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HolidaySlug.Data.Migrations
{
    [DbContext(typeof(HolidaySlugContext))]
    [Migration("20200131124824_addedRequiredUser_Holiday_addedIsManager_User")]
    partial class addedRequiredUser_Holiday_addedIsManager_User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HolidaySlug.Data.Entities.Holiday", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ApprovedByUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DaysUsed")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<string>("HolidayReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HolidayTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ApprovedByUserID");

                    b.HasIndex("HolidayTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("Holidays");
                });

            modelBuilder.Entity("HolidaySlug.Data.Entities.HolidayType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("HolidayTypes");
                });

            modelBuilder.Entity("HolidaySlug.Data.Entities.Teams", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("HolidaySlug.Data.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Entitlement")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsManager")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserTeamId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HolidaySlug.Data.Entities.UserTeam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ManagerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ManagerID");

                    b.HasIndex("UserID");

                    b.ToTable("UserTeams");
                });

            modelBuilder.Entity("HolidaySlug.Data.Entities.Holiday", b =>
                {
                    b.HasOne("HolidaySlug.Data.Entities.User", "ApprovedByUser")
                        .WithMany()
                        .HasForeignKey("ApprovedByUserID");

                    b.HasOne("HolidaySlug.Data.Entities.HolidayType", "HolidayType")
                        .WithMany()
                        .HasForeignKey("HolidayTypeID");

                    b.HasOne("HolidaySlug.Data.Entities.User", "User")
                        .WithMany("Holidays")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HolidaySlug.Data.Entities.User", b =>
                {
                    b.HasOne("HolidaySlug.Data.Entities.UserTeam", "UserTeam")
                        .WithMany()
                        .HasForeignKey("UserTeamId");
                });

            modelBuilder.Entity("HolidaySlug.Data.Entities.UserTeam", b =>
                {
                    b.HasOne("HolidaySlug.Data.Entities.User", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID");

                    b.HasOne("HolidaySlug.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
