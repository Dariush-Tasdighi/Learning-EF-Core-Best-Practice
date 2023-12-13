﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Features.Identity.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("InsertDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Ordering")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset>("UpdateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20f258d6-05f0-4cca-949c-4ebd0841674d"),
                            InsertDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 3, 30, 0, 0)),
                            IsActive = true,
                            Ordering = 10000,
                            Title = "Group 1",
                            UpdateDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 3, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("b7699fae-303a-44a7-824a-7e6adef2e621"),
                            InsertDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 3, 30, 0, 0)),
                            IsActive = true,
                            Ordering = 10000,
                            Title = "Group 2",
                            UpdateDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 3, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("766a89f3-0db0-416f-8fae-f0537338cbfd"),
                            InsertDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4075), new TimeSpan(0, 3, 30, 0, 0)),
                            IsActive = true,
                            Ordering = 10000,
                            Title = "Group 3",
                            UpdateDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4075), new TimeSpan(0, 3, 30, 0, 0))
                        });
                });

            modelBuilder.Entity("Domain.Features.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("InsertDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Ordering")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset>("UpdateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52170142-d6f8-4202-ac5a-1062f5588887"),
                            InsertDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 32, DateTimeKind.Unspecified).AddTicks(935), new TimeSpan(0, 3, 30, 0, 0)),
                            IsActive = true,
                            Ordering = 10000,
                            Title = "User",
                            UpdateDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 32, DateTimeKind.Unspecified).AddTicks(935), new TimeSpan(0, 3, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("6df1a10c-a2b2-4988-9411-8415eac9fa2a"),
                            InsertDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 34, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 3, 30, 0, 0)),
                            IsActive = true,
                            Ordering = 10000,
                            Title = "Administrator",
                            UpdateDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 34, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 3, 30, 0, 0))
                        });
                });

            modelBuilder.Entity("Domain.Features.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(254)
                        .IsUnicode(false)
                        .HasColumnType("varchar(254)");

                    b.Property<Guid>("EmailAddressVerificationKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("InsertDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailAddressVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(44)
                        .IsUnicode(false)
                        .HasColumnType("varchar(44)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.HasIndex("EmailAddressVerificationKey")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b84432a9-89e9-4c7f-aa1d-1743bf5fda8f"),
                            EmailAddress = "dariusht@gmail.com",
                            EmailAddressVerificationKey = new Guid("898bc2b1-0950-4abc-a29f-257dc448317f"),
                            InsertDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 3, 30, 0, 0)),
                            IsActive = true,
                            IsEmailAddressVerified = false,
                            Password = "5KCpDlrAfVQ1xvJcTPfMVlvst5e7W4PFFbxCfvMqR3A=",
                            RoleId = new Guid("6df1a10c-a2b2-4988-9411-8415eac9fa2a"),
                            UpdateDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 3, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("f41a31d7-b717-4a22-98db-4ba76cff2fae"),
                            EmailAddress = "alirezaalavi@gmail.com",
                            EmailAddressVerificationKey = new Guid("31c3be0a-b144-492d-bcfc-11b8e46dc53f"),
                            InsertDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 3, 30, 0, 0)),
                            IsActive = true,
                            IsEmailAddressVerified = false,
                            Password = "5KCpDlrAfVQ1xvJcTPfMVlvst5e7W4PFFbxCfvMqR3A=",
                            RoleId = new Guid("52170142-d6f8-4202-ac5a-1062f5588887"),
                            UpdateDateTime = new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 3, 30, 0, 0))
                        });
                });

            modelBuilder.Entity("Domain.Features.Identity.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("UsersInGroups", b =>
                {
                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GroupId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersInGroups");
                });

            modelBuilder.Entity("Domain.Features.Identity.User", b =>
                {
                    b.HasOne("Domain.Features.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Features.Identity.UserProfile", b =>
                {
                    b.HasOne("Domain.Features.Identity.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Domain.Features.Identity.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UsersInGroups", b =>
                {
                    b.HasOne("Domain.Features.Identity.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Features.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Features.Identity.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Features.Identity.User", b =>
                {
                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
