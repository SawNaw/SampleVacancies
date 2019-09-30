﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleVacancies.Data;

namespace SampleVacancies.Data.Migrations
{
    [DbContext(typeof(SampleVacanciesDbContext))]
    partial class SampleVacanciesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleVacancies.Core.Models.Vacancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacancies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "Sales",
                            Description = "This is a wonderful opportunity for an up-and-coming manager.",
                            JobTitle = "Manager",
                            Location = "Manchester",
                            Salary = "£50,000"
                        },
                        new
                        {
                            Id = 3,
                            Department = "Human Resources",
                            Description = "Calling all skilled accountants to this exciting opportunity.",
                            JobTitle = "Accountant",
                            Location = "Salford",
                            Salary = "£45,000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
