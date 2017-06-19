﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RM17.Models;

namespace RM17.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20170619132431_CreatePlayers")]
    partial class CreatePlayers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("RM17.Models.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PlayerName");

                    b.Property<int>("PlayerPosition");

                    b.Property<int>("PlayerSkill");

                    b.Property<string>("PlayerTeam");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });
        }
    }
}
