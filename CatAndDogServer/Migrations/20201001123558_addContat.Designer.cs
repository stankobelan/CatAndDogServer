﻿// <auto-generated />
using System;
using CatAndDogServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatAndDogServer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201001123558_addContat")]
    partial class addContat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CatAndDogServer.Models.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumNarodenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetOwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PocetKrmeni")
                        .HasColumnType("int");

                    b.Property<int>("PocetMaciatok")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumNarodenia = new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat 12A",
                            PetOwnerId = 1,
                            PocetKrmeni = 1,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 2,
                            DatumNarodenia = new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat 23A",
                            PetOwnerId = 1,
                            PocetKrmeni = 2,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 3,
                            DatumNarodenia = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat A15",
                            PetOwnerId = 1,
                            PocetKrmeni = 3,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 4,
                            DatumNarodenia = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat 15A",
                            PetOwnerId = 1,
                            PocetKrmeni = 5,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 5,
                            DatumNarodenia = new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat 118A",
                            PetOwnerId = 1,
                            PocetKrmeni = 5,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 6,
                            DatumNarodenia = new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat 135A",
                            PetOwnerId = 1,
                            PocetKrmeni = 4,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 7,
                            DatumNarodenia = new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat A1558",
                            PetOwnerId = 1,
                            PocetKrmeni = 6,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 8,
                            DatumNarodenia = new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat 1651A",
                            PetOwnerId = 1,
                            PocetKrmeni = 8,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 9,
                            DatumNarodenia = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat A15",
                            PetOwnerId = 1,
                            PocetKrmeni = 7,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 10,
                            DatumNarodenia = new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat A115",
                            PetOwnerId = 1,
                            PocetKrmeni = 9,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 11,
                            DatumNarodenia = new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat Acd",
                            PetOwnerId = 1,
                            PocetKrmeni = 9,
                            PocetMaciatok = 1
                        },
                        new
                        {
                            Id = 12,
                            DatumNarodenia = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat daA",
                            PetOwnerId = 1,
                            PocetKrmeni = 10,
                            PocetMaciatok = 2
                        },
                        new
                        {
                            Id = 13,
                            DatumNarodenia = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat cdsaA",
                            PetOwnerId = 1,
                            PocetKrmeni = 11,
                            PocetMaciatok = 2
                        },
                        new
                        {
                            Id = 14,
                            DatumNarodenia = new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat csaA",
                            PetOwnerId = 1,
                            PocetKrmeni = 12,
                            PocetMaciatok = 2
                        },
                        new
                        {
                            Id = 15,
                            DatumNarodenia = new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cat Acs",
                            PetOwnerId = 1,
                            PocetKrmeni = 1,
                            PocetMaciatok = 2
                        });
                });

            modelBuilder.Entity("CatAndDogServer.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Answered")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CatAndDogServer.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumNarodenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetOwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PocetKrmeni")
                        .HasColumnType("int");

                    b.Property<int>("PocetUhriznuti")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumNarodenia = new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog xY",
                            PetOwnerId = 1,
                            PocetKrmeni = 2,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 2,
                            DatumNarodenia = new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog xY",
                            PetOwnerId = 1,
                            PocetKrmeni = 3,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 3,
                            DatumNarodenia = new DateTime(2013, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog 5Y",
                            PetOwnerId = 1,
                            PocetKrmeni = 1,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 4,
                            DatumNarodenia = new DateTime(2017, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog x6",
                            PetOwnerId = 1,
                            PocetKrmeni = 10,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 5,
                            DatumNarodenia = new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog 4Y",
                            PetOwnerId = 1,
                            PocetKrmeni = 2,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 6,
                            DatumNarodenia = new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog 8Y",
                            PetOwnerId = 1,
                            PocetKrmeni = 5,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 7,
                            DatumNarodenia = new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog 9Y",
                            PetOwnerId = 1,
                            PocetKrmeni = 7,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 8,
                            DatumNarodenia = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog x7",
                            PetOwnerId = 1,
                            PocetKrmeni = 8,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 9,
                            DatumNarodenia = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog 1Y",
                            PetOwnerId = 1,
                            PocetKrmeni = 9,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 10,
                            DatumNarodenia = new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog a12BS",
                            PetOwnerId = 1,
                            PocetKrmeni = 10,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 11,
                            DatumNarodenia = new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog aa56S",
                            PetOwnerId = 1,
                            PocetKrmeni = 2,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 12,
                            DatumNarodenia = new DateTime(2013, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog aa45S",
                            PetOwnerId = 1,
                            PocetKrmeni = 3,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 13,
                            DatumNarodenia = new DateTime(2017, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog aa12S",
                            PetOwnerId = 1,
                            PocetKrmeni = 5,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 14,
                            DatumNarodenia = new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog aaB35",
                            PetOwnerId = 1,
                            PocetKrmeni = 8,
                            PocetUhriznuti = 3
                        },
                        new
                        {
                            Id = 15,
                            DatumNarodenia = new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dog aa458",
                            PetOwnerId = 1,
                            PocetKrmeni = 7,
                            PocetUhriznuti = 3
                        });
                });

            modelBuilder.Entity("CatAndDogServer.Models.PetOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PetOwners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Osada Plavecky Svrtok",
                            Name = "Chovna stanica"
                        });
                });

            modelBuilder.Entity("CatAndDogServer.Models.Cat", b =>
                {
                    b.HasOne("CatAndDogServer.Models.PetOwner", "Owner")
                        .WithMany()
                        .HasForeignKey("PetOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CatAndDogServer.Models.Dog", b =>
                {
                    b.HasOne("CatAndDogServer.Models.PetOwner", "Owner")
                        .WithMany()
                        .HasForeignKey("PetOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
