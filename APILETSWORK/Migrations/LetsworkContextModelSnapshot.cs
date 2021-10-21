﻿// <auto-generated />
using System;
using APILETSWORK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APILETSWORK.Migrations
{
    [DbContext(typeof(LetsworkContext))]
    partial class LetsworkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APILETSWORK.Models.ApplicationUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodePostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateTimeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("pays")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("APILETSWORK.Models.Categorie", b =>
                {
                    b.Property<string>("IdCategorie")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomCategorie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategorie");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("APILETSWORK.Models.Commentaire", b =>
                {
                    b.Property<string>("IdCommentaire")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contenu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCommentaire")
                        .HasColumnType("datetime2");

                    b.Property<string>("Idclient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCommentaire");

                    b.HasIndex("ApplicationUsersId");

                    b.ToTable("commentaires");
                });

            modelBuilder.Entity("APILETSWORK.Models.Message", b =>
                {
                    b.Property<string>("IdMessage")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Centenu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMessage");

                    b.HasIndex("ApplicationUsersId");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("APILETSWORK.Models.Metier", b =>
                {
                    b.Property<string>("IdMetier")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomMetier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProIdPro")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdMetier");

                    b.HasIndex("ProIdPro");

                    b.ToTable("metiers");
                });

            modelBuilder.Entity("APILETSWORK.Models.Mission", b =>
                {
                    b.Property<string>("IDmission")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IDmission");

                    b.ToTable("missions");
                });

            modelBuilder.Entity("APILETSWORK.Models.Pro", b =>
                {
                    b.Property<string>("IdPro")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("cinRecto")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("cinverso")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("kabis")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("IdPro");

                    b.HasIndex("ApplicationUsersId");

                    b.ToTable("pros");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("APILETSWORK.Models.Commentaire", b =>
                {
                    b.HasOne("APILETSWORK.Models.ApplicationUsers", "ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("ApplicationUsersId");

                    b.Navigation("ApplicationUsers");
                });

            modelBuilder.Entity("APILETSWORK.Models.Message", b =>
                {
                    b.HasOne("APILETSWORK.Models.ApplicationUsers", "ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("ApplicationUsersId");

                    b.Navigation("ApplicationUsers");
                });

            modelBuilder.Entity("APILETSWORK.Models.Metier", b =>
                {
                    b.HasOne("APILETSWORK.Models.Pro", "Pro")
                        .WithMany()
                        .HasForeignKey("ProIdPro");

                    b.Navigation("Pro");
                });

            modelBuilder.Entity("APILETSWORK.Models.Pro", b =>
                {
                    b.HasOne("APILETSWORK.Models.ApplicationUsers", "ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("ApplicationUsersId");

                    b.Navigation("ApplicationUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("APILETSWORK.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("APILETSWORK.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APILETSWORK.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("APILETSWORK.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
