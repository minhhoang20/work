﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProductTrack.Models;
using System;

namespace ProductTrack.Migrations
{
    [DbContext(typeof(ProductTrackContext))]
    [Migration("20171207003011_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductTrack.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MemberUserId");

                    b.Property<int?>("TeamId");

                    b.HasKey("MemberId");

                    b.HasIndex("TeamId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("ProductTrack.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeamName");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ProductTrack.Models.WorkEntry", b =>
                {
                    b.Property<int>("WorkEntryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<DateTime?>("DateCompleted");

                    b.Property<int?>("MemberId");

                    b.Property<double?>("TimeSpent");

                    b.HasKey("WorkEntryId");

                    b.HasIndex("MemberId");

                    b.ToTable("WorkEntries");
                });

            modelBuilder.Entity("ProductTrack.Models.Member", b =>
                {
                    b.HasOne("ProductTrack.Models.Team", "Team")
                        .WithMany("Members")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("ProductTrack.Models.WorkEntry", b =>
                {
                    b.HasOne("ProductTrack.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId");
                });
#pragma warning restore 612, 618
        }
    }
}
