﻿// <auto-generated />
using Dunca_Raul_Adrian_IE_ID_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Migrations
{
    [DbContext(typeof(Dunca_Raul_Adrian_IE_ID_ProiectContext))]
    partial class Dunca_Raul_Adrian_IE_ID_ProiectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Noble", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TerritoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("Noble");
                });

            modelBuilder.Entity("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Ruler", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("TerritoryID")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publicAcceptance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("TerritoryID")
                        .IsUnique();

                    b.ToTable("Rulers");
                });

            modelBuilder.Entity("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Territory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Territory");
                });

            modelBuilder.Entity("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Noble", b =>
                {
                    b.HasOne("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Territory", "Territory")
                        .WithMany("Nobles")
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Territory");
                });

            modelBuilder.Entity("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Ruler", b =>
                {
                    b.HasOne("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Territory", "Territory")
                        .WithOne("Ruler")
                        .HasForeignKey("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Ruler", "TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Territory");
                });

            modelBuilder.Entity("Dunca_Raul_Adrian_IE_ID_Proiect.Models.Territory", b =>
                {
                    b.Navigation("Nobles");

                    b.Navigation("Ruler");
                });
#pragma warning restore 612, 618
        }
    }
}