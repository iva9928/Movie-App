using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeededDirectorsAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("1ff2d348-6ec1-4456-aa6f-d2bc9eba5aca"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("30fb1434-0b38-4f9a-a11c-63315bd4539b"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("3f1b2701-e51f-4ed9-83a4-0376de9b8f0f"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("a5fd3a35-b34c-435e-924d-ef3cba77d829"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("af755af8-b94a-4112-ae18-90fe064a31dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29d2393c-3e07-44a1-9114-ce49af2bb79d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30d8f77b-d3c6-4138-a377-23e448f2238b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73018341-f7fc-4ed6-9b41-36585f1a7c0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d538cec6-ec2a-478d-bea3-3ba0b29bad8f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1ca2596-9f3a-4316-b751-07bed9b7b20e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("26bb8a9e-8c0d-452a-b727-6f6d9291b33d"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("5d2784b5-c9bc-42db-b671-bf60d736ada0"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("8aaaac61-e3c3-4acb-8bc9-b882eeb2bb46"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("acc6f941-478a-42bb-9375-8314080fec02"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("cd8bc78e-2d2a-4cab-9dd2-d6a97c1b3eab"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("28ea3d00-baae-4b52-8b10-c0f0fc719390"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5926096b-980f-45d8-8448-4cd4ef4e86d8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6603e544-698f-4243-ad49-572ecc1c2fcb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("66087c9a-764f-4f68-9bbf-2b5d40b764d8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6dfc79fa-78a0-4494-b969-836b253f1eaf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("89622411-c21c-4c21-925d-0b06133e63cf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("94308ebc-f58f-4187-813d-396dc3909b82"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("adec79bb-d1fe-4e63-bf9d-5e69aa989f80"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c09b2521-a0b4-4b3b-ae6c-2dcbf65a3e42"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c799641d-cea6-4d7e-b046-7d3ad911e7f5"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("31fd6c57-06ae-43e7-804e-812c2d806719"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("507fdf19-6dde-49e2-8f6b-b91c055fe02a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("af4969c3-bdfe-4000-b4fd-a747802b5c2a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("e035d81d-a4aa-4682-a096-5fe0d569af81"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("e9da8066-3f23-42b1-99ac-f65e97c1ced3"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("14c9e771-8185-438f-b37a-30d8152a22d4"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("3d58108c-8c62-4205-b4d8-ada797257e34"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("73ae7c32-9138-4c1d-93b4-61b732d3018f"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("780bb257-6994-47e2-bfac-48a457fa437a"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("b2d66f7b-ef00-45b5-957c-6ace68e3cfdb"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1de6d2dc-a5a4-495e-9b70-bb1484990d3f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("3a13e82b-aade-43c8-83e7-8362adf59cf4"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" },
                    { new Guid("4edb1afb-d240-42a9-b9e8-b0496a92445d"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("55ccb80b-1244-4a3a-9810-3201b29e00cd"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("885d9cfd-2c69-4c19-8e0c-d21c4c111013"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("06c51fd5-2afd-4c17-9c58-e18a50bc5859"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic filmmaker known for his innovative techniques and mastery across genres.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)", "Stanley", "Kubrick" },
                    { new Guid("28d94515-16c7-4ac7-aa51-93659332b722"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker celebrated for his ability to blend humor, emotion, and social commentary.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)", "Rajkumar", "Hirani" },
                    { new Guid("75f3542e-ee10-47f5-976b-fd85b1946ce8"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker known for adapting emotionally resonant films, particularly from Stephen King's works.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)", "Frank", "Darabont" },
                    { new Guid("91567c33-f58b-4945-8263-f193ffd722d9"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)", "Christopher", "Nolan" },
                    { new Guid("b38da92d-3d59-463a-90ff-aef709983d16"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker known for his poetic and visually stunning films.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)", "Andrei", "Tarkovsky" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0c1dbc5c-a32f-4b6a-99f8-c3e58bc70e18"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("176d24b4-2f28-485c-8b14-c0266654426b"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("1811297f-7fea-4cf0-97d7-ca07432ee2e9"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("6d3ec5d4-ba4a-43ea-bbb5-88637d8cfcbf"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("b1a45179-fce1-4f8f-bf6e-f7549f3b8b56"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("d0136325-e074-489c-87ed-f73abf33e92e"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("d6a588c5-7be2-4dfa-925a-f15482f7ab71"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("e3e8aa01-af94-4d00-8e26-208a2a45135a"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("e7b13c81-1a73-4361-9618-9732f0851174"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("fff8e0df-3ffb-4752-8729-04594daea58e"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("0cad0aa9-ffd7-4813-ad83-fd76c7325594"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("6390342f-3516-49ab-ada8-48f9e567cd32"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("6e925414-3c14-4b19-9c5f-2154c82e5e62"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("8f2a98c8-58f6-469d-a423-ebd470011101"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("e8e8d787-aa9c-4404-9861-27d87695f7cc"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("14c9e771-8185-438f-b37a-30d8152a22d4"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("3d58108c-8c62-4205-b4d8-ada797257e34"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("73ae7c32-9138-4c1d-93b4-61b732d3018f"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("780bb257-6994-47e2-bfac-48a457fa437a"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b2d66f7b-ef00-45b5-957c-6ace68e3cfdb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1de6d2dc-a5a4-495e-9b70-bb1484990d3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a13e82b-aade-43c8-83e7-8362adf59cf4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4edb1afb-d240-42a9-b9e8-b0496a92445d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55ccb80b-1244-4a3a-9810-3201b29e00cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("885d9cfd-2c69-4c19-8e0c-d21c4c111013"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("06c51fd5-2afd-4c17-9c58-e18a50bc5859"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("28d94515-16c7-4ac7-aa51-93659332b722"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("75f3542e-ee10-47f5-976b-fd85b1946ce8"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("91567c33-f58b-4945-8263-f193ffd722d9"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b38da92d-3d59-463a-90ff-aef709983d16"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0c1dbc5c-a32f-4b6a-99f8-c3e58bc70e18"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("176d24b4-2f28-485c-8b14-c0266654426b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1811297f-7fea-4cf0-97d7-ca07432ee2e9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6d3ec5d4-ba4a-43ea-bbb5-88637d8cfcbf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b1a45179-fce1-4f8f-bf6e-f7549f3b8b56"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d0136325-e074-489c-87ed-f73abf33e92e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d6a588c5-7be2-4dfa-925a-f15482f7ab71"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e3e8aa01-af94-4d00-8e26-208a2a45135a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e7b13c81-1a73-4361-9618-9732f0851174"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fff8e0df-3ffb-4752-8729-04594daea58e"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("0cad0aa9-ffd7-4813-ad83-fd76c7325594"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6390342f-3516-49ab-ada8-48f9e567cd32"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6e925414-3c14-4b19-9c5f-2154c82e5e62"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("8f2a98c8-58f6-469d-a423-ebd470011101"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("e8e8d787-aa9c-4404-9861-27d87695f7cc"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("1ff2d348-6ec1-4456-aa6f-d2bc9eba5aca"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("30fb1434-0b38-4f9a-a11c-63315bd4539b"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("3f1b2701-e51f-4ed9-83a4-0376de9b8f0f"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("a5fd3a35-b34c-435e-924d-ef3cba77d829"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("af755af8-b94a-4112-ae18-90fe064a31dc"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("29d2393c-3e07-44a1-9114-ce49af2bb79d"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" },
                    { new Guid("30d8f77b-d3c6-4138-a377-23e448f2238b"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("73018341-f7fc-4ed6-9b41-36585f1a7c0c"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("d538cec6-ec2a-478d-bea3-3ba0b29bad8f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("f1ca2596-9f3a-4316-b751-07bed9b7b20e"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("26bb8a9e-8c0d-452a-b727-6f6d9291b33d"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic American filmmaker widely regarded as one of the greatest and most influential directors in cinematic history. Known for his meticulous attention to detail, innovative techniques, and ability to master various genres, Kubrick's films are celebrated for their depth, visual artistry, and thematic complexity.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining(1980), Lolita(1962), Eyes Wide Shut(1957)", "Stanley", "Kubrick" },
                    { new Guid("5d2784b5-c9bc-42db-b671-bf60d736ada0"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker, widely regarded as one of the greatest directors in the history of cinema. Known for his poetic, philosophical, and visually stunning films, Tarkovsky's work often explored themes of spirituality, human existence, and the passage of time.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice(1986), Nostalghia(1983), Stalker(1979)", "Andrei", "Tarkovsky" },
                    { new Guid("8aaaac61-e3c3-4acb-8bc9-b882eeb2bb46"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker, screenwriter, and editor, celebrated for his ability to blend humor, emotion, and social commentary. His films are known for their universal appeal and strong storytelling, making him one of Bollywood's most successful and critically acclaimed directors.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki(2023), Dunki(2018), Irudhi Suttru(2016)", "Rajkumar", "Hirani" },
                    { new Guid("acc6f941-478a-42bb-9375-8314080fec02"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker, screenwriter, and producer known for his mastery in adapting emotionally resonant and visually stunning films, particularly from Stephen King's works. He is celebrated for his exploration of themes like hope, redemption, and humanity.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist(2007), The Salton Sea(2002), The Majestic(2001)", "Frank", "Darabont" },
                    { new Guid("cd8bc78e-2d2a-4cab-9dd2-d6a97c1b3eab"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery. Known for blending large-scale spectacle with intellectual depth, Nolan is one of the most influential and successful directors in modern cinema.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer(2023), Tenet(2020), Dunkirk(2017)", "Christopher", "Nolan" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("28ea3d00-baae-4b52-8b10-c0f0fc719390"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("5926096b-980f-45d8-8448-4cd4ef4e86d8"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("6603e544-698f-4243-ad49-572ecc1c2fcb"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("66087c9a-764f-4f68-9bbf-2b5d40b764d8"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("6dfc79fa-78a0-4494-b969-836b253f1eaf"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("89622411-c21c-4c21-925d-0b06133e63cf"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("94308ebc-f58f-4187-813d-396dc3909b82"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("adec79bb-d1fe-4e63-bf9d-5e69aa989f80"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("c09b2521-a0b4-4b3b-ae6c-2dcbf65a3e42"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("c799641d-cea6-4d7e-b046-7d3ad911e7f5"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("31fd6c57-06ae-43e7-804e-812c2d806719"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("507fdf19-6dde-49e2-8f6b-b91c055fe02a"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("af4969c3-bdfe-4000-b4fd-a747802b5c2a"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("e035d81d-a4aa-4682-a096-5fe0d569af81"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("e9da8066-3f23-42b1-99ac-f65e97c1ced3"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" }
                });
        }
    }
}
