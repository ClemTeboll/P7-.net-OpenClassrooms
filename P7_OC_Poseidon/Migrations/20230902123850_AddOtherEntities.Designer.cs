﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P7_OC_Poseidon.Data;

#nullable disable

namespace P7_OC_Poseidon.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230902123850_AddOtherEntities")]
    partial class AddOtherEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P7_OC_Poseidon.Models.BidList", b =>
                {
                    b.Property<int>("BidListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BidListId"));

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ask")
                        .HasColumnType("float");

                    b.Property<double>("AskQuantity")
                        .HasColumnType("float");

                    b.Property<string>("Benchmark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Bid")
                        .HasColumnType("float");

                    b.Property<DateTime>("BidListDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("BidQuantity")
                        .HasColumnType("float");

                    b.Property<string>("Book")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Commentary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RevisionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevisionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Security")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Side")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceListId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BidListId");

                    b.ToTable("BidLists");
                });

            modelBuilder.Entity("P7_OC_Poseidon.Models.CurvePoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AsOfDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurveId")
                        .HasColumnType("int");

                    b.Property<double>("Term")
                        .HasColumnType("float");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CurvePoints");
                });

            modelBuilder.Entity("P7_OC_Poseidon.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FitchRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoodysRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("SandPRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("P7_OC_Poseidon.Models.RuleName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Json")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SqlPart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SqlStr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RuleNames");
                });

            modelBuilder.Entity("P7_OC_Poseidon.Models.Trade", b =>
                {
                    b.Property<int>("TradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TradeId"));

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Benchmark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BuyPrice")
                        .HasColumnType("float");

                    b.Property<double>("BuyQuantity")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RevisionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevisionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Security")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SellPrice")
                        .HasColumnType("float");

                    b.Property<double>("SellQuantity")
                        .HasColumnType("float");

                    b.Property<string>("Side")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceListId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TradeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Trader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TradeId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("P7_OC_Poseidon.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
