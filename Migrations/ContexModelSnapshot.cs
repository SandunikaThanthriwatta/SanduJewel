﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SanduJewel.Models;

#nullable disable

namespace SanduJewel.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SanduJewel.Models.Customer", b =>
                {
                    b.Property<int>("C_NIC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("C_Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("C_BirthDay")
                        .HasColumnType("int");

                    b.Property<int>("C_Contact_Number")
                        .HasColumnType("int");

                    b.Property<string>("C_Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("C_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("C_NIC");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SanduJewel.Models.Jewellery", b =>
                {
                    b.Property<int>("J_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("C_ID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerC_NIC")
                        .HasColumnType("int");

                    b.Property<string>("J_Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("J_Price")
                        .HasColumnType("int");

                    b.Property<int>("J_Weight")
                        .HasColumnType("int");

                    b.Property<string>("OwnerO_Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("J_number");

                    b.HasIndex("CustomerC_NIC");

                    b.HasIndex("OwnerO_Name");

                    b.ToTable("Jewelleries");
                });

            modelBuilder.Entity("SanduJewel.Models.Order", b =>
                {
                    b.Property<int>("O_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("O_Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PaymentP_ID")
                        .HasColumnType("int");

                    b.HasKey("O_ID");

                    b.HasIndex("PaymentP_ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SanduJewel.Models.Owner", b =>
                {
                    b.Property<string>("O_Name")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("O_Contact_Number")
                        .HasColumnType("int");

                    b.Property<string>("O_Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("O_Name");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("SanduJewel.Models.Payment", b =>
                {
                    b.Property<int>("P_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("P_Date")
                        .HasColumnType("int");

                    b.Property<string>("P_Method")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("P_Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("P_ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("SanduJewel.Models.Jewellery", b =>
                {
                    b.HasOne("SanduJewel.Models.Customer", "Customer")
                        .WithMany("Jewelleries")
                        .HasForeignKey("CustomerC_NIC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SanduJewel.Models.Owner", "Owner")
                        .WithMany("Jewelleries")
                        .HasForeignKey("OwnerO_Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("SanduJewel.Models.Order", b =>
                {
                    b.HasOne("SanduJewel.Models.Payment", null)
                        .WithMany("Orders")
                        .HasForeignKey("PaymentP_ID");
                });

            modelBuilder.Entity("SanduJewel.Models.Customer", b =>
                {
                    b.Navigation("Jewelleries");
                });

            modelBuilder.Entity("SanduJewel.Models.Owner", b =>
                {
                    b.Navigation("Jewelleries");
                });

            modelBuilder.Entity("SanduJewel.Models.Payment", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
