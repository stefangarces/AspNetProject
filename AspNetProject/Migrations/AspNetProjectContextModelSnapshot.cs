﻿// <auto-generated />
using System;
using AspNetProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetProject.Migrations
{
    [DbContext(typeof(AspNetProjectContext))]
    partial class AspNetProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetProject.Models.Attendee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Attendee");
                });

            modelBuilder.Entity("AspNetProject.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrganizerID")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TicketsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OrganizerID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("AspNetProject.Models.Organizer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrgMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Organizer");
                });

            modelBuilder.Entity("AttendeeEvent", b =>
                {
                    b.Property<int>("AttendeesID")
                        .HasColumnType("int");

                    b.Property<int>("EventsID")
                        .HasColumnType("int");

                    b.HasKey("AttendeesID", "EventsID");

                    b.HasIndex("EventsID");

                    b.ToTable("AttendeeEvent");
                });

            modelBuilder.Entity("AspNetProject.Models.Event", b =>
                {
                    b.HasOne("AspNetProject.Models.Organizer", "Organizer")
                        .WithMany("Events")
                        .HasForeignKey("OrganizerID");

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("AttendeeEvent", b =>
                {
                    b.HasOne("AspNetProject.Models.Attendee", null)
                        .WithMany()
                        .HasForeignKey("AttendeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetProject.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetProject.Models.Organizer", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
