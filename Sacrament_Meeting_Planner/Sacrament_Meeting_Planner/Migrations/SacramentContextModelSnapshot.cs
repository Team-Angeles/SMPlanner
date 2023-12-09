﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sacrament_Meeting_Planner.Data;

#nullable disable

namespace Sacrament_Meeting_Planner.Migrations
{
    [DbContext(typeof(SacramentContext))]
    partial class SacramentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sacrament_Meeting_Planner.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClosingHymn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingPrayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfMeeting")
                        .HasColumnType("datetime2");

                    b.Property<string>("IntermediateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHymn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacramentHymn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meeting", (string)null);
                });

            modelBuilder.Entity("Sacrament_Meeting_Planner.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MeetingId")
                        .HasColumnType("int");

                    b.Property<string>("SpeakerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpeakerPosition")
                        .HasColumnType("int");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.ToTable("Speaker", (string)null);
                });

            modelBuilder.Entity("Sacrament_Meeting_Planner.Models.Speaker", b =>
                {
                    b.HasOne("Sacrament_Meeting_Planner.Models.Meeting", "Meeting")
                        .WithMany("MeetingSpeakers")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("Sacrament_Meeting_Planner.Models.Meeting", b =>
                {
                    b.Navigation("MeetingSpeakers");
                });
#pragma warning restore 612, 618
        }
    }
}
