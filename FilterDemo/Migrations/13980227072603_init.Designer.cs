﻿// <auto-generated />
using FilterDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilterDemo.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("13980227072603_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("FilterDemo.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Summary");

                    b.Property<int>("ViewCount");

                    b.Property<int>("YearProduction");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pulp Fiction",
                            Summary = "folks guys..",
                            ViewCount = 0,
                            YearProduction = 1994
                        },
                        new
                        {
                            Id = 2,
                            Name = "Titanic",
                            Summary = "big boat...",
                            ViewCount = 0,
                            YearProduction = 1997
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
