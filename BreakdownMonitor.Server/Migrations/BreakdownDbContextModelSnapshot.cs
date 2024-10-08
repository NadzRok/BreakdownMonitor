﻿// <auto-generated />
using System;
using BreakdownMonitor.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BreakdownMonitor.Server.Migrations
{
    [DbContext(typeof(BreakdownDbContext))]
    partial class BreakdownDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BreakdownMonitor.Server.Entities.Breakdown", b =>
                {
                    b.Property<Guid>("BreakdownReference")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BreakdownDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BreakdownReference");

                    b.ToTable("Breakdown", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
