using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedImagesToCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("2aa39ae4-849f-4338-ad2b-bf591f24a2ca"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("52f75f66-39c0-4171-883f-98c9bafd5792"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("56889ba9-e33b-49c2-8457-c0c190f76266"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("6eb6f95d-74fa-4a08-85bd-4a342b0d282e"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("e295af18-3877-4837-bab8-f43b3b7f83e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0cc10192-9fba-4a37-af5e-2034634766fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87b5e6c5-5f93-4aa5-a613-9a9226b3b63f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be1f55c1-8886-427b-a4de-480c63b433aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf91fd6d-2e75-4f9a-b5bf-e13670cb9bbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db151ed4-f688-4089-879b-7ed7dcbcb829"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("808efbf4-5993-43d1-8dc5-5af003f99fed"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("91f7ba90-fd5e-4fc1-ad71-0ced8eefbe21"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("9aa4b2ab-4df8-4561-b2ac-2962970a9ae9"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b4fe212c-fbea-456c-b7dc-24d1179ed66f"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d089d11e-0ff9-4add-83da-f5df0a8e8005"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("10caaafe-1573-499c-a68d-024c0de85178"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1a8f806e-5f2e-4591-a587-0651533b5f69"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2b284214-c5d0-479d-88a6-1b73c154e4a1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2c8ed701-32c4-4035-958f-de211dcf349e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("30e98d0f-755c-4ee1-8488-86127b74b74d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("476e32ed-9066-4d20-a6d4-e5819bae802d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("63640412-f32c-4b58-9b38-507ec229a9c0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a64b27c3-2ddf-48de-ad6e-2d0650f1b069"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d26845b9-fb25-4677-a3ed-27ed13b790ba"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ef09e922-fd09-417f-85ec-a52790ba1995"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("101b0505-2ac6-4e0a-9072-645e1890f874"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("20a1956d-c15a-4633-8221-49d7650529d1"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("c4c0a8ad-5fc2-4b42-9757-0ddfa02db58f"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("cfba8984-cf1c-4477-8928-5c88e3e5cf5a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("fc23435c-eb4a-4353-8ef9-9aa66dc97107"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("077663a9-c1e8-4463-a9ae-b6e55e805b7a"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("0cc0e0b7-f3fb-453c-bb4a-28ee87c7e42d"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("9fab841c-9dfa-42cb-bf0d-1ceb5d938f40"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("b9f4b6ea-c3d9-473b-9f48-0f55948996cb"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("de62021a-df17-479b-ae13-b9e5d2eab518"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("568d9c5f-7829-4a3b-ab90-3f52635fab60"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("af86079a-7a5e-49f8-aefb-934dbc11e468"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" },
                    { new Guid("b6e19b88-19d7-42b0-9f94-ffe8a3ea22d6"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" },
                    { new Guid("c08238f5-6302-4077-9a2a-380eed97979f"), "", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("f4e054d7-352c-4a0d-9d2b-ea38e764069e"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("2a4d805c-726d-4886-8398-6f83be1d0aa5"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)", "Rajkumar", "Hirani" },
                    { new Guid("4b991026-e154-4b12-bdc9-c0fcc55ed6ed"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)", "Andrei", "Tarkovsky" },
                    { new Guid("7d50760d-4eab-4b92-9f5a-5388de6392db"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist(2007), The Salton Sea(2002), The Majestic(2001)", "Frank", "Darabont" },
                    { new Guid("cefd58a2-cd50-4a02-bf04-bcbe87383173"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)", "Christopher", "Nolan" },
                    { new Guid("fcd78225-d08f-4450-bf72-b8188bfb9c7b"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic American filmmaker widely regarded as one of the greatest and most influential directors in cinematic history. Known for his meticulous attention to detail, innovative techniques, and ability to master various genres, Kubrick's films are celebrated for their depth, visual artistry, and thematic complexity.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining(1980), Lolita(1962), Eyes Wide Shut(1957)", "Stanley", "Kubrick" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("01a5b252-73fe-47f8-9ef7-0e830bafec55"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("1b743313-bbb7-49ca-9f52-05cebcb81bcb"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("2a28a37a-9afe-421d-ba45-a2fa75c51f3a"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("40c4582f-0c95-44a5-b620-f14051311ac8"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("7a25daa1-2eea-4b05-b2e7-31dce6d25bd6"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("99b26a9c-14ca-471c-83fd-ec5f805227a3"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("a41bd8bd-c19b-4202-8714-30888624bc78"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("aa713e6e-05fd-49dd-9fcf-8b639f7e340e"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("b05a8a7c-a65e-42ae-ac4b-e731d85f5fcd"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("ffe50d06-d950-409c-9640-ecc14bd8d370"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("370c69af-28b7-40cc-a330-71ff146f42e1"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("80d853e5-4535-491f-b6d2-de4e3acf2dfe"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("85addff6-8755-4f59-a9f4-c309511fb8db"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("d1cb19d8-06e3-4317-ac5e-d8826b9c3769"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("e17572d3-770b-4bfa-b3d8-cf91bb00d2df"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("077663a9-c1e8-4463-a9ae-b6e55e805b7a"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("0cc0e0b7-f3fb-453c-bb4a-28ee87c7e42d"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("9fab841c-9dfa-42cb-bf0d-1ceb5d938f40"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b9f4b6ea-c3d9-473b-9f48-0f55948996cb"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("de62021a-df17-479b-ae13-b9e5d2eab518"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("568d9c5f-7829-4a3b-ab90-3f52635fab60"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af86079a-7a5e-49f8-aefb-934dbc11e468"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6e19b88-19d7-42b0-9f94-ffe8a3ea22d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08238f5-6302-4077-9a2a-380eed97979f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4e054d7-352c-4a0d-9d2b-ea38e764069e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2a4d805c-726d-4886-8398-6f83be1d0aa5"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("4b991026-e154-4b12-bdc9-c0fcc55ed6ed"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("7d50760d-4eab-4b92-9f5a-5388de6392db"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("cefd58a2-cd50-4a02-bf04-bcbe87383173"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("fcd78225-d08f-4450-bf72-b8188bfb9c7b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("01a5b252-73fe-47f8-9ef7-0e830bafec55"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1b743313-bbb7-49ca-9f52-05cebcb81bcb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2a28a37a-9afe-421d-ba45-a2fa75c51f3a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("40c4582f-0c95-44a5-b620-f14051311ac8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7a25daa1-2eea-4b05-b2e7-31dce6d25bd6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("99b26a9c-14ca-471c-83fd-ec5f805227a3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a41bd8bd-c19b-4202-8714-30888624bc78"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aa713e6e-05fd-49dd-9fcf-8b639f7e340e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b05a8a7c-a65e-42ae-ac4b-e731d85f5fcd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ffe50d06-d950-409c-9640-ecc14bd8d370"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("370c69af-28b7-40cc-a330-71ff146f42e1"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("80d853e5-4535-491f-b6d2-de4e3acf2dfe"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("85addff6-8755-4f59-a9f4-c309511fb8db"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("d1cb19d8-06e3-4317-ac5e-d8826b9c3769"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("e17572d3-770b-4bfa-b3d8-cf91bb00d2df"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("2aa39ae4-849f-4338-ad2b-bf591f24a2ca"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("52f75f66-39c0-4171-883f-98c9bafd5792"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("56889ba9-e33b-49c2-8457-c0c190f76266"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("6eb6f95d-74fa-4a08-85bd-4a342b0d282e"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("e295af18-3877-4837-bab8-f43b3b7f83e7"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0cc10192-9fba-4a37-af5e-2034634766fd"), "", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("87b5e6c5-5f93-4aa5-a613-9a9226b3b63f"), "", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("be1f55c1-8886-427b-a4de-480c63b433aa"), "", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" },
                    { new Guid("cf91fd6d-2e75-4f9a-b5bf-e13670cb9bbf"), "", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("db151ed4-f688-4089-879b-7ed7dcbcb829"), "", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("808efbf4-5993-43d1-8dc5-5af003f99fed"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)", "Christopher", "Nolan" },
                    { new Guid("91f7ba90-fd5e-4fc1-ad71-0ced8eefbe21"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)", "Rajkumar", "Hirani" },
                    { new Guid("9aa4b2ab-4df8-4561-b2ac-2962970a9ae9"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)", "Andrei", "Tarkovsky" },
                    { new Guid("b4fe212c-fbea-456c-b7dc-24d1179ed66f"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist(2007), The Salton Sea(2002), The Majestic(2001)", "Frank", "Darabont" },
                    { new Guid("d089d11e-0ff9-4add-83da-f5df0a8e8005"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic American filmmaker widely regarded as one of the greatest and most influential directors in cinematic history. Known for his meticulous attention to detail, innovative techniques, and ability to master various genres, Kubrick's films are celebrated for their depth, visual artistry, and thematic complexity.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining(1980), Lolita(1962), Eyes Wide Shut(1957)", "Stanley", "Kubrick" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("10caaafe-1573-499c-a68d-024c0de85178"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("1a8f806e-5f2e-4591-a587-0651533b5f69"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("2b284214-c5d0-479d-88a6-1b73c154e4a1"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("2c8ed701-32c4-4035-958f-de211dcf349e"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("30e98d0f-755c-4ee1-8488-86127b74b74d"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("476e32ed-9066-4d20-a6d4-e5819bae802d"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("63640412-f32c-4b58-9b38-507ec229a9c0"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("a64b27c3-2ddf-48de-ad6e-2d0650f1b069"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("d26845b9-fb25-4677-a3ed-27ed13b790ba"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("ef09e922-fd09-417f-85ec-a52790ba1995"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("101b0505-2ac6-4e0a-9072-645e1890f874"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("20a1956d-c15a-4633-8221-49d7650529d1"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("c4c0a8ad-5fc2-4b42-9757-0ddfa02db58f"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("cfba8984-cf1c-4477-8928-5c88e3e5cf5a"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("fc23435c-eb4a-4353-8ef9-9aa66dc97107"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" }
                });
        }
    }
}
