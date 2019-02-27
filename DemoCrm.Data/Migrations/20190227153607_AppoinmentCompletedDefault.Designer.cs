﻿// <auto-generated />
using System;
using DemoCrm.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoCrm.Data.Migrations
{
    [DbContext(typeof(DemoCrmDBContext))]
    [Migration("20190227153607_AppoinmentCompletedDefault")]
    partial class AppoinmentCompletedDefault
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoCrm.Data.Entities.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AppointLocationId");

                    b.Property<Guid>("AppointTypeId");

                    b.Property<string>("AppointmentAddress")
                        .HasMaxLength(500);

                    b.Property<Guid>("AppointmentLocationId");

                    b.Property<Guid>("AppointmentTypeId");

                    b.Property<string>("ContactPersonFullName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<Guid>("CustomerAccountId");

                    b.Property<bool>("IsCompleted");

                    b.Property<Guid>("StaffMemberId");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("AppointLocationId");

                    b.HasIndex("AppointTypeId");

                    b.HasIndex("CustomerAccountId");

                    b.HasIndex("StaffMemberId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.AppointmentLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("AppointmentLocations");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.AppointmentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("AppointmentTypes");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.BusinessLead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<Guid>("StaffMemberId");

                    b.HasKey("Id");

                    b.HasIndex("StaffMemberId");

                    b.ToTable("BusinessLeads");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<Guid>("CrmUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("ObjectTypeId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("CrmUserId");

                    b.HasIndex("ObjectTypeId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.CrmObjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("CrmObjectTypes");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.CrmUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<Guid>("OauthId");

                    b.Property<int>("ObjectTypeId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("OauthId")
                        .IsUnique();

                    b.HasIndex("ObjectTypeId");

                    b.ToTable("CrmUsers");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.CustomerAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<Guid>("CompanyId");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<Guid>("StaffMemberId");

                    b.Property<string>("VatNumber")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("StaffMemberId");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.CustomerContact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerAccountId");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Position")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("CustomerContacts");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CompanyId");

                    b.Property<Guid?>("ManagerId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.StaffMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DepartmentId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<bool>("IsManager");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<Guid>("StaffPositionId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("StaffPositionId");

                    b.ToTable("StaffMembers");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.StaffPosition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("StaffPositions");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.Appointment", b =>
                {
                    b.HasOne("DemoCrm.Data.Entities.AppointmentLocation", "AppointmentLocation")
                        .WithMany()
                        .HasForeignKey("AppointLocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCrm.Data.Entities.AppointmentType", "AppointmentType")
                        .WithMany()
                        .HasForeignKey("AppointTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCrm.Data.Entities.CustomerAccount", "CustomerAccount")
                        .WithMany()
                        .HasForeignKey("CustomerAccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCrm.Data.Entities.StaffMember", "StaffMember")
                        .WithMany()
                        .HasForeignKey("StaffMemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.BusinessLead", b =>
                {
                    b.HasOne("DemoCrm.Data.Entities.StaffMember", "LeadManager")
                        .WithMany()
                        .HasForeignKey("StaffMemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.Company", b =>
                {
                    b.HasOne("DemoCrm.Data.Entities.CrmUser", "CrmUser")
                        .WithMany()
                        .HasForeignKey("CrmUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCrm.Data.Entities.CrmObjectType", "ObjectType")
                        .WithMany()
                        .HasForeignKey("ObjectTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.CrmUser", b =>
                {
                    b.HasOne("DemoCrm.Data.Entities.CrmObjectType", "ObjectType")
                        .WithMany()
                        .HasForeignKey("ObjectTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.CustomerAccount", b =>
                {
                    b.HasOne("DemoCrm.Data.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCrm.Data.Entities.StaffMember", "AccountManager")
                        .WithMany()
                        .HasForeignKey("StaffMemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.Department", b =>
                {
                    b.HasOne("DemoCrm.Data.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCrm.Data.Entities.StaffMember", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("DemoCrm.Data.Entities.StaffMember", b =>
                {
                    b.HasOne("DemoCrm.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoCrm.Data.Entities.StaffPosition", "StaffPosition")
                        .WithMany()
                        .HasForeignKey("StaffPositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
