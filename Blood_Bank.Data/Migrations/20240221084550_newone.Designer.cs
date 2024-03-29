﻿// <auto-generated />
using Blood_Bank.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blood_Bank.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240221084550_newone")]
    partial class newone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Blood_Bank.Core.Entities.Donations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<int>("SickId")
                        .HasColumnType("int");

                    b.Property<int>("idDonor")
                        .HasColumnType("int");

                    b.Property<int>("idSick")
                        .HasColumnType("int");

                    b.Property<int>("statusDonation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonorId");

                    b.HasIndex("SickId");

                    b.ToTable("DonationsList");
                });

            modelBuilder.Entity("Blood_Bank.Core.Entities.Donors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("fNameDonor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lNameDonor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pelephoneDonor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("statusDonor")
                        .HasColumnType("int");

                    b.Property<string>("typeBloodDonor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DonorsList");
                });

            modelBuilder.Entity("Blood_Bank.Core.Entities.Sicks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("fNameSick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lNameSick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pelephoneSick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("statusSick")
                        .HasColumnType("int");

                    b.Property<string>("typeBloodSick")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SicksList");
                });

            modelBuilder.Entity("Blood_Bank.Core.Entities.Donations", b =>
                {
                    b.HasOne("Blood_Bank.Core.Entities.Donors", "Donor")
                        .WithMany("donations")
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blood_Bank.Core.Entities.Sicks", "Sick")
                        .WithMany("donations")
                        .HasForeignKey("SickId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donor");

                    b.Navigation("Sick");
                });

            modelBuilder.Entity("Blood_Bank.Core.Entities.Donors", b =>
                {
                    b.Navigation("donations");
                });

            modelBuilder.Entity("Blood_Bank.Core.Entities.Sicks", b =>
                {
                    b.Navigation("donations");
                });
#pragma warning restore 612, 618
        }
    }
}
