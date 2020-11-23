﻿// <auto-generated />
using System;
using FamilyTreeWebAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilyTreeWebAPI.Migrations
{
    [DbContext(typeof(FamilyMembersContext))]
    [Migration("20201121205658_INitialCreate2")]
    partial class INitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LoginExample.Models.Family.Child.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPartOfFamily")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.ChildInterest", b =>
                {
                    b.Property<int>("ChildId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InterestId")
                        .HasColumnType("TEXT");

                    b.HasKey("ChildId", "InterestId");

                    b.HasIndex("InterestId");

                    b.ToTable("ChildInterest");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.Interest", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("Interest");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.Pet.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChildId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPartOfFamily")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Models.Adult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPartOfFamily")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Adult");
                });

            modelBuilder.Entity("Models.Family", b =>
                {
                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StreetName", "HouseNumber");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.Child", b =>
                {
                    b.HasOne("Models.Family", null)
                        .WithMany("Children")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.ChildInterest", b =>
                {
                    b.HasOne("LoginExample.Models.Family.Child.Child", "Child")
                        .WithMany("ChildInterests")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoginExample.Models.Family.Child.Interest", "Interest")
                        .WithMany("ChildInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("Interest");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.Pet.Pet", b =>
                {
                    b.HasOne("LoginExample.Models.Family.Child.Child", null)
                        .WithMany("Pets")
                        .HasForeignKey("ChildId");

                    b.HasOne("Models.Family", null)
                        .WithMany("Pets")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("Models.Adult", b =>
                {
                    b.HasOne("Models.Family", null)
                        .WithMany("Adults")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.Child", b =>
                {
                    b.Navigation("ChildInterests");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("LoginExample.Models.Family.Child.Interest", b =>
                {
                    b.Navigation("ChildInterests");
                });

            modelBuilder.Entity("Models.Family", b =>
                {
                    b.Navigation("Adults");

                    b.Navigation("Children");

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}