﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BeerhallEF.Data;

namespace BeerhallEF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170113101257_CreateTableBrewers")]
    partial class CreateTableBrewers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeerhallEF.Models.Brewer", b =>
                {
                    b.Property<int>("BrewerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactEmail");

                    b.Property<DateTime?>("DateEstablished");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Street");

                    b.Property<int?>("Turnover");

                    b.HasKey("BrewerId");

                    b.ToTable("Brewers");
                });
        }
    }
}
