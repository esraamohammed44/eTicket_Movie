﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTickets.Models;

#nullable disable

namespace eTickets.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240403202711_init5")]
    partial class init5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eTickets.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("eTickets.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "You can watch all types of movies including horror.\r\n     They typically have multiple screens and show a wide variety of films.",
                            Logo = "Multiplex Cinemas.jfif",
                            Name = "Multiplex Cinemas"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Independent cinemas, \r\n      tucked in local neighborhoods, \r\n      curate diverse films beyond blockbusters, \r\n     fostering community and showcasing thought-provoking cinema.",
                            Logo = "Independent Cinemas.jfif",
                            Name = "Independent Cinemas"
                        },
                        new
                        {
                            Id = 3,
                            Description = "IMAX theaters are known for their large screens and immersive sound systems, \r\n    making them ideal for action-packed movies.'",
                            Logo = "IMAX Theaters.jfif",
                            Name = "IMAX Theaters"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Some cinemas specialize in specific genres or types of films,\r\n     such as comedy clubs for comedy movies and art-house theaters for indie and foreign films.",
                            Logo = "Specialty Cinemas.jfif",
                            Name = "Specialty Cinemas"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Movies like 'Toy Story' are popular choices for children's cinemas,\r\n     which cater to families and young audiences with kid-friendly amenities and activities.",
                            Logo = "Children's Cinemas.jfif",
                            Name = "Children's Cinemas"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Drive-in cinemas offer a nostalgic outdoor movie-watching experience,\r\n    ideal for enjoying films comfortably from your car.",
                            Logo = "Drive-In Cinemas.jfif",
                            Name = "Drive-In Cinemas"
                        });
                });

            modelBuilder.Entity("eTickets.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "Tom Hardy, an English actor renowned for his versatility, \r\n     captivates audiences with his intense performances.",
                            FullName = "Tom Hardy",
                            ProfilePictureURL = "Tom Hardy.jfif"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Jonah Hill is an American actor acclaimed for comedic brilliance,' \r\n    seamlessly transitioning to riveting dramatic roles '",
                            FullName = "Jonah Hill",
                            ProfilePictureURL = "Jonah Hill.jfif"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "Michael Cera is a Canadian actor known for his endearing awkwardness and comedic timing, \r\n     harming audiences in films.",
                            FullName = "Michael Cera",
                            ProfilePictureURL = "Michael Cera.jfif"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Tim Robbins is an American actor recognized for his roles \r\n    in 'The Shawshank Redemption' and 'Mystic River,'showcasing his versatility and depth as a performer.",
                            FullName = "Tim Robbins",
                            ProfilePictureURL = "Tim Robbins.jfif"
                        },
                        new
                        {
                            Id = 5,
                            Biography = "Morgan Freeman is an iconic American actor known for his authoritative presence \r\n    and memorable performances in films.",
                            FullName = "Morgan Freeman",
                            ProfilePictureURL = "Morgan Freeman.jfif"
                        },
                        new
                        {
                            Id = 6,
                            Biography = "Tom Hanks is an iconic American actor celebrated for his versatility \r\n    and captivating performances.",
                            FullName = "Tom Hanks",
                            ProfilePictureURL = "Tom Hanks.jfif"
                        },
                        new
                        {
                            Id = 7,
                            Biography = "Tim Allen is an American actor known for his comedic talent.",
                            FullName = "Tim Allen",
                            ProfilePictureURL = "Tim Allen.jfif"
                        },
                        new
                        {
                            Id = 8,
                            Biography = "Jack Nicholson is a legendary American actor known for his iconic roles \r\n   ,'captivating audiences with his intense performances and unique on-screen presence.",
                            FullName = "Jack Nicholson",
                            ProfilePictureURL = "Jack Nicholson.jfif"
                        },
                        new
                        {
                            Id = 9,
                            Biography = "Christian Bale, a British actor, embodies characters with remarkable intensity and commitment, \r\n     showcasing his range from iconic superhero roles to complex, psychologically rich performances.",
                            FullName = "Christian Bale",
                            ProfilePictureURL = "Christian Bale.jfif"
                        },
                        new
                        {
                            Id = 10,
                            Biography = "Bradley Cooper is an American actor known for his versatility, \r\n    starring in acclaimed films ,",
                            FullName = "Bradley Cooper",
                            ProfilePictureURL = "Bradley Cooper.jfif"
                        },
                        new
                        {
                            Id = 11,
                            Biography = "Ed Helms, an American actor, is celebrated for his comedic talent, portraying Stu in 'The Hangover' \r\n     trilogy and Andy Bernard in 'The Office,'showcasing his versatile and humorous performances.",
                            FullName = "Ed Helms",
                            ProfilePictureURL = "Ed Helms.jfif"
                        },
                        new
                        {
                            Id = 12,
                            Biography = "Zach Galifianakis is an American actor known for his eccentric comedic style, \r\n    particularly in films.",
                            FullName = "Zach Galifianakis",
                            ProfilePictureURL = "Zach Galifianakis.jfif"
                        },
                        new
                        {
                            Id = 13,
                            Biography = " Fred Rogers, his gentle demeanor and compassionate spirit enriched the hearts of viewers \r\n    through 'Mister Rogers' Neighborhood,' fostering kindness and empathy in generations of children and adults alike.",
                            FullName = " Fred Rogers",
                            ProfilePictureURL = "Fred Rogers.jfif"
                        });
                });

            modelBuilder.Entity("eTickets.Models.Hero_Movie", b =>
                {
                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("HeroId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Heroes_Movies");

                    b.HasData(
                        new
                        {
                            HeroId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            HeroId = 2,
                            MovieId = 2
                        },
                        new
                        {
                            HeroId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            HeroId = 7,
                            MovieId = 3
                        },
                        new
                        {
                            HeroId = 5,
                            MovieId = 3
                        },
                        new
                        {
                            HeroId = 5,
                            MovieId = 4
                        },
                        new
                        {
                            HeroId = 7,
                            MovieId = 5
                        },
                        new
                        {
                            HeroId = 6,
                            MovieId = 5
                        },
                        new
                        {
                            HeroId = 8,
                            MovieId = 6
                        },
                        new
                        {
                            HeroId = 9,
                            MovieId = 7
                        },
                        new
                        {
                            HeroId = 10,
                            MovieId = 8
                        },
                        new
                        {
                            HeroId = 11,
                            MovieId = 8
                        },
                        new
                        {
                            HeroId = 12,
                            MovieId = 8
                        },
                        new
                        {
                            HeroId = 6,
                            MovieId = 9
                        },
                        new
                        {
                            HeroId = 13,
                            MovieId = 10
                        });
                });

            modelBuilder.Entity("eTickets.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 3,
                            Description = "Mad Max:Fury Road is an intense action film set in a post-apocalyptic world, \r\n         where a reluctant hero and a fierce warrior rebel against a tyrannical ruler in a high-octane battle for survival.",
                            EndDate = new DateTime(2024, 4, 11, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7457),
                            ImageURL = "Mad Max.jfif",
                            MovieCategory = 1,
                            Name = "Mad Max",
                            Price = 10.0,
                            ProducerId = 1,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7445)
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 4,
                            Description = "Superbad is a hilarious coming-of-age comedy film about two high school friends\r\n     on a wild adventure to secure alcohol for a party, leading to outrageous antics and unexpected challenges.",
                            EndDate = new DateTime(2024, 4, 15, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7465),
                            ImageURL = "Superbad.jfif",
                            MovieCategory = 2,
                            Name = "Superbad",
                            Price = 20.0,
                            ProducerId = 2,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7465)
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 2,
                            Description = "The Shawshank Redemption follows Andy Dufresne, a banker wrongfully convicted of murder,\r\n    as he navigates prison life, finding solace and redemption through perseverance and friendship.",
                            EndDate = new DateTime(2024, 5, 31, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7468),
                            ImageURL = "The Shawshank Redemption.jfif",
                            MovieCategory = 3,
                            Name = "The Shawshank Redemption",
                            Price = 30.0,
                            ProducerId = 3,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7467)
                        },
                        new
                        {
                            Id = 4,
                            CinemaId = 2,
                            Description = "March of the Penguins is a captivating documentary showcasing the journey of emperor penguins in the Antarctic,\r\n    revealing their resilience and determination in extreme conditions.",
                            EndDate = new DateTime(2024, 5, 11, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7470),
                            ImageURL = "March of the Penguins.jfif",
                            MovieCategory = 4,
                            Name = "March of the Penguins",
                            Price = 20.0,
                            ProducerId = 4,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7469)
                        },
                        new
                        {
                            Id = 5,
                            CinemaId = 5,
                            Description = "Toy Story is a heartwarming animated adventure film following the journey \r\n    of toys led by Woody and Buzz Lightyear.",
                            EndDate = new DateTime(2024, 5, 21, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7472),
                            ImageURL = "Toy Story.jfif",
                            MovieCategory = 5,
                            Name = "Toy Story",
                            Price = 20.0,
                            ProducerId = 5,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7471)
                        },
                        new
                        {
                            Id = 6,
                            CinemaId = 1,
                            Description = "The Shining is a psychological horror film directed by Stanley Kubrick, \r\n    adapted from Stephen King's novel.",
                            EndDate = new DateTime(2024, 5, 9, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7473),
                            ImageURL = "The Shining.jfif",
                            MovieCategory = 6,
                            Name = "The Shining",
                            Price = 20.0,
                            ProducerId = 6,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7473)
                        },
                        new
                        {
                            Id = 7,
                            CinemaId = 3,
                            Description = "The Dark Knight is a thrilling superhero epic pitting Batman against the Joker,\r\n    featuring Heath Ledger's iconic portrayal.",
                            EndDate = new DateTime(2024, 4, 21, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7475),
                            ImageURL = "The Dark Knight.jfif",
                            MovieCategory = 1,
                            Name = "The Dark Knight",
                            Price = 150.0,
                            ProducerId = 7,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7475)
                        },
                        new
                        {
                            Id = 8,
                            CinemaId = 4,
                            Description = "The Hangover is a raucous comedy following a wild bachelor party in Las Vegas,\r\n     as the groomsmen attempt to piece together the events of the night before.",
                            EndDate = new DateTime(2024, 4, 28, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7477),
                            ImageURL = "The Hangover.jfif",
                            MovieCategory = 2,
                            Name = "The Hangover",
                            Price = 90.0,
                            ProducerId = 8,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7477)
                        },
                        new
                        {
                            Id = 9,
                            CinemaId = 2,
                            Description = "Forrest Gump is a heartwarming tale following the remarkable life of Forrest Gump, \r\n    a simple yet extraordinary man who unwittingly finds himself at the center of key moments in American history.",
                            EndDate = new DateTime(2024, 4, 10, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7479),
                            ImageURL = "Forrest Gump.jfif",
                            MovieCategory = 3,
                            Name = "Forrest Gump",
                            Price = 10.0,
                            ProducerId = 9,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7479)
                        },
                        new
                        {
                            Id = 10,
                            CinemaId = 2,
                            Description = "Won't You Be My Neighbor? is a heartfelt documentary exploring Fred Rogers' legacy,\r\n    celebrating his message of kindness and empathy in \"Mister Rogers' Neighborhood.",
                            EndDate = new DateTime(2024, 5, 1, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7481),
                            ImageURL = "Won't_You_Be_My_Neighbor.jfif",
                            MovieCategory = 4,
                            Name = "Won't You Be My Neighbor?",
                            Price = 20.0,
                            ProducerId = 10,
                            StartDate = new DateTime(2024, 4, 3, 22, 27, 9, 440, DateTimeKind.Local).AddTicks(7481)
                        });
                });

            modelBuilder.Entity("eTickets.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eTickets.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("eTickets.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "George Miller  is an Australian filmmaker celebrated for directing the groundbreaking \r\n    'Mad Max' series, showcasing his visionary storytelling and influence in the action genre.",
                            FullName = "George Miller",
                            ProfilePictureURL = "George Miller.jfif"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Judd Apatow is an American filmmaker known for his comedic genius, directing \r\n    and producing hit comedies.",
                            FullName = "Judd Apatow",
                            ProfilePictureURL = "Judd Apatow.jfif"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "Niki Marvin, a film producer, has garnered acclaim for her work,\r\n    demonstrating a keen eye for talent and a commitment to bringing compelling stories to the screen.",
                            FullName = "Niki Marvin",
                            ProfilePictureURL = "Niki Marvin.jfif"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Luc Jacquet is a French filmmaker acclaimed for his captivating nature documentaries, notably the \r\n    Academy Award-winning 'March of the Penguins.'",
                            FullName = "Luc Jacquet",
                            ProfilePictureURL = "Luc Jacquet.jfif"
                        },
                        new
                        {
                            Id = 5,
                            Biography = "Pixar Animation Studios is a renowned animation studio celebrated for its revolutionary storytelling \r\n    and groundbreaking computer-animated films, captivating audiences worldwide with its imaginative and heartfelt storytelling.",
                            FullName = "Pixar Animation Studios",
                            ProfilePictureURL = "Pixar Animation Studios.jfif"
                        },
                        new
                        {
                            Id = 6,
                            Biography = "Stanley Kubrick was a visionary filmmaker renowned for his meticulous attention to detail and profound \r\n    storytelling, creating cinematic masterpieces .",
                            FullName = "Stanley Kubrick",
                            ProfilePictureURL = "Stanley Kubrick.jfif"
                        },
                        new
                        {
                            Id = 7,
                            Biography = "Christopher Nolan is a visionary filmmaker celebrated for his innovative storytelling and captivating \r\n    narratives, directing iconic films .",
                            FullName = "Christopher Nolan",
                            ProfilePictureURL = "Christopher Nolan.jfif"
                        },
                        new
                        {
                            Id = 8,
                            Biography = "Todd Phillips, a filmmaker known for his edgy comedies,\r\n    rose to prominence with 'The Hangover' trilogy,\r\n    showcasing his unique blend of humor and storytelling prowess.",
                            FullName = "Todd Phillips",
                            ProfilePictureURL = "Todd Phillips.jfif"
                        },
                        new
                        {
                            Id = 9,
                            Biography = "Wendy Finerman, a renowned film producer, \r\n    has earned accolades for her exceptional storytelling and her ability to bring compelling narratives to life on the big screen.",
                            FullName = "Wendy Finerman",
                            ProfilePictureURL = "Wendy Finerman.jfif"
                        },
                        new
                        {
                            Id = 10,
                            Biography = "Morgan Neville, a renowned documentary filmmaker, captures the essence of his subjects,\r\n    crafting compelling narratives that resonate globally.",
                            FullName = "Morgan Neville",
                            ProfilePictureURL = "Morgan Neville.jfif"
                        });
                });

            modelBuilder.Entity("eTickets.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("eTickets.Models.Hero_Movie", b =>
                {
                    b.HasOne("eTickets.Models.Hero", "Hero")
                        .WithMany("Heroes_Movies")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTickets.Models.Movie", "Movie")
                        .WithMany("Heroes_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("eTickets.Models.Movie", b =>
                {
                    b.HasOne("eTickets.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTickets.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("eTickets.Models.Order", b =>
                {
                    b.HasOne("eTickets.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("eTickets.Models.OrderItem", b =>
                {
                    b.HasOne("eTickets.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTickets.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("eTickets.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("eTickets.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("eTickets.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("eTickets.Models.Hero", b =>
                {
                    b.Navigation("Heroes_Movies");
                });

            modelBuilder.Entity("eTickets.Models.Movie", b =>
                {
                    b.Navigation("Heroes_Movies");
                });

            modelBuilder.Entity("eTickets.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("eTickets.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
