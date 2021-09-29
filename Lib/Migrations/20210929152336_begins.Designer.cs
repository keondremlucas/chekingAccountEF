﻿// <auto-generated />
using Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lib.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210929152336_begins")]
    partial class begins
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Lib.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Log")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Lib.Checking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Balance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Owner")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CheckingAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
