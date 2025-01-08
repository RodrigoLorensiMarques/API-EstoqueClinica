﻿// <auto-generated />
using API_ClinicStock.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_ClinicStock.Migrations
{
    [DbContext(typeof(StockContext))]
    [Migration("20250108180812_refactPropertiesV4")]
    partial class refactPropertiesV4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_ClinicStock.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("amount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("name");

                    b.Property<string>("Packaging")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("packaging");

                    b.HasKey("Id");

                    b.ToTable("material", (string)null);
                });

            modelBuilder.Entity("API_ClinicStock.Entities.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("amount");

                    b.Property<decimal>("Milligram")
                        .HasColumnType("INTEGER")
                        .HasColumnName("miligram");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("name");

                    b.Property<string>("Packaging")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("packaging");

                    b.HasKey("Id");

                    b.ToTable("medicine", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
