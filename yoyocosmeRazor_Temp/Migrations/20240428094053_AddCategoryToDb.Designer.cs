﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yoyocosmeRazor_Temp.Data;

#nullable disable

namespace yoyocosmeRazor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240428094053_AddCategoryToDb")]
    partial class AddCategoryToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("yoyocosmeRazor_Temp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Face"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Eye"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Lip"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Nail"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Hair"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
