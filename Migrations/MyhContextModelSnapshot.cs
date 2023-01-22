﻿// <auto-generated />
using System;
using MYH_Reports.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MYHReports.Migrations
{
    [DbContext(typeof(MyhContext))]
    partial class MyhContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MYH_Reports.Models.AccountsModel", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MYH_Reports.Models.AddressesModel", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TownCity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MYH_Reports.Models.ContactsModel", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("AccountId");

                    b.HasIndex("AddressId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("MYH_Reports.Models.EstimatesModel", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobTotal")
                        .HasColumnType("int");

                    b.Property<int>("LabourCost")
                        .HasColumnType("int");

                    b.Property<int>("MaterialCost")
                        .HasColumnType("int");

                    b.HasKey("JobId");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContactId");

                    b.ToTable("Estimates");
                });

            modelBuilder.Entity("MYH_Reports.Models.InvoicesModel", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobTotal")
                        .HasColumnType("int");

                    b.Property<int>("LabourCost")
                        .HasColumnType("int");

                    b.Property<int>("MaterialCost")
                        .HasColumnType("int");

                    b.HasKey("JobId");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContactId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("MYH_Reports.Models.JobDetailsModel", b =>
                {
                    b.Property<int>("JobDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobDetailId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstimatesModelJobId")
                        .HasColumnType("int");

                    b.Property<int?>("InvoicesModelJobId")
                        .HasColumnType("int");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaymentReceived")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<int?>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("JobDetailId");

                    b.HasIndex("EstimatesModelJobId");

                    b.HasIndex("InvoicesModelJobId");

                    b.ToTable("JobDetails");
                });

            modelBuilder.Entity("MYH_Reports.Models.ContactsModel", b =>
                {
                    b.HasOne("MYH_Reports.Models.AccountsModel", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("MYH_Reports.Models.AddressesModel", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Account");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("MYH_Reports.Models.EstimatesModel", b =>
                {
                    b.HasOne("MYH_Reports.Models.AddressesModel", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("MYH_Reports.Models.ContactsModel", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.Navigation("Address");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("MYH_Reports.Models.InvoicesModel", b =>
                {
                    b.HasOne("MYH_Reports.Models.AddressesModel", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("MYH_Reports.Models.ContactsModel", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.Navigation("Address");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("MYH_Reports.Models.JobDetailsModel", b =>
                {
                    b.HasOne("MYH_Reports.Models.EstimatesModel", null)
                        .WithMany("JobDetails")
                        .HasForeignKey("EstimatesModelJobId");

                    b.HasOne("MYH_Reports.Models.InvoicesModel", null)
                        .WithMany("JobDetails")
                        .HasForeignKey("InvoicesModelJobId");
                });

            modelBuilder.Entity("MYH_Reports.Models.EstimatesModel", b =>
                {
                    b.Navigation("JobDetails");
                });

            modelBuilder.Entity("MYH_Reports.Models.InvoicesModel", b =>
                {
                    b.Navigation("JobDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
