﻿// <auto-generated />
using System;
using BAKERY.Infrastructure.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BAKERY.Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("BAKERY.Domain.Entites.Bun", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BakingDate")
                        .HasColumnType("TEXT");

                    b.Property<double>("BeginPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("HoursCountForSale")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SaleDeadline")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Buns");
                });
#pragma warning restore 612, 618
        }
    }
}
