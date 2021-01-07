﻿// <auto-generated />
using System;
using Final_Project_Group20_1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Project_Group20_1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190510151638_SeedIdentity")]
    partial class SeedIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Final_Project_Group20_1.Models.Application", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppStatus");

                    b.Property<string>("AppUserId");

                    b.Property<int?>("PositionID");

                    b.HasKey("ApplicationID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PositionID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("AccountStatus");

                    b.Property<int?>("CompanyID");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<decimal>("GPA");

                    b.Property<DateTime>("GraduationDate");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int?>("MajorNameMajorID");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("Position");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyID");

                    b.HasIndex("MajorNameMajorID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyDescription")
                        .IsRequired();

                    b.Property<string>("CompanyEmail")
                        .IsRequired();

                    b.Property<string>("CompanyIndustry")
                        .IsRequired();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.HasKey("CompanyID");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Interview", b =>
                {
                    b.Property<int>("InterviewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyID");

                    b.Property<int>("HourlySlot");

                    b.Property<DateTime>("InterviewTime");

                    b.Property<string>("IntervieweeId");

                    b.Property<string>("IntervieweeName");

                    b.Property<string>("InterviewerId");

                    b.Property<string>("InterviewerName");

                    b.Property<int?>("PositionsPositionID");

                    b.Property<int>("RoomNumber");

                    b.Property<int>("SlotStatus");

                    b.HasKey("InterviewID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("IntervieweeId");

                    b.HasIndex("InterviewerId");

                    b.HasIndex("PositionsPositionID");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Major", b =>
                {
                    b.Property<int>("MajorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MajorName");

                    b.Property<int?>("PositionID");

                    b.HasKey("MajorID");

                    b.HasIndex("PositionID");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.MajorPosition", b =>
                {
                    b.Property<int>("MajorPositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MajorID");

                    b.Property<int?>("PositionID");

                    b.HasKey("MajorPositionID");

                    b.HasIndex("MajorID");

                    b.HasIndex("PositionID");

                    b.ToTable("MajorPositions");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<int>("CompanyID");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("PositionDescription")
                        .IsRequired();

                    b.Property<string>("PositionTitle")
                        .IsRequired();

                    b.Property<int>("PositionType");

                    b.HasKey("PositionID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CompanyID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Application", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("Final_Project_Group20_1.Models.Position", "Position")
                        .WithMany("Applications")
                        .HasForeignKey("PositionID");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.AppUser", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.Company", "Company")
                        .WithMany("AppUsers")
                        .HasForeignKey("CompanyID");

                    b.HasOne("Final_Project_Group20_1.Models.Major", "MajorName")
                        .WithMany("Students")
                        .HasForeignKey("MajorNameMajorID");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Interview", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.Company", "Company")
                        .WithMany("Interviews")
                        .HasForeignKey("CompanyID");

                    b.HasOne("Final_Project_Group20_1.Models.AppUser", "Interviewee")
                        .WithMany("Interviews")
                        .HasForeignKey("IntervieweeId");

                    b.HasOne("Final_Project_Group20_1.Models.AppUser", "Interviewer")
                        .WithMany("InterviewsGiven")
                        .HasForeignKey("InterviewerId");

                    b.HasOne("Final_Project_Group20_1.Models.Position", "Positions")
                        .WithMany("Interviews")
                        .HasForeignKey("PositionsPositionID");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Major", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.Position")
                        .WithMany("Majors")
                        .HasForeignKey("PositionID");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.MajorPosition", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.Major", "Major")
                        .WithMany("MajorPositions")
                        .HasForeignKey("MajorID");

                    b.HasOne("Final_Project_Group20_1.Models.Position", "Position")
                        .WithMany("MajorPositions")
                        .HasForeignKey("PositionID");
                });

            modelBuilder.Entity("Final_Project_Group20_1.Models.Position", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.AppUser", "AppUser")
                        .WithMany("Positions")
                        .HasForeignKey("AppUserId");

                    b.HasOne("Final_Project_Group20_1.Models.Company", "Company")
                        .WithMany("Positions")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Final_Project_Group20_1.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Final_Project_Group20_1.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
