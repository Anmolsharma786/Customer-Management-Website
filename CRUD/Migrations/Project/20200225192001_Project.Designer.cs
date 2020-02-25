﻿// <auto-generated />
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.Migrations.Project
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20200225192001_Project")]
    partial class Project
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD.Models.ProjectRunning", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProjectManager")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("projectDeadline")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("EmployeeId");

                    b.ToTable("ProjectRunning");
                });
#pragma warning restore 612, 618
        }
    }
}
