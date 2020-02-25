﻿// <auto-generated />
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD.Models.Employeecs", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("gender")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("lName")
                        .HasColumnType("varchar(10)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
