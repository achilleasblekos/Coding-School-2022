﻿// <auto-generated />
using System;
using App.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.EF.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20220323174335_EngineerRelashionships")]
    partial class EngineerRelashionships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("App.Models.Entities.Car", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CarRegNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("ID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("App.Models.Entities.Credential", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("App.Models.Entities.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("App.Models.Entities.Engineer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ManagerID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SallaryPerMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("App.Models.Entities.Manager", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SallaryPerMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("App.Models.Entities.ServiceTask", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Hours")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("ServiceTasks");
                });

            modelBuilder.Entity("App.Models.Entities.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ManagerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("App.Models.Entities.TransactionLine", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EngineerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Hours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ServiceTaskID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TransactionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("EngineerID");

                    b.HasIndex("ServiceTaskID");

                    b.HasIndex("TransactionID");

                    b.ToTable("TransactionLine");
                });

            modelBuilder.Entity("App.Models.Entities.Engineer", b =>
                {
                    b.HasOne("App.Models.Entities.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("App.Models.Entities.Transaction", b =>
                {
                    b.HasOne("App.Models.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Entities.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("App.Models.Entities.TransactionLine", b =>
                {
                    b.HasOne("App.Models.Entities.Engineer", "Engineer")
                        .WithMany()
                        .HasForeignKey("EngineerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Entities.ServiceTask", "ServiceTask")
                        .WithMany()
                        .HasForeignKey("ServiceTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Entities.Transaction", "Transaction")
                        .WithMany("TransactionLines")
                        .HasForeignKey("TransactionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("ServiceTask");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("App.Models.Entities.Transaction", b =>
                {
                    b.Navigation("TransactionLines");
                });
#pragma warning restore 612, 618
        }
    }
}
