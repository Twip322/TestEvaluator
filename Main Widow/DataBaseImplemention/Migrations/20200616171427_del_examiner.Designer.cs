﻿// <auto-generated />
using System;
using DataBaseImplemention;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBaseImplemention.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20200616171427_del_examiner")]
    partial class del_examiner
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataBaseImplemention.Models.Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ansewrs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("quest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rightNum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DataBaseImplemention.Models.TestQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("QuestID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("answers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("questName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rightNum")
                        .HasColumnType("int");

                    b.Property<int?>("testsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestID");

                    b.HasIndex("testsId");

                    b.ToTable("TestsQuestions");
                });

            modelBuilder.Entity("DataBaseImplemention.Models.Tests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("testName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("DataBaseImplemention.Models.TestQuestions", b =>
                {
                    b.HasOne("DataBaseImplemention.Models.Questions", "questions")
                        .WithMany("Testquests")
                        .HasForeignKey("QuestID");

                    b.HasOne("DataBaseImplemention.Models.Tests", "tests")
                        .WithMany("testQuestionss")
                        .HasForeignKey("testsId");
                });
#pragma warning restore 612, 618
        }
    }
}
