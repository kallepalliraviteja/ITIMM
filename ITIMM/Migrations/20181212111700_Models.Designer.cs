﻿// <auto-generated />
using System;
using ITIMM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITIMM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181212111700_Models")]
    partial class Models
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ITIMM.Models.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AMCDate");

                    b.Property<int?>("CategoriesId");

                    b.Property<string>("CostCenter");

                    b.Property<string>("CustodianAssetId");

                    b.Property<string>("HostName");

                    b.Property<DateTime>("InstallationDate");

                    b.Property<string>("IpAddress");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<string>("MonitorSlno");

                    b.Property<string>("OS");

                    b.Property<string>("PoNo");

                    b.Property<string>("Slno");

                    b.Property<string>("Spec");

                    b.Property<DateTime>("WarrantyExpiryDate");

                    b.Property<int>("WarrantyInMonths");

                    b.Property<string>("WorkGroup");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("CustodianAssetId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("ITIMM.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryType");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("ITIMM.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetCommentId");

                    b.Property<string>("Comment");

                    b.Property<int?>("CommentComplaintId");

                    b.Property<DateTime>("CommentDT");

                    b.Property<string>("CutodianCommentId");

                    b.HasKey("Id");

                    b.HasIndex("AssetCommentId");

                    b.HasIndex("CommentComplaintId");

                    b.HasIndex("CutodianCommentId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("ITIMM.Models.Complaints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetComplaintsId");

                    b.Property<DateTime>("ComplaintDT");

                    b.Property<string>("CustodianComplaintId");

                    b.Property<string>("Descriprion");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("AssetComplaintsId");

                    b.HasIndex("CustodianComplaintId");

                    b.ToTable("complaints");
                });

            modelBuilder.Entity("ITIMM.Models.Custodian", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Assets");

                    b.HasKey("Id");

                    b.ToTable("custodians");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ITIMM.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("ITIMM.Models.Asset", b =>
                {
                    b.HasOne("ITIMM.Models.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoriesId");

                    b.HasOne("ITIMM.Models.Custodian", "CustodianAsset")
                        .WithMany("CustodianAssets")
                        .HasForeignKey("CustodianAssetId");
                });

            modelBuilder.Entity("ITIMM.Models.Comments", b =>
                {
                    b.HasOne("ITIMM.Models.Asset", "AssetComment")
                        .WithMany()
                        .HasForeignKey("AssetCommentId");

                    b.HasOne("ITIMM.Models.Complaints", "CommentComplaint")
                        .WithMany("ComplaintComments")
                        .HasForeignKey("CommentComplaintId");

                    b.HasOne("ITIMM.Models.Custodian", "CutodianComment")
                        .WithMany("CustodianComments")
                        .HasForeignKey("CutodianCommentId");
                });

            modelBuilder.Entity("ITIMM.Models.Complaints", b =>
                {
                    b.HasOne("ITIMM.Models.Asset", "AssetComplaints")
                        .WithMany("AssetComplaints")
                        .HasForeignKey("AssetComplaintsId");

                    b.HasOne("ITIMM.Models.Custodian", "CustodianComplaint")
                        .WithMany("CustodianComplaints")
                        .HasForeignKey("CustodianComplaintId");
                });

            modelBuilder.Entity("ITIMM.Models.Custodian", b =>
                {
                    b.HasOne("ITIMM.Models.ApplicationUser", "IdentityUser")
                        .WithOne("CustodianUser")
                        .HasForeignKey("ITIMM.Models.Custodian", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}