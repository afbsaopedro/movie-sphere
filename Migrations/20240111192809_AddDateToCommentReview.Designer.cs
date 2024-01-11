﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieSphere.Data;

#nullable disable

namespace MovieSphere.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240111192809_AddDateToCommentReview")]
    partial class AddDateToCommentReview
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationUserMovie", b =>
                {
                    b.Property<int>("FavouriteMoviesId")
                        .HasColumnType("int");

                    b.Property<string>("UsersWhoFavouritedId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FavouriteMoviesId", "UsersWhoFavouritedId");

                    b.HasIndex("UsersWhoFavouritedId");

                    b.ToTable("UsersFavourited", (string)null);
                });

            modelBuilder.Entity("ApplicationUserMovie1", b =>
                {
                    b.Property<string>("UsersInWatchlistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WatchlistId")
                        .HasColumnType("int");

                    b.HasKey("UsersInWatchlistId", "WatchlistId");

                    b.HasIndex("WatchlistId");

                    b.ToTable("UsersWatchlist", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "383f5fd1-bea4-4117-968c-bc10a86d8845",
                            Name = "Developer"
                        },
                        new
                        {
                            Id = "83ef4aea-bb17-4639-8fc1-7f4fa447fe3e",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "8fa78dd0-74c5-4551-89b7-01345b08d69f",
                            Name = "Manager"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MovieSphere.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PlaceOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "44340f8a-5df6-44e0-b2cc-6b217e20bee8",
                            AccessFailedCount = 0,
                            Bio = "Teacher @ ESTG.",
                            ConcurrencyStamp = "b57a0454-c923-46dc-949f-bf7604cd9ce5",
                            CourseId = 6,
                            CreationDate = new DateTime(2024, 1, 11, 19, 28, 8, 378, DateTimeKind.Local).AddTicks(8853),
                            DateOfBirth = new DateOnly(1991, 1, 2),
                            DisplayName = "dolival",
                            Email = "d.olival@moviesphere.com",
                            EmailConfirmed = true,
                            FirstName = "Diogo",
                            IsPrivate = true,
                            LastName = "Olival",
                            LockoutEnabled = false,
                            NormalizedEmail = "D.OLIVAL@MOVIESPHERE.COM",
                            NormalizedUserName = "D.OLIVAL@MOVIESPHERE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECE1HZaYiuPpKuYlfun/FW+7/d3zLpQyaKhf7blPs2YlddnytL6XD4W4/MGwDSJ0pw==",
                            PhoneNumberConfirmed = false,
                            PlaceOfOrigin = "Madeira",
                            SecurityStamp = "2ba368ad-85f4-4108-878b-4baffa75230f",
                            TwoFactorEnabled = false,
                            UserName = "d.olival@moviesphere.com"
                        });
                });

            modelBuilder.Entity("MovieSphere.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("MovieId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MovieSphere.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseTypeId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseTypeId = 1,
                            Name = "Administração de Publicidade e Marketing",
                            Tag = "APM"
                        },
                        new
                        {
                            Id = 2,
                            CourseTypeId = 1,
                            Name = "Design de Animação",
                            Tag = "DA"
                        },
                        new
                        {
                            Id = 3,
                            CourseTypeId = 1,
                            Name = "Design de Comunicação",
                            Tag = "DC"
                        },
                        new
                        {
                            Id = 4,
                            CourseTypeId = 1,
                            Name = "Engenharia Civil",
                            Tag = "EC"
                        },
                        new
                        {
                            Id = 5,
                            CourseTypeId = 1,
                            Name = "Engenharia de Produção de Biocombustíveis",
                            Tag = "EPBio"
                        },
                        new
                        {
                            Id = 6,
                            CourseTypeId = 1,
                            Name = "Engenharia Informática",
                            Tag = "EI"
                        },
                        new
                        {
                            Id = 7,
                            CourseTypeId = 1,
                            Name = "Gestão",
                            Tag = "Ges"
                        },
                        new
                        {
                            Id = 8,
                            CourseTypeId = 1,
                            Name = "Gestão (pós-laboral)",
                            Tag = "GesPL"
                        },
                        new
                        {
                            Id = 9,
                            CourseTypeId = 2,
                            Name = "Contabilidade e Finanças",
                            Tag = "CF"
                        },
                        new
                        {
                            Id = 10,
                            CourseTypeId = 2,
                            Name = "Design de Identidade Digital",
                            Tag = "DID"
                        },
                        new
                        {
                            Id = 11,
                            CourseTypeId = 2,
                            Name = "Gestão de Pequenas e Médias Empresas",
                            Tag = "GPME"
                        },
                        new
                        {
                            Id = 12,
                            CourseTypeId = 2,
                            Name = "Informática",
                            Tag = "Info"
                        },
                        new
                        {
                            Id = 13,
                            CourseTypeId = 2,
                            Name = "Tecnologias de Valorização Ambiental e Produção de Energia",
                            Tag = "TVAPE"
                        },
                        new
                        {
                            Id = 14,
                            CourseTypeId = 3,
                            Name = "Animação e Produção 3D",
                            Tag = "AP3D"
                        },
                        new
                        {
                            Id = 15,
                            CourseTypeId = 3,
                            Name = "Bioenergias",
                            Tag = "BioEn"
                        },
                        new
                        {
                            Id = 16,
                            CourseTypeId = 3,
                            Name = "Construção e Reabilitação de Edifícios",
                            Tag = "CRE"
                        },
                        new
                        {
                            Id = 17,
                            CourseTypeId = 3,
                            Name = "Contabilidade",
                            Tag = "Conta"
                        },
                        new
                        {
                            Id = 18,
                            CourseTypeId = 3,
                            Name = "Desenvolvimento para a Web e Dispositivos Móveis",
                            Tag = "DWDM"
                        },
                        new
                        {
                            Id = 19,
                            CourseTypeId = 3,
                            Name = "Design de Som e Produção Musical",
                            Tag = "DSPM"
                        },
                        new
                        {
                            Id = 20,
                            CourseTypeId = 3,
                            Name = "Design Multimédia e Audiovisuais",
                            Tag = "DMA"
                        },
                        new
                        {
                            Id = 21,
                            CourseTypeId = 3,
                            Name = "Gestão de Vendas e Marketing",
                            Tag = "GVM"
                        },
                        new
                        {
                            Id = 22,
                            CourseTypeId = 3,
                            Name = "Manutenção Eletromecânica",
                            Tag = "ME"
                        },
                        new
                        {
                            Id = 23,
                            CourseTypeId = 3,
                            Name = "Programação Ágil e Segurança de Sistemas de Informação",
                            Tag = "PASSI"
                        },
                        new
                        {
                            Id = 24,
                            CourseTypeId = 3,
                            Name = "Secretariado de Administração",
                            Tag = "SecAmin"
                        },
                        new
                        {
                            Id = 25,
                            CourseTypeId = 3,
                            Name = "Tecnologias e Programação de Sistemas de Informação",
                            Tag = "TPSI"
                        },
                        new
                        {
                            Id = 26,
                            CourseTypeId = 4,
                            Name = "Animação",
                            Tag = "Anim"
                        },
                        new
                        {
                            Id = 27,
                            CourseTypeId = 4,
                            Name = "Data Science and Digital Transformation",
                            Tag = "DSDT"
                        },
                        new
                        {
                            Id = 28,
                            CourseTypeId = 4,
                            Name = "Hidrogénio",
                            Tag = "Hidro"
                        },
                        new
                        {
                            Id = 29,
                            CourseTypeId = 4,
                            Name = "Renewable Energies and Environment",
                            Tag = "REE"
                        });
                });

            modelBuilder.Entity("MovieSphere.Models.CourseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Licenciatura"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Mestrado"
                        },
                        new
                        {
                            Id = 3,
                            Type = "CTeSP"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Pós-Graduação"
                        });
                });

            modelBuilder.Entity("MovieSphere.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApiReference")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieSphere.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("MovieId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ApplicationUserMovie", b =>
                {
                    b.HasOne("MovieSphere.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("FavouriteMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieSphere.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UsersWhoFavouritedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationUserMovie1", b =>
                {
                    b.HasOne("MovieSphere.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UsersInWatchlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieSphere.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("WatchlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MovieSphere.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MovieSphere.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieSphere.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MovieSphere.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieSphere.Models.ApplicationUser", b =>
                {
                    b.HasOne("MovieSphere.Models.Course", "Course")
                        .WithMany("UsersInCourse")
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("MovieSphere.Models.Comment", b =>
                {
                    b.HasOne("MovieSphere.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Comments")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieSphere.Models.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieSphere.Models.Course", b =>
                {
                    b.HasOne("MovieSphere.Models.CourseType", "CourseType")
                        .WithMany("Courses")
                        .HasForeignKey("CourseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseType");
                });

            modelBuilder.Entity("MovieSphere.Models.Rating", b =>
                {
                    b.HasOne("MovieSphere.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Ratings")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieSphere.Models.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieSphere.Models.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("MovieSphere.Models.Course", b =>
                {
                    b.Navigation("UsersInCourse");
                });

            modelBuilder.Entity("MovieSphere.Models.CourseType", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("MovieSphere.Models.Movie", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
