using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedImagesToActors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("2c930da8-a775-4cbc-89d3-98502e7dd56b"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("31150776-818d-4b3b-800c-05e7f2ee33c4"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("9e26d589-2f52-4bfc-9235-6a17805d1e8a"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b9cb95c7-959c-447d-ba1d-7d01b212e211"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("ca03a70a-7aef-4c0d-aad0-422e592d6023"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1978ff18-e610-44fa-a211-63eabbe729eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32372abf-5415-4e33-8c51-667582d12d29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f4be04a-0190-4842-9741-115a3acd9bfb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b2d25d3-53b7-43b2-bab7-29da4101a025"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e701d78f-2308-445a-9cf4-b29c5abbf4a3"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("4d0c532f-e869-4ad7-8c03-4e803a53d96c"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("883418f6-343c-4a5e-a82c-6bf9181328f4"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b9e3e981-f1ab-49dd-b985-5e988cec0617"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("baf370bd-d872-4660-b69c-a6cdd4a7f5af"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d18d7978-d54e-437f-b4b0-673e0a397a2f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0365c56b-867f-4afd-b6e7-c0015cfd8419"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("574a1279-30d5-4f38-8f09-a824bea14a94"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6590443c-dbf0-48d9-980e-de34fa357785"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b2ffe00f-a8d9-4794-9da2-e3a856023ada"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bd16e149-6836-4adf-ae26-22053dc97239"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c8a9af71-b474-4916-b8bd-6f052f02be23"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cad3f6c4-a981-466a-b673-91935c4cb399"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cbd62656-3eee-496f-b1eb-63a81e02e69e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cf588d07-9e4c-4df1-92a0-2b2f50de6602"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d288f4c5-b0a0-432e-a1fa-b42ad35464c8"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("3b760801-a680-42b5-8c5f-d6f1d21b5342"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("51dbfa36-40ad-4145-80e4-056a6558d494"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("71d90b87-81ce-4d3a-9c15-328ca0377dd5"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("8f3d122f-c573-4da3-a2c5-861d9ef3f5c7"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("9f8d83fa-aa6b-4f98-a8db-fafe3fc78c98"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("372e0b93-8f2c-4e33-b95a-049a13b15f5b"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("4a69cf30-4bfe-4ef3-b441-3a88a77ae7e2"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("81293d7d-1927-420a-8522-f672e8eacf91"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("a876c18d-bb90-47bb-93f2-9bd16be70434"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("ba26e259-3e43-4a95-8bd3-367f2a103c9f"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("12f9819b-f731-4781-babe-194c02fda69c"), "", "France" },
                    { new Guid("397cf95a-6055-4f24-98d4-5f813ef854b5"), "", "United States" },
                    { new Guid("3e00c2a2-b4f4-4f50-ae4d-1c5b69f6e2b5"), "", "United Kingdom" },
                    { new Guid("8c708a0a-e79d-4432-a73e-64ea19ec6ff9"), "", "India" },
                    { new Guid("9825fe6d-a953-4bd6-b657-a188df379a00"), "", "China" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("764ea858-2a0b-4e82-90a9-608f58ca9a56"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.", "", "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)", "Rajkumar", "Hirani" },
                    { new Guid("b966382b-53db-4188-aa33-705c777f592e"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic American filmmaker widely regarded as one of the greatest and most influential directors in cinematic history. Known for his meticulous attention to detail, innovative techniques, and ability to master various genres, Kubrick's films are celebrated for their depth, visual artistry, and thematic complexity.", "", "The Shining(1980), Lolita(1962), Eyes Wide Shut(1957)", "Stanley", "Kubrick" },
                    { new Guid("cb349bee-b70e-495e-a956-0a66c291ede0"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.", "", "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)", "Andrei", "Tarkovsky" },
                    { new Guid("f87b1789-883f-4339-85ee-86285d224513"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.", "", "The Mist(2007), The Salton Sea(2002), The Majestic(2001)", "Frank", "Darabont" },
                    { new Guid("f9cf4f76-6a90-4d0f-aa01-2215bf9d77ea"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.", "", "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)", "Christopher", "Nolan" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("09718195-1846-479f-ba60-52d050786eea"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("1c7fb643-1b78-4c2c-a860-ac53e18ebc5f"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("27596418-70f8-4ded-9f0a-5a3534f3a8af"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("5f55d656-b3cf-44e1-84b4-893956e0967d"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("875c9361-306d-4fbe-99a0-b34c999b8ddd"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("8b5637a8-aec3-4ecd-87e7-75077f265337"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("96ee1efb-adb0-43d3-8109-cbd339614e51"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("c8c97c16-1717-4ae2-8bcc-8ac8f3418e33"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("ce1edfdf-b2de-4308-b035-be00dfdc7435"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("db03dacc-6945-436a-b2bd-a635e7d9d6d6"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("3b15785d-6de1-4873-a4b7-6f1ec7fe6d62"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("71b81885-6aff-42a2-8f1f-7b2ae704a880"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("7e0a2fad-f7c2-4dca-8452-ff1e763a5b78"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("9c74cc00-ff08-461d-aba2-b20a579687c9"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("a2f1813b-891d-4bb9-8a15-72b785210981"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("372e0b93-8f2c-4e33-b95a-049a13b15f5b"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("4a69cf30-4bfe-4ef3-b441-3a88a77ae7e2"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("81293d7d-1927-420a-8522-f672e8eacf91"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("a876c18d-bb90-47bb-93f2-9bd16be70434"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("ba26e259-3e43-4a95-8bd3-367f2a103c9f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12f9819b-f731-4781-babe-194c02fda69c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("397cf95a-6055-4f24-98d4-5f813ef854b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e00c2a2-b4f4-4f50-ae4d-1c5b69f6e2b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c708a0a-e79d-4432-a73e-64ea19ec6ff9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9825fe6d-a953-4bd6-b657-a188df379a00"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("764ea858-2a0b-4e82-90a9-608f58ca9a56"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b966382b-53db-4188-aa33-705c777f592e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("cb349bee-b70e-495e-a956-0a66c291ede0"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("f87b1789-883f-4339-85ee-86285d224513"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("f9cf4f76-6a90-4d0f-aa01-2215bf9d77ea"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("09718195-1846-479f-ba60-52d050786eea"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1c7fb643-1b78-4c2c-a860-ac53e18ebc5f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("27596418-70f8-4ded-9f0a-5a3534f3a8af"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5f55d656-b3cf-44e1-84b4-893956e0967d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("875c9361-306d-4fbe-99a0-b34c999b8ddd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8b5637a8-aec3-4ecd-87e7-75077f265337"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("96ee1efb-adb0-43d3-8109-cbd339614e51"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c8c97c16-1717-4ae2-8bcc-8ac8f3418e33"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ce1edfdf-b2de-4308-b035-be00dfdc7435"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("db03dacc-6945-436a-b2bd-a635e7d9d6d6"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("3b15785d-6de1-4873-a4b7-6f1ec7fe6d62"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("71b81885-6aff-42a2-8f1f-7b2ae704a880"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("7e0a2fad-f7c2-4dca-8452-ff1e763a5b78"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("9c74cc00-ff08-461d-aba2-b20a579687c9"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("a2f1813b-891d-4bb9-8a15-72b785210981"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("2c930da8-a775-4cbc-89d3-98502e7dd56b"), "", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("31150776-818d-4b3b-800c-05e7f2ee33c4"), "", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("9e26d589-2f52-4bfc-9235-6a17805d1e8a"), "", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("b9cb95c7-959c-447d-ba1d-7d01b212e211"), "", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("ca03a70a-7aef-4c0d-aad0-422e592d6023"), "", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("1978ff18-e610-44fa-a211-63eabbe729eb"), "", "India" },
                    { new Guid("32372abf-5415-4e33-8c51-667582d12d29"), "", "United Kingdom" },
                    { new Guid("3f4be04a-0190-4842-9741-115a3acd9bfb"), "", "United States" },
                    { new Guid("7b2d25d3-53b7-43b2-bab7-29da4101a025"), "", "France" },
                    { new Guid("e701d78f-2308-445a-9cf4-b29c5abbf4a3"), "", "China" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("4d0c532f-e869-4ad7-8c03-4e803a53d96c"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.", "", "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)", "Rajkumar", "Hirani" },
                    { new Guid("883418f6-343c-4a5e-a82c-6bf9181328f4"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.", "", "The Mist(2007), The Salton Sea(2002), The Majestic(2001)", "Frank", "Darabont" },
                    { new Guid("b9e3e981-f1ab-49dd-b985-5e988cec0617"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.", "", "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)", "Christopher", "Nolan" },
                    { new Guid("baf370bd-d872-4660-b69c-a6cdd4a7f5af"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic American filmmaker widely regarded as one of the greatest and most influential directors in cinematic history. Known for his meticulous attention to detail, innovative techniques, and ability to master various genres, Kubrick's films are celebrated for their depth, visual artistry, and thematic complexity.", "", "The Shining(1980), Lolita(1962), Eyes Wide Shut(1957)", "Stanley", "Kubrick" },
                    { new Guid("d18d7978-d54e-437f-b4b0-673e0a397a2f"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.", "", "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)", "Andrei", "Tarkovsky" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0365c56b-867f-4afd-b6e7-c0015cfd8419"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("574a1279-30d5-4f38-8f09-a824bea14a94"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("6590443c-dbf0-48d9-980e-de34fa357785"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("b2ffe00f-a8d9-4794-9da2-e3a856023ada"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("bd16e149-6836-4adf-ae26-22053dc97239"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("c8a9af71-b474-4916-b8bd-6f052f02be23"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("cad3f6c4-a981-466a-b673-91935c4cb399"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("cbd62656-3eee-496f-b1eb-63a81e02e69e"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("cf588d07-9e4c-4df1-92a0-2b2f50de6602"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("d288f4c5-b0a0-432e-a1fa-b42ad35464c8"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("3b760801-a680-42b5-8c5f-d6f1d21b5342"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("51dbfa36-40ad-4145-80e4-056a6558d494"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("71d90b87-81ce-4d3a-9c15-328ca0377dd5"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("8f3d122f-c573-4da3-a2c5-861d9ef3f5c7"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("9f8d83fa-aa6b-4f98-a8db-fafe3fc78c98"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" }
                });
        }
    }
}
