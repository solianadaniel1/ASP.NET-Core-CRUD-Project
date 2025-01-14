﻿// <auto-generated />
using ASP.Net_Project_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.Net_Project_2.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20250114122125_One-One relationship Migration")]
    partial class OneOnerelationshipMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP.Net_Project_2.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SerialNumberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Name = "microphone",
                            Price = 40.0,
                            SerialNumberId = 10
                        });
                });

            modelBuilder.Entity("ASP.Net_Project_2.Models.SerialNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique()
                        .HasFilter("[ItemId] IS NOT NULL");

                    b.ToTable("SerialNumbers");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            ItemId = 4,
                            Name = "RIC150"
                        });
                });

            modelBuilder.Entity("ASP.Net_Project_2.Models.SerialNumber", b =>
                {
                    b.HasOne("ASP.Net_Project_2.Models.Item", "Item")
                        .WithOne("SerialNumber")
                        .HasForeignKey("ASP.Net_Project_2.Models.SerialNumber", "ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ASP.Net_Project_2.Models.Item", b =>
                {
                    b.Navigation("SerialNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
