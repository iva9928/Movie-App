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
    [Migration("20241129153327_MovieImage")]
    partial class MovieImage
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
                            Id = new Guid("4157168c-c760-4567-b9a4-59d46687d7a9"),
                            ActorImageUrl = "",
                            Description = "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.",
                            FirstName = "Bradley",
                            Surname = "Cooper"
                        },
                        new
                        {
                            Id = new Guid("72999acc-bf72-43ad-82a7-18a135b32d2e"),
                            ActorImageUrl = "",
                            Description = "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.",
                            FirstName = "Colman",
                            Surname = "Domingo"
                        },
                        new
                        {
                            Id = new Guid("91c13d08-9676-4c62-83fc-595f5cf8e61f"),
                            ActorImageUrl = "",
                            Description = "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.",
                            FirstName = "Paul",
                            Surname = "Giamatti"
                        },
                        new
                        {
                            Id = new Guid("54ef3a5a-91ca-4c87-adb0-7321a06b402d"),
                            ActorImageUrl = "",
                            Description = "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.",
                            FirstName = "Scarlett",
                            Surname = "Johansson"
                        },
                        new
                        {
                            Id = new Guid("c5d80ce6-d539-43c5-8c2b-85065c603a98"),
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
                            Id = new Guid("2a3969de-e2b7-4b78-a528-c0c54a8556c3"),
                            CountryImageUrl = "",
                            Name = "China"
                        },
                        new
                        {
                            Id = new Guid("a959d457-e457-4d64-b993-29c97ae33844"),
                            CountryImageUrl = "",
                            Name = "United States"
                        },
                        new
                        {
                            Id = new Guid("4e512c54-9dd0-46c0-be27-65c1404e6d11"),
                            CountryImageUrl = "",
                            Name = "India"
                        },
                        new
                        {
                            Id = new Guid("c012ee38-c274-4f0a-938e-eae51aebe713"),
                            CountryImageUrl = "",
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = new Guid("ad8b134f-73a5-4fcd-befb-2f08a03942b3"),
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
                            Id = new Guid("c1706ec2-9fac-4ebc-81de-78355f5da51f"),
                            Description = "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.",
                            DirectorImageUrl = "",
                            FamousMovies = "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)",
                            FirstName = "Christopher",
                            Surname = "Nolan"
                        },
                        new
                        {
                            Id = new Guid("56c770a7-b943-49c3-8b17-f30aa8a52922"),
                            Description = "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.",
                            DirectorImageUrl = "",
                            FamousMovies = "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)",
                            FirstName = "Rajkumar",
                            Surname = "Hirani"
                        },
                        new
                        {
                            Id = new Guid("59798193-e3fc-4bad-814d-a6b54b65f011"),
                            Description = "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.",
                            DirectorImageUrl = "",
                            FamousMovies = "The Mist(2007), The Salton Sea(2002), The Majestic(2001)",
                            FirstName = "Frank",
                            Surname = "Darabont"
                        },
                        new
                        {
                            Id = new Guid("335c06b5-3153-4279-b762-fd506257de9d"),
                            Description = "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.",
                            DirectorImageUrl = "",
                            FamousMovies = "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)",
                            FirstName = "Andrei",
                            Surname = "Tarkovsky"
                        },
                        new
                        {
                            Id = new Guid("a0a5bb2d-1b0b-4137-9ac2-d3adb9dfda66"),
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
                            Id = new Guid("a1d88dca-2415-4596-b454-b6c6d55dd522"),
                            Casts = "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn",
                            Country = "United States of America",
                            Description = "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country",
                            Duration = 83,
                            Genre = "Horror",
                            MovieImageUrl = "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg",
                            Production = "New Line Cinema, Vortex",
                            ReleaseDate = new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Texas Chain Saw Massacre"
                        },
                        new
                        {
                            Id = new Guid("8a34737c-8e5a-418f-80db-fe6a5fc4a63b"),
                            Casts = "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb",
                            Country = "United States of America",
                            Description = "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.",
                            Duration = 122,
                            Genre = "Horror",
                            MovieImageUrl = "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg",
                            Production = "Hoya Productions, Warner Bros. Pictures",
                            ReleaseDate = new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Exorcist"
                        },
                        new
                        {
                            Id = new Guid("e5cbe4ff-867a-46db-98b9-829794033585"),
                            Casts = "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson",
                            Country = "United Kingdom, United States of America",
                            Description = "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.",
                            Duration = 144,
                            Genre = "Horror",
                            MovieImageUrl = "https://cdn.cdon.com/media-dynamic/images/product/movie/blu-ray/image0/the_shining_blu-raynordic-14293317-frntl.jpg.jpg",
                            Production = "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle",
                            ReleaseDate = new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = new Guid("6a767df0-c751-4721-82a6-261186f19509"),
                            Casts = "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy",
                            Country = "United States of America",
                            Description = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.",
                            Duration = 112,
                            Genre = "Horror",
                            MovieImageUrl = "https://i.scdn.co/image/ab67616d0000b273e7aa148aa42655dac897fb2d.jpg",
                            Production = "New Line Cinema, The Safran Company, Evergreen Media Group",
                            ReleaseDate = new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Conjuring"
                        },
                        new
                        {
                            Id = new Guid("b2c2ef23-f661-4844-9d9d-30ddd4be8d3b"),
                            Casts = "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander",
                            Country = "Japan, United States of America",
                            Description = "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.",
                            Duration = 115,
                            Genre = "Horror",
                            MovieImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRId646Gjwh5D086Kx2uqQOcf4FNwCErx2eJQm41oU4Z2DOVGP7-E1oHLjdwTcVbsDJ41A&usqp=CAU.jpg",
                            Production = "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks",
                            ReleaseDate = new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Ring"
                        },
                        new
                        {
                            Id = new Guid("06c83f05-36b9-4d19-a75b-c0d24851eb1d"),
                            Casts = "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch",
                            Country = "United States of America",
                            Description = "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.",
                            Duration = 96,
                            Genre = "Horror",
                            MovieImageUrl = "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg",
                            Production = "New Line Cinema, Atomic Monster, The Safran Company",
                            ReleaseDate = new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Nun"
                        },
                        new
                        {
                            Id = new Guid("7b9693ae-9fe7-4d36-8be9-507f83fc6362"),
                            Casts = "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson",
                            Country = "United States of America",
                            Description = "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.",
                            Duration = 110,
                            Genre = "Horror",
                            MovieImageUrl = "https://i5.walmartimages.com/asr/ade253ad-6001-48a8-a007-4238d562f9be.bbf3edad065ecd2f8dccdb71a8a7c12c.jpeg.jpg",
                            Production = "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures",
                            ReleaseDate = new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sinister"
                        },
                        new
                        {
                            Id = new Guid("fdab582b-de9d-4433-aa13-8fa0c83f2bd4"),
                            Casts = "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe",
                            Country = "United States of America",
                            Description = "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.",
                            Duration = 101,
                            Genre = "Horror",
                            MovieImageUrl = "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg",
                            Production = "Two Flints, Northern Lights Films, Animal Kingdom",
                            ReleaseDate = new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "It Follows"
                        },
                        new
                        {
                            Id = new Guid("033fd3d7-8b0c-4c7a-916d-41be75262c4e"),
                            Casts = "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West",
                            Country = "Canada, Australia",
                            Description = "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.",
                            Duration = 94,
                            Genre = "Horror",
                            MovieImageUrl = "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg",
                            Production = "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One",
                            ReleaseDate = new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Babadook"
                        },
                        new
                        {
                            Id = new Guid("054f48e3-b9fa-4aff-88df-bc93145b2d56"),
                            Casts = "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes",
                            Country = "Spain, United States of America, France, Italy",
                            Description = "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.",
                            Duration = 101,
                            Genre = "Horror",
                            MovieImageUrl = "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg.jpg",
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
                            Id = new Guid("87ac7177-c072-4823-a8a4-5ad0837bc2b2"),
                            CharacterName = "Michael Scofield",
                            Description = "'Sometimes, the only way to truly escape the past is to keep moving forward.'",
                            MovieOrShow = "Prison Break"
                        },
                        new
                        {
                            Id = new Guid("be23d1ca-f21e-4de0-a273-d27695290bda"),
                            CharacterName = "Tyrion Lannister",
                            Description = "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”",
                            MovieOrShow = "Game og Thrones"
                        },
                        new
                        {
                            Id = new Guid("e5a4d596-34b0-43e4-89df-5d069b67cc49"),
                            CharacterName = "Fernando Sucre",
                            Description = "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”",
                            MovieOrShow = "Prison Break"
                        },
                        new
                        {
                            Id = new Guid("2e18c079-2027-4b9b-a49a-37c8c4df618d"),
                            CharacterName = "Yoda",
                            Description = "“Do, or do not. There is no try.”",
                            MovieOrShow = "Star Wars"
                        },
                        new
                        {
                            Id = new Guid("d10f8ff2-7cbd-451d-bb5a-858838458854"),
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