using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RM17.Models;

namespace RM17.Migrations.Team
{
    [DbContext(typeof(TeamContext))]
    [Migration("20170619132734_CreateTeams")]
    partial class CreateTeams
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("RM17.Models.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("teamName");

                    b.Property<int>("teamSkill");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });
        }
    }
}
