﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Data;

#nullable disable

namespace MovieWebApp.Migrations
{
    [DbContext(typeof(MovieAppDbContext))]
    [Migration("20241128202144_CreatedNewTables")]
    partial class CreatedNewTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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

            modelBuilder.Entity("MovieApp.DataModels.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActorImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("faac100c-1f5f-417d-bd9a-7408b8223239"),
                            ActorImageUrl = "",
                            Description = "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.",
                            FirstName = "Bradley",
                            Surname = "Cooper"
                        },
                        new
                        {
                            Id = new Guid("76e30935-7e58-4e4f-9671-bed111cac6ef"),
                            ActorImageUrl = "",
                            Description = "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.",
                            FirstName = "Colman",
                            Surname = "Domingo"
                        },
                        new
                        {
                            Id = new Guid("a12a7db9-ef16-4afb-870e-e918ccf54d24"),
                            ActorImageUrl = "",
                            Description = "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.",
                            FirstName = "Paul",
                            Surname = "Giamatti"
                        },
                        new
                        {
                            Id = new Guid("bde8f465-8f3f-4855-b121-a5088da12b1a"),
                            ActorImageUrl = "",
                            Description = "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.",
                            FirstName = "Scarlett",
                            Surname = "Johansson"
                        },
                        new
                        {
                            Id = new Guid("3294cf1c-5fdd-4f58-bf2c-7fd48e8ddc9a"),
                            ActorImageUrl = "",
                            Description = "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.",
                            FirstName = "Cillian",
                            Surname = "Murphy"
                        });
                });

            modelBuilder.Entity("MovieApp.DataModels.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a186c7c5-f81a-4d86-9940-acc168ddabf6"),
                            CountryImageUrl = "",
                            Name = "China"
                        },
                        new
                        {
                            Id = new Guid("39aa0b52-c6ac-4275-8fe9-ee1b49c3aadf"),
                            CountryImageUrl = "",
                            Name = "United States"
                        },
                        new
                        {
                            Id = new Guid("4bffae18-16af-44d3-878f-a55f5ea66228"),
                            CountryImageUrl = "",
                            Name = "India"
                        },
                        new
                        {
                            Id = new Guid("1f288e71-e2f4-4a78-a435-0dfadf991e1a"),
                            CountryImageUrl = "",
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = new Guid("ebb8e72b-3723-4fe9-9942-87291681b8e6"),
                            CountryImageUrl = "",
                            Name = "France"
                        });
                });

            modelBuilder.Entity("MovieApp.DataModels.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("DirectorImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamousMovies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c65e982f-1910-494b-8e5c-13c258068a8a"),
                            Description = "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.",
                            DirectorImageUrl = "",
                            FamousMovies = "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)",
                            FirstName = "Christopher",
                            Surname = "Nolan"
                        },
                        new
                        {
                            Id = new Guid("f12485af-70a5-4909-8a94-060b540ed1aa"),
                            Description = "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.",
                            DirectorImageUrl = "",
                            FamousMovies = "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)",
                            FirstName = "Rajkumar",
                            Surname = "Hirani"
                        },
                        new
                        {
                            Id = new Guid("aa31f949-17ce-420f-b267-096b39416bc7"),
                            Description = "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.",
                            DirectorImageUrl = "",
                            FamousMovies = "The Mist(2007), The Salton Sea(2002), The Majestic(2001)",
                            FirstName = "Frank",
                            Surname = "Darabont"
                        },
                        new
                        {
                            Id = new Guid("cdf7047c-c666-409b-b16f-197fd70eb364"),
                            Description = "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.",
                            DirectorImageUrl = "",
                            FamousMovies = "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)",
                            FirstName = "Andrei",
                            Surname = "Tarkovsky"
                        },
                        new
                        {
                            Id = new Guid("8ea246da-fbe1-413f-a90a-b95fb3b73c73"),
                            Description = "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic American filmmaker widely regarded as one of the greatest and most influential directors in cinematic history. Known for his meticulous attention to detail, innovative techniques, and ability to master various genres, Kubrick's films are celebrated for their depth, visual artistry, and thematic complexity.",
                            DirectorImageUrl = "",
                            FamousMovies = "The Shining(1980), Lolita(1962), Eyes Wide Shut(1957)",
                            FirstName = "Stanley",
                            Surname = "Kubrick"
                        });
                });

            modelBuilder.Entity("MovieApp.DataModels.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Casts")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MovieImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Production")
                        .IsRequired()
                        .HasMaxLength(210)
                        .HasColumnType("nvarchar(210)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("71c8c406-add2-4397-a94d-cb8ed4591548"),
                            Casts = "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn",
                            Country = "United States of America",
                            Description = "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country",
                            Duration = 83,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "New Line Cinema, Vortex",
                            ReleaseDate = new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Texas Chain Saw Massacre"
                        },
                        new
                        {
                            Id = new Guid("f0611adc-0388-44d6-8180-7f03c5800c55"),
                            Casts = "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb",
                            Country = "United States of America",
                            Description = "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.",
                            Duration = 122,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "Hoya Productions, Warner Bros. Pictures",
                            ReleaseDate = new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Exorcist"
                        },
                        new
                        {
                            Id = new Guid("f69f4a29-4396-42f1-ab91-42978a01f073"),
                            Casts = "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson",
                            Country = "United Kingdom, United States of America",
                            Description = "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.",
                            Duration = 144,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle",
                            ReleaseDate = new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = new Guid("6eab60f1-9138-4126-85f3-23dffce42d1e"),
                            Casts = "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy",
                            Country = "United States of America",
                            Description = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.",
                            Duration = 112,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "New Line Cinema, The Safran Company, Evergreen Media Group",
                            ReleaseDate = new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Conjuring"
                        },
                        new
                        {
                            Id = new Guid("b41bae46-7ead-4359-9704-9519eaf5f71e"),
                            Casts = "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander",
                            Country = "Japan, United States of America",
                            Description = "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.",
                            Duration = 115,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks",
                            ReleaseDate = new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Ring"
                        },
                        new
                        {
                            Id = new Guid("004f7ef2-f350-46e3-857c-f26a08e5436a"),
                            Casts = "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch",
                            Country = "United States of America",
                            Description = "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.",
                            Duration = 96,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "New Line Cinema, Atomic Monster, The Safran Company",
                            ReleaseDate = new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Nun"
                        },
                        new
                        {
                            Id = new Guid("e1d335b9-d608-42c1-b1dd-d201afb6b229"),
                            Casts = "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson",
                            Country = "United States of America",
                            Description = "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.",
                            Duration = 110,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures",
                            ReleaseDate = new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sinister"
                        },
                        new
                        {
                            Id = new Guid("51665deb-74ab-4942-a8c7-8ed5b56d29ae"),
                            Casts = "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe",
                            Country = "United States of America",
                            Description = "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.",
                            Duration = 101,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "Two Flints, Northern Lights Films, Animal Kingdom",
                            ReleaseDate = new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "It Follows"
                        },
                        new
                        {
                            Id = new Guid("7ba5a59f-e0cd-4125-9c3e-e1e6579ebd5e"),
                            Casts = "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West",
                            Country = "Canada, Australia",
                            Description = "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.",
                            Duration = 94,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One",
                            ReleaseDate = new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Babadook"
                        },
                        new
                        {
                            Id = new Guid("b16d935c-8f81-4a5e-a6d6-6e4429b1125d"),
                            Casts = "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes",
                            Country = "Spain, United States of America, France, Italy",
                            Description = "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.",
                            Duration = 101,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg",
                            Production = " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax",
                            ReleaseDate = new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Others"
                        });
                });

            modelBuilder.Entity("MovieApp.DataModels.Quote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("MovieOrShow")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a85e8956-6f2e-4c2a-a810-b03a830d961f"),
                            CharacterName = "Michael Scofield",
                            Description = "'Sometimes, the only way to truly escape the past is to keep moving forward.'",
                            MovieOrShow = "Prison Break"
                        },
                        new
                        {
                            Id = new Guid("6157f242-7850-490f-823b-fc7d2c4a319e"),
                            CharacterName = "Tyrion Lannister",
                            Description = "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”",
                            MovieOrShow = "Game og Thrones"
                        },
                        new
                        {
                            Id = new Guid("24d437e6-9e24-4f6e-a2de-f156e358f341"),
                            CharacterName = "Fernando Sucre",
                            Description = "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”",
                            MovieOrShow = "Prison Break"
                        },
                        new
                        {
                            Id = new Guid("f95aea5f-8ea6-4f99-b556-84f762f8d570"),
                            CharacterName = "Yoda",
                            Description = "“Do, or do not. There is no try.”",
                            MovieOrShow = "Star Wars"
                        },
                        new
                        {
                            Id = new Guid("2adc379c-4497-4bfe-8564-f8dc2a9a9041"),
                            CharacterName = "Forest Gump",
                            Description = "“Life is like a box of chocolates. You never know what you’re gonna get.”",
                            MovieOrShow = "Forest Gump"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
