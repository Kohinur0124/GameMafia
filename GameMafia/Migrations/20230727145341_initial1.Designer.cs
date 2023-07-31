﻿// <auto-generated />
using System;
using GameMafia.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GameMafia.Migrations
{
    [DbContext(typeof(MafiaGameDb))]
    [Migration("20230727145341_initial1")]
    partial class initial1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GameMafia.Core.Models.CountRole", b =>
                {
                    b.Property<int>("CountRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CountRoleId"));

                    b.Property<int>("CountPlayer")
                        .HasColumnType("integer");

                    b.Property<int>("CountRoles")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("CountRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("CountRole");

                    b.HasData(
                        new
                        {
                            CountRoleId = 1,
                            CountPlayer = 4,
                            CountRoles = 2,
                            RoleId = 1
                        },
                        new
                        {
                            CountRoleId = 2,
                            CountPlayer = 4,
                            CountRoles = 1,
                            RoleId = 2
                        },
                        new
                        {
                            CountRoleId = 3,
                            CountPlayer = 4,
                            CountRoles = 1,
                            RoleId = 3
                        },
                        new
                        {
                            CountRoleId = 4,
                            CountPlayer = 5,
                            CountRoles = 3,
                            RoleId = 1
                        },
                        new
                        {
                            CountRoleId = 5,
                            CountPlayer = 5,
                            CountRoles = 1,
                            RoleId = 2
                        },
                        new
                        {
                            CountRoleId = 6,
                            CountPlayer = 5,
                            CountRoles = 1,
                            RoleId = 3
                        },
                        new
                        {
                            CountRoleId = 7,
                            CountPlayer = 6,
                            CountRoles = 3,
                            RoleId = 1
                        },
                        new
                        {
                            CountRoleId = 8,
                            CountPlayer = 6,
                            CountRoles = 1,
                            RoleId = 2
                        },
                        new
                        {
                            CountRoleId = 9,
                            CountPlayer = 6,
                            CountRoles = 1,
                            RoleId = 3
                        },
                        new
                        {
                            CountRoleId = 10,
                            CountPlayer = 6,
                            CountRoles = 1,
                            RoleId = 4
                        },
                        new
                        {
                            CountRoleId = 11,
                            CountPlayer = 7,
                            CountRoles = 4,
                            RoleId = 1
                        },
                        new
                        {
                            CountRoleId = 12,
                            CountPlayer = 7,
                            CountRoles = 1,
                            RoleId = 2
                        },
                        new
                        {
                            CountRoleId = 13,
                            CountPlayer = 7,
                            CountRoles = 1,
                            RoleId = 3
                        },
                        new
                        {
                            CountRoleId = 14,
                            CountPlayer = 7,
                            CountRoles = 1,
                            RoleId = 4
                        },
                        new
                        {
                            CountRoleId = 15,
                            CountPlayer = 8,
                            CountRoles = 4,
                            RoleId = 1
                        },
                        new
                        {
                            CountRoleId = 16,
                            CountPlayer = 8,
                            CountRoles = 1,
                            RoleId = 2
                        },
                        new
                        {
                            CountRoleId = 17,
                            CountPlayer = 8,
                            CountRoles = 1,
                            RoleId = 3
                        },
                        new
                        {
                            CountRoleId = 18,
                            CountPlayer = 8,
                            CountRoles = 1,
                            RoleId = 4
                        },
                        new
                        {
                            CountRoleId = 19,
                            CountPlayer = 8,
                            CountRoles = 1,
                            RoleId = 5
                        },
                        new
                        {
                            CountRoleId = 20,
                            CountPlayer = 9,
                            CountRoles = 4,
                            RoleId = 1
                        },
                        new
                        {
                            CountRoleId = 21,
                            CountPlayer = 9,
                            CountRoles = 1,
                            RoleId = 2
                        },
                        new
                        {
                            CountRoleId = 22,
                            CountPlayer = 9,
                            CountRoles = 1,
                            RoleId = 3
                        },
                        new
                        {
                            CountRoleId = 23,
                            CountPlayer = 9,
                            CountRoles = 1,
                            RoleId = 4
                        },
                        new
                        {
                            CountRoleId = 24,
                            CountPlayer = 9,
                            CountRoles = 1,
                            RoleId = 5
                        },
                        new
                        {
                            CountRoleId = 25,
                            CountPlayer = 9,
                            CountRoles = 1,
                            RoleId = 6
                        },
                        new
                        {
                            CountRoleId = 26,
                            CountPlayer = 10,
                            CountRoles = 4,
                            RoleId = 1
                        },
                        new
                        {
                            CountRoleId = 27,
                            CountPlayer = 10,
                            CountRoles = 1,
                            RoleId = 2
                        },
                        new
                        {
                            CountRoleId = 28,
                            CountPlayer = 10,
                            CountRoles = 1,
                            RoleId = 3
                        },
                        new
                        {
                            CountRoleId = 29,
                            CountPlayer = 10,
                            CountRoles = 1,
                            RoleId = 4
                        },
                        new
                        {
                            CountRoleId = 30,
                            CountPlayer = 10,
                            CountRoles = 2,
                            RoleId = 5
                        },
                        new
                        {
                            CountRoleId = 31,
                            CountPlayer = 10,
                            CountRoles = 1,
                            RoleId = 6
                        });
                });

            modelBuilder.Entity("GameMafia.Core.Models.Market", b =>
                {
                    b.Property<int>("MarketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MarketId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("MarketId");

                    b.ToTable("Markets");

                    b.HasData(
                        new
                        {
                            MarketId = 1,
                            Name = "Himoya",
                            Price = 100
                        });
                });

            modelBuilder.Entity("GameMafia.Core.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessageId"));

                    b.Property<DateTime>("DTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MessagePlayer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer");

                    b.HasKey("MessageId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("GameMafia.Core.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlayerId"));

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<int?>("DeathDate")
                        .HasColumnType("integer");

                    b.Property<int>("Heal")
                        .HasColumnType("integer");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("PlayerId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("GameMafia.Core.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Description = "kechasi uxlaydi va kunduzi yovuz qahramonlarni aniqlashga va ularni yo`q qilishga harakat qiladi (ovoz berish o`tkaziladi)",
                            Name = "Tinch aholi",
                            Type = 0
                        },
                        new
                        {
                            RoleId = 2,
                            Description = "favqulodda ishchi. Kechasi u o`yinchilardan biriga kelib, hayotini saqlab qolishi mumkin. Har bir o'yinda bir marta o'zini qutqara oladi",
                            Name = "Shifokor",
                            Type = 0
                        },
                        new
                        {
                            RoleId = 3,
                            Description = "mafiya rahbari. Kechasi butun mafiya oilasi bilan birgalikda u jabrlanuvchini tanlaydi va hukmni ijro etadi",
                            Name = "Don",
                            Type = 1
                        },
                        new
                        {
                            RoleId = 4,
                            Description = "tartib qo'riqchisi. Kechasi u o'yinchilardan birining rolini bilishi yoki uni o'ldirishi mumkin.",
                            Name = "Kommisar",
                            Type = 0
                        },
                        new
                        {
                            RoleId = 5,
                            Description = "mafiya oilasi a'zosi. Kechasi oilasi bilan birga qurbonni tanlaydi. Agar eskisi o'ldirilgan bo'lsa, yangi Don bo'lishi mumkin",
                            Name = "Mafia",
                            Type = 1
                        },
                        new
                        {
                            RoleId = 6,
                            Description = "faqat kunduzgi o'lim ovozini yutib, g'alaba qozonadigan neytral rol (ha, siz kunduzi o'lishingiz kerak)",
                            Name = "Suisid",
                            Type = 2
                        });
                });

            modelBuilder.Entity("GameMafia.Core.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Security")
                        .HasColumnType("integer");

                    b.Property<int>("Summ")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GameMafia.Core.Models.CountRole", b =>
                {
                    b.HasOne("GameMafia.Core.Models.Role", "Role")
                        .WithMany("CountRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("GameMafia.Core.Models.Message", b =>
                {
                    b.HasOne("GameMafia.Core.Models.Player", "Player")
                        .WithMany("Messages")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("GameMafia.Core.Models.Player", b =>
                {
                    b.HasOne("GameMafia.Core.Models.Role", "Role")
                        .WithMany("Players")
                        .HasForeignKey("RoleId");

                    b.HasOne("GameMafia.Core.Models.User", "User")
                        .WithMany("Players")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GameMafia.Core.Models.Player", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("GameMafia.Core.Models.Role", b =>
                {
                    b.Navigation("CountRole");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("GameMafia.Core.Models.User", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
