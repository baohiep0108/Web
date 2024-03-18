﻿// <auto-generated />
using System;
using BusinessObject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObject.Migrations
{
    [DbContext(typeof(ConnectDB))]
    [Migration("20240314165905_Initaa")]
    partial class Initaa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObject.Data.Category_Course", b =>
                {
                    b.Property<int>("Category_coures_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_coures_id"));

                    b.Property<string>("Category_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_coures_id");

                    b.ToTable("tb_Category_Course");
                });

            modelBuilder.Entity("BusinessObject.Data.Class_Role", b =>
                {
                    b.Property<int>("Class_Role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Class_Role_id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Class_Role_id");

                    b.ToTable("tb_Class_Role");
                });

            modelBuilder.Entity("BusinessObject.Data.Course", b =>
                {
                    b.Property<int>("Coures_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Coures_id"));

                    b.Property<int>("Category_coures_id")
                        .HasColumnType("int");

                    b.Property<string>("Coures_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Coures_id");

                    b.HasIndex("Category_coures_id");

                    b.ToTable("tb_Coures");
                });

            modelBuilder.Entity("BusinessObject.Data.Exercise", b =>
                {
                    b.Property<int>("Exercise_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Exercise_id"));

                    b.Property<int>("Course_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Creat_time")
                        .HasMaxLength(250)
                        .HasColumnType("datetime2");

                    b.Property<string>("Exercise_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("File_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link_submit_assignments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Exercise_id");

                    b.HasIndex("Course_id");

                    b.ToTable("tb_Exercise");
                });

            modelBuilder.Entity("BusinessObject.Data.Role", b =>
                {
                    b.Property<int>("Role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Role_id"));

                    b.Property<string>("Role_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Role_id");

                    b.ToTable("tb_Role");
                });

            modelBuilder.Entity("BusinessObject.Data.Student_Class", b =>
                {
                    b.Property<int>("Student_Class_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Student_Class_id"));

                    b.Property<int>("Class_Role_id")
                        .HasColumnType("int");

                    b.Property<int>("Student_Course_id")
                        .HasColumnType("int");

                    b.HasKey("Student_Class_id");

                    b.HasIndex("Class_Role_id");

                    b.HasIndex("Student_Course_id");

                    b.ToTable("tb_Student_Class");
                });

            modelBuilder.Entity("BusinessObject.Data.Student_Course", b =>
                {
                    b.Property<int>("Student_id")
                        .HasColumnType("int");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_id");

                    b.ToTable("tb_Student_Course");
                });

            modelBuilder.Entity("BusinessObject.Data.Teacher_Class", b =>
                {
                    b.Property<int>("Study_Class_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Study_Class_id"));

                    b.Property<int>("Class_Role_id")
                        .HasColumnType("int");

                    b.Property<int>("Teacher_Course_id")
                        .HasColumnType("int");

                    b.HasKey("Study_Class_id");

                    b.HasIndex("Class_Role_id");

                    b.HasIndex("Teacher_Course_id");

                    b.ToTable("tb_Teacher_Class");
                });

            modelBuilder.Entity("BusinessObject.Data.Teacher_Course", b =>
                {
                    b.Property<int>("Teacher_Coures_id")
                        .HasColumnType("int");

                    b.Property<int>("Course_id")
                        .HasColumnType("int");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teaching_major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Teacher_Coures_id");

                    b.HasIndex("Course_id");

                    b.ToTable("tb_Teacher_Course");
                });

            modelBuilder.Entity("BusinessObject.Data.User", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_id"));

                    b.Property<string>("CCCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.Property<string>("Sex_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_id");

                    b.HasIndex("Role_id");

                    b.ToTable("tb_User");
                });

            modelBuilder.Entity("BusinessObject.Data.Course", b =>
                {
                    b.HasOne("BusinessObject.Data.Category_Course", "Category_Course")
                        .WithMany("Courses")
                        .HasForeignKey("Category_coures_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category_Course");
                });

            modelBuilder.Entity("BusinessObject.Data.Exercise", b =>
                {
                    b.HasOne("BusinessObject.Data.Course", "Course")
                        .WithMany("Exercises")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("BusinessObject.Data.Student_Class", b =>
                {
                    b.HasOne("BusinessObject.Data.Class_Role", "Class_Role")
                        .WithMany("Student_Classes")
                        .HasForeignKey("Class_Role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObject.Data.Student_Course", "Student_Course")
                        .WithMany("Student_Classes")
                        .HasForeignKey("Student_Course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class_Role");

                    b.Navigation("Student_Course");
                });

            modelBuilder.Entity("BusinessObject.Data.Student_Course", b =>
                {
                    b.HasOne("BusinessObject.Data.User", "User")
                        .WithMany("Student_Courses")
                        .HasForeignKey("Student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObject.Data.Teacher_Class", b =>
                {
                    b.HasOne("BusinessObject.Data.Class_Role", "Class_Role")
                        .WithMany("Teacher_Classes")
                        .HasForeignKey("Class_Role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObject.Data.Teacher_Course", "Teacher_Course")
                        .WithMany("Teacher_Class")
                        .HasForeignKey("Teacher_Course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class_Role");

                    b.Navigation("Teacher_Course");
                });

            modelBuilder.Entity("BusinessObject.Data.Teacher_Course", b =>
                {
                    b.HasOne("BusinessObject.Data.Course", "Course")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObject.Data.User", "User")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("Teacher_Coures_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObject.Data.User", b =>
                {
                    b.HasOne("BusinessObject.Data.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("Role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BusinessObject.Data.Category_Course", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("BusinessObject.Data.Class_Role", b =>
                {
                    b.Navigation("Student_Classes");

                    b.Navigation("Teacher_Classes");
                });

            modelBuilder.Entity("BusinessObject.Data.Course", b =>
                {
                    b.Navigation("Exercises");

                    b.Navigation("Teacher_Courses");
                });

            modelBuilder.Entity("BusinessObject.Data.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BusinessObject.Data.Student_Course", b =>
                {
                    b.Navigation("Student_Classes");
                });

            modelBuilder.Entity("BusinessObject.Data.Teacher_Course", b =>
                {
                    b.Navigation("Teacher_Class");
                });

            modelBuilder.Entity("BusinessObject.Data.User", b =>
                {
                    b.Navigation("Student_Courses");

                    b.Navigation("Teacher_Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
