﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Infrastructure.Database.Migrations
{
    [DbContext(typeof(ApplicationWriteDbContext))]
    partial class ApplicationWriteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Methods.Method", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<byte[]>("CollectorTypes")
                        .IsRequired()
                        .HasColumnType("smallint[]")
                        .HasColumnName("collector_types");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_methods");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_methods_name");

                    b.ToTable("methods", (string)null);
                });

            modelBuilder.Entity("Domain.Methods.MethodParameter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("MethodId")
                        .HasColumnType("uuid")
                        .HasColumnName("method_id");

                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uuid")
                        .HasColumnName("property_id");

                    b.HasKey("Id")
                        .HasName("pk_method_parameters");

                    b.HasIndex("PropertyId")
                        .HasDatabaseName("ix_method_parameters_property_id");

                    b.HasIndex("MethodId", "PropertyId")
                        .IsUnique()
                        .HasDatabaseName("ix_method_parameters_method_id_property_id");

                    b.ToTable("method_parameters", (string)null);
                });

            modelBuilder.Entity("Domain.Projects.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<byte>("CollectorType")
                        .HasColumnType("smallint")
                        .HasColumnName("collector_type");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("country");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("operator");

                    b.Property<byte>("ProjectType")
                        .HasColumnType("smallint")
                        .HasColumnName("project_type");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_projects");

                    b.HasIndex("Name")
                        .HasDatabaseName("ix_projects_name");

                    b.ToTable("projects", (string)null);
                });

            modelBuilder.Entity("Domain.Projects.ProjectMember", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("project_id");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uuid")
                        .HasColumnName("member_id");

                    b.HasKey("ProjectId", "MemberId")
                        .HasName("pk_project_members");

                    b.HasIndex("MemberId")
                        .HasDatabaseName("ix_project_members_member_id");

                    b.ToTable("project_members", (string)null);
                });

            modelBuilder.Entity("Domain.Projects.ProjectMethod", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("project_id");

                    b.Property<Guid>("MethodId")
                        .HasColumnType("uuid")
                        .HasColumnName("method_id");

                    b.HasKey("ProjectId", "MethodId")
                        .HasName("pk_project_methods");

                    b.HasIndex("MethodId")
                        .HasDatabaseName("ix_project_methods_method_id");

                    b.ToTable("project_methods", (string)null);
                });

            modelBuilder.Entity("Domain.Projects.ProjectParameter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("project_id");

                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uuid")
                        .HasColumnName("property_id");

                    b.Property<double>("Value")
                        .HasColumnType("double precision")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_project_parameters");

                    b.HasIndex("PropertyId")
                        .HasDatabaseName("ix_project_parameters_property_id");

                    b.HasIndex("ProjectId", "PropertyId")
                        .IsUnique()
                        .HasDatabaseName("ix_project_parameters_project_id_property_id");

                    b.ToTable("project_parameters", (string)null);
                });

            modelBuilder.Entity("Domain.Properties.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("unit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_properties");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_properties_name");

                    b.ToTable("properties", (string)null);
                });

            modelBuilder.Entity("Domain.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("role");

                    b.Property<string>("Token")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("token");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Outbox.OutboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAtUtc")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at_utc");

                    b.Property<string>("Error")
                        .HasColumnType("text")
                        .HasColumnName("error");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("ProccessedAtUtc")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("proccessed_at_utc");

                    b.HasKey("Id")
                        .HasName("pk_outbox_messages");

                    b.ToTable("outbox_messages", (string)null);
                });

            modelBuilder.Entity("Domain.Methods.MethodParameter", b =>
                {
                    b.HasOne("Domain.Methods.Method", null)
                        .WithMany("Parameters")
                        .HasForeignKey("MethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_method_parameters_methods_method_id");

                    b.HasOne("Domain.Properties.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_method_parameters_properties_property_id");

                    b.OwnsOne("Domain.Methods.ParameterValueGroup", "FirstParameters", b1 =>
                        {
                            b1.Property<Guid>("MethodParameterId")
                                .HasColumnType("uuid");

                            b1.Property<double>("Avg")
                                .HasColumnType("double precision");

                            b1.Property<double>("Max")
                                .HasColumnType("double precision");

                            b1.Property<double>("Min")
                                .HasColumnType("double precision");

                            b1.HasKey("MethodParameterId")
                                .HasName("pk_method_parameters");

                            b1.ToTable("method_parameters");

                            b1.ToJson("first_parameters");

                            b1.WithOwner()
                                .HasForeignKey("MethodParameterId")
                                .HasConstraintName("fk_method_parameters_method_parameters_method_parameter_id");
                        });

                    b.OwnsOne("Domain.Methods.ParameterValueGroup", "SecondParameters", b1 =>
                        {
                            b1.Property<Guid>("MethodParameterId")
                                .HasColumnType("uuid");

                            b1.Property<double>("Avg")
                                .HasColumnType("double precision");

                            b1.Property<double>("Max")
                                .HasColumnType("double precision");

                            b1.Property<double>("Min")
                                .HasColumnType("double precision");

                            b1.HasKey("MethodParameterId");

                            b1.ToTable("method_parameters");

                            b1.ToJson("second_parameters");

                            b1.WithOwner()
                                .HasForeignKey("MethodParameterId")
                                .HasConstraintName("fk_method_parameters_method_parameters_id");
                        });

                    b.Navigation("FirstParameters");

                    b.Navigation("SecondParameters");
                });

            modelBuilder.Entity("Domain.Projects.ProjectMember", b =>
                {
                    b.HasOne("Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_members_users_member_id");

                    b.HasOne("Domain.Projects.Project", null)
                        .WithMany("Members")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_members_projects_project_id");
                });

            modelBuilder.Entity("Domain.Projects.ProjectMethod", b =>
                {
                    b.HasOne("Domain.Methods.Method", null)
                        .WithMany()
                        .HasForeignKey("MethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_methods_methods_method_id");

                    b.HasOne("Domain.Projects.Project", null)
                        .WithMany("Methods")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_methods_projects_project_id");
                });

            modelBuilder.Entity("Domain.Projects.ProjectParameter", b =>
                {
                    b.HasOne("Domain.Projects.Project", null)
                        .WithMany("Parameters")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_parameters_projects_project_id");

                    b.HasOne("Domain.Properties.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_parameters_properties_property_id");
                });

            modelBuilder.Entity("Domain.Methods.Method", b =>
                {
                    b.Navigation("Parameters");
                });

            modelBuilder.Entity("Domain.Projects.Project", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Methods");

                    b.Navigation("Parameters");
                });
#pragma warning restore 612, 618
        }
    }
}
