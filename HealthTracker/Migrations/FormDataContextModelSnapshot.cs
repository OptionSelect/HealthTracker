﻿// <auto-generated />
using HealthTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HealthTracker.Migrations
{
    [DbContext(typeof(FormDataContext))]
    partial class FormDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthTracker.Models.FormData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BehaviorActivity");

                    b.Property<string>("Breakfast");

                    b.Property<string>("Dinner");

                    b.Property<bool>("Drank");

                    b.Property<bool>("ExerciseBehaviors");

                    b.Property<string>("Lunch");

                    b.Property<string>("Mood");

                    b.Property<DateTime>("PostDate");

                    b.Property<bool>("Sexed");

                    b.Property<bool>("Smoked");

                    b.Property<string>("Snacks");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("FormDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
