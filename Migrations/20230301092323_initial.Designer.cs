// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SanduJewel.Models;

#nullable disable

namespace SanduJewel.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230301092323_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("J_Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("J_Price")
                        .HasColumnType("int");

                    b.Property<int>("J_Weight")
                        .HasColumnType("int");

                    b.HasKey("J_number");

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

                    b.HasKey("O_ID");

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

                    b.Property<int>("P_Status")
                        .HasColumnType("int");

                    b.HasKey("P_ID");

                    b.ToTable("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
