using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using JourTibourApi.Models;

namespace JourTibourApi.Migrations
{
    [DbContext(typeof(JourTibourContext))]
    [Migration("20160915134421_ChangedDatabaseNameMigration")]
    partial class ChangedDatabaseNameMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JourTibourApi.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArtistName");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("JourTibourApi.Models.Edition", b =>
                {
                    b.Property<int>("EditionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FestivalDate");

                    b.HasKey("EditionId");

                    b.ToTable("Editions");
                });

            modelBuilder.Entity("JourTibourApi.Models.Performance", b =>
                {
                    b.Property<int>("PerformanceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtistId");

                    b.Property<int?>("EditionId");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Stage");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("PerformanceId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("EditionId");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("JourTibourApi.Models.Stage", b =>
                {
                    b.Property<int>("StageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StageName");

                    b.HasKey("StageId");

                    b.ToTable("Stages");
                });

            modelBuilder.Entity("JourTibourApi.Models.Performance", b =>
                {
                    b.HasOne("JourTibourApi.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.HasOne("JourTibourApi.Models.Edition")
                        .WithMany("Performances")
                        .HasForeignKey("EditionId");
                });
        }
    }
}
