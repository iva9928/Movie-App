using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class MovieImageTry3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("45dd03eb-e734-42f8-8cfa-dfcb67344703"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("8b581e7a-2882-49fe-a9cc-c93aab4ebc8c"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("a63383e1-9bb6-4632-beee-60559aef2699"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("c8e1fed3-d079-47de-be1c-f908d33e31cb"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("f4034595-4e4a-4e51-acc7-dabced2cd9f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e3972ca-418d-4dc9-a00d-e178580c1bf6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76cbb285-39ff-447d-846c-15987213dd83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9061cde2-00a6-4c6e-a9db-7d72c2df06af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e865c860-c367-4474-be80-095f0a46d0a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea80a74a-860c-4376-862f-141fe3933090"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("28367338-1723-4ec7-8cd6-c4e99a96ed75"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("29091183-6759-42dd-8e58-a1ee1f6ba158"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("3b0cdb8f-68f4-42d6-93e3-1da0a9600687"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("47357c66-faf1-41dd-86cb-9e6c749cd3e6"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("88ecffab-35f2-40f2-b113-7a4017acf62a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("09d8c553-ceb5-400d-aa9b-47e8bd0a6b7a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3cc057f7-d687-42cf-87b6-0306cb2a448a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5affd64e-61a2-4021-b05b-94c28816960a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("60e8b376-c349-4052-810a-1477fdd4858a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("74f3cc09-9374-4ade-9b3b-7df113ce5f8b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("80186c02-54cb-4326-b58b-9d3e95a03080"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("877dbc08-2212-427b-91e4-ad255674bd53"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c35304b5-1f3b-478a-9c36-90ba051ebd1e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d3d335a1-6fc4-463e-90d1-eb3fa4265d3b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fb355789-0dde-4385-a67d-445ec79d2b61"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("16136966-f7c6-4242-bc68-ece79534dfb5"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("3b677561-5552-4d0c-aac1-1ef289aedbb7"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6bfb2234-00b6-4e6c-bf2c-5a35f49dcb98"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("a27d7ffe-561a-421f-9a2a-3a3ec298cc86"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("f51000ee-d74d-45b7-a213-3c75a11ccd2c"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("45dd03eb-e734-42f8-8cfa-dfcb67344703"), "", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("8b581e7a-2882-49fe-a9cc-c93aab4ebc8c"), "", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("a63383e1-9bb6-4632-beee-60559aef2699"), "", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("c8e1fed3-d079-47de-be1c-f908d33e31cb"), "", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("f4034595-4e4a-4e51-acc7-dabced2cd9f3"), "", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("0e3972ca-418d-4dc9-a00d-e178580c1bf6"), "", "France" },
                    { new Guid("76cbb285-39ff-447d-846c-15987213dd83"), "", "United Kingdom" },
                    { new Guid("9061cde2-00a6-4c6e-a9db-7d72c2df06af"), "", "United States" },
                    { new Guid("e865c860-c367-4474-be80-095f0a46d0a0"), "", "China" },
                    { new Guid("ea80a74a-860c-4376-862f-141fe3933090"), "", "India" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("28367338-1723-4ec7-8cd6-c4e99a96ed75"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.", "", "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)", "Christopher", "Nolan" },
                    { new Guid("29091183-6759-42dd-8e58-a1ee1f6ba158"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic American filmmaker widely regarded as one of the greatest and most influential directors in cinematic history. Known for his meticulous attention to detail, innovative techniques, and ability to master various genres, Kubrick's films are celebrated for their depth, visual artistry, and thematic complexity.", "", "The Shining(1980), Lolita(1962), Eyes Wide Shut(1957)", "Stanley", "Kubrick" },
                    { new Guid("3b0cdb8f-68f4-42d6-93e3-1da0a9600687"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.", "", "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)", "Rajkumar", "Hirani" },
                    { new Guid("47357c66-faf1-41dd-86cb-9e6c749cd3e6"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.", "", "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)", "Andrei", "Tarkovsky" },
                    { new Guid("88ecffab-35f2-40f2-b113-7a4017acf62a"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.", "", "The Mist(2007), The Salton Sea(2002), The Majestic(2001)", "Frank", "Darabont" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("09d8c553-ceb5-400d-aa9b-47e8bd0a6b7a"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("3cc057f7-d687-42cf-87b6-0306cb2a448a"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("5affd64e-61a2-4021-b05b-94c28816960a"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://www.themoviedb.org/t/p/original/7C92Q8tV43I1qZ8otPL9C9FpP4S.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("60e8b376-c349-4052-810a-1477fdd4858a"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("74f3cc09-9374-4ade-9b3b-7df113ce5f8b"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("80186c02-54cb-4326-b58b-9d3e95a03080"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRId646Gjwh5D086Kx2uqQOcf4FNwCErx2eJQm41oU4Z2DOVGP7-E1oHLjdwTcVbsDJ41A&usqp=CAU.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("877dbc08-2212-427b-91e4-ad255674bd53"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://www.themoviedb.org/t/p/original/wVYREutTvI2tmxr6ujrHT704wGF.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("c35304b5-1f3b-478a-9c36-90ba051ebd1e"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("d3d335a1-6fc4-463e-90d1-eb3fa4265d3b"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("fb355789-0dde-4385-a67d-445ec79d2b61"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://www.themoviedb.org/t/p/original/9fgh3Ns1iRzlQNYuJyK0ARQZU7w.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("16136966-f7c6-4242-bc68-ece79534dfb5"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("3b677561-5552-4d0c-aac1-1ef289aedbb7"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("6bfb2234-00b6-4e6c-bf2c-5a35f49dcb98"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("a27d7ffe-561a-421f-9a2a-3a3ec298cc86"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("f51000ee-d74d-45b7-a213-3c75a11ccd2c"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" }
                });
        }
    }
}
