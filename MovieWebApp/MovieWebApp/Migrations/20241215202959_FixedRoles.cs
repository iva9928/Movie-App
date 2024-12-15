using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class FixedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("5e5bf608-8962-4299-83a0-49f702181465"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("6e192e52-5b77-4bfd-ad1c-54e3f6c2fbc6"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("83d2c085-8ed1-46ee-bf19-d5c71ffb7a09"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("9b1441f3-aec3-4846-b512-db38a0cf542b"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b852442f-734d-4da9-9531-ba88cb85821f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ee2564a-6550-47c2-a239-03404549d0cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a61826dd-696b-4aa9-affc-082502165b3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e03c4d2b-0356-4ac6-a101-8796b1b76302"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e514030f-2cb2-42e9-81b9-15b24e4c9d91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa4490ee-e937-4ee7-94d6-ad4a52ca2057"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2f521184-2e87-445e-95f1-1f2b9c5d84b0"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("4938ea2a-0157-4bd8-882a-6745fca3bd84"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("5d858aa4-4fa2-44ef-befd-d65939eda58b"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("67dc4090-a8a0-4dcf-b897-0dd9e80075e9"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("c0094a03-0dd6-475c-b867-7d5fda1acaed"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("08e303d6-55b0-4a12-9754-c7c76bc6692f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1aaab236-a17f-4058-b8bb-4ced44736777"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("41db85d3-f87e-473a-a28f-69b36ffe94c2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("778809e3-8d20-4150-8ef6-423a870d6975"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7c595b5e-99d1-433a-9bf1-8342b50c6eca"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a9f55139-c0f1-4690-ab6c-cec6e5b6feba"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("af1b9979-de82-4754-92e3-981478b511a9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b9f23f44-65d7-42ab-b4b3-0ec183397151"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cf2ce6a6-a267-4b3e-bda0-33f6c87c4ea7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dbca1427-70c6-4908-9639-57283dfc7690"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("33c8eec1-1b96-4484-8e24-34172393ac47"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("36c02b3d-d5f9-452f-baf1-be0044314ca1"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("7ea8c83a-baf8-4bd2-8f65-d5048302ba04"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("aef62a2b-2ed2-4e53-846f-773692734166"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("f0f43e5b-05f1-4954-bf3e-9258d5310775"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("04e70663-91f4-4f50-abac-c0577700fe0c"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("0c6dcdcd-f094-4379-a47d-d9c2e6066ee7"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("1598ecea-e220-4508-8c97-f868792aa4c8"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("1d80c362-262b-4fe1-9204-e1d596940ec9"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("3172aa2d-0b63-49f0-8306-83b482f603dd"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("9570fb48-9a79-4186-ad9a-c1d3b429d4b3"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("dcc12c3e-6bd0-4b81-ae33-e5f6b4cc65d9"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("e70dbb34-03a6-4e16-a180-32d7920ef93d"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("f3a290f5-f2c3-4033-ad1d-f542ba0120fa"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("f712fe54-75e7-40f4-bc1a-4e69e35ec605"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("3182c2b1-9931-4ab6-9f98-5d3826e2e496"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("35ade5a8-c1cc-4952-a252-8b0410efa01a"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("3fa8e7c6-ac10-406c-972b-3b63004dc7be"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("64b45479-9af6-4a1c-b97d-76c61ad03f97"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("9c820578-2183-4adb-be73-3001fccf848c"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6abe811d-e3e1-43e5-9b41-7a51105155c3"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("8e059903-757a-408c-9a06-9d5421c2050e"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" },
                    { new Guid("a45e32aa-021d-4975-b246-5a039f17fba5"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("e028d7a4-4fa4-4ee3-b926-046c340563c1"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("fa4111b3-bae8-4308-a3a8-19066c57dabc"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("2fa6a099-3e13-4ad4-b048-ba19e3c81d04"), "Frank Darabont is known for his mastery in adapting emotionally resonant films from Stephen King's works.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)", "Frank", "Darabont" },
                    { new Guid("9a0bd992-5db6-442f-9058-8f7dc64a3dc8"), "Andrei Tarkovsky was a legendary Soviet filmmaker known for his poetic and visually stunning films.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)", "Andrei", "Tarkovsky" },
                    { new Guid("a1242fa5-ddb9-403a-9ffe-25511baed6bf"), "Rajkumar Hirani is a renowned Indian filmmaker celebrated for his ability to blend humor and emotion.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)", "Rajkumar", "Hirani" },
                    { new Guid("cd61f06f-78b6-4dfc-a21a-dc28f615c7dd"), "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)", "Christopher", "Nolan" },
                    { new Guid("f757f4e4-efd9-40dd-9886-b37f59212757"), "Stanley Kubrick was an iconic filmmaker celebrated for his innovative techniques and cinematic mastery.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)", "Stanley", "Kubrick" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1f8b2889-271e-4494-aea9-c841f2cd1624"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("4562be8b-81be-4b76-baf4-6745b49f6dbf"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("5ac27c8b-c0d8-4c7d-af80-3b7ef1091df9"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("6a25faff-ab27-434e-839a-3f40e73b7ad4"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("6a7dc1b3-0f39-41a2-90a5-2b865c0e40e8"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("8745253a-77f9-4166-bc2b-dd95221114e5"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("99fc1ee7-f84b-416c-a40f-bb52d2bc81b7"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("a58d3f7f-71b7-4f07-a48e-42a131acb997"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("a8f0231a-3f36-4c9f-88bb-4037ec7f1966"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("dd1b55b1-639f-4dd9-bd35-6a8c5531daaa"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterImageUrl", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("2c96d396-830e-48da-96fa-32069ff5d17e"), "https://i.pinimg.com/originals/a9/74/12/a97412747c6d13646367d5e5912cee4c.jpg", "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("306398f8-f6c0-4d4f-b93e-ad9f64e2fded"), "https://upload.wikimedia.org/wikipedia/en/9/94/Forest_Gump_Character.jpg", "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("5100babc-77b7-4182-b716-6c84d14c804b"), "https://i.pinimg.com/736x/1a/2b/b5/1a2bb5bcb59578199ee35f7f03c97876.jpg", "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("9bd3fac1-0b29-43bd-898d-46a042e02627"), "https://upload.wikimedia.org/wikipedia/en/5/50/Tyrion_Lannister-Peter_Dinklage.jpg", "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("c9aae8f1-ff44-4e2f-aa07-a02d14c1bfe5"), "https://upload.wikimedia.org/wikipedia/en/9/9b/Yoda_Empire_Strikes_Back.png", "Yoda", "“Do, or do not. There is no try.”", "Star Wars" }
                });

            migrationBuilder.InsertData(
                table: "TVShows",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "Production", "ReleaseDate", "TVSeriesImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("26f4b01e-af42-495d-95d9-5ad9cd7f8467"), "Wentworth Miller, Dominic Purcell, Sarah Wayne Callies, Paul Adelstein, Rockmond Dunbar", "United States of America", "Due to a political warfare, an innocent man has been sent to death row and his only hope is his own brother, who makes it his obligation to deliberately get himself shipped to the identical prison as a way to break both of them out, from the inside out.", 45, "Action & Adventure, Crime, Drama", "Prison Break Productions, Adelstein-Parouse Productions, Original Television, 20th Century Fox Television", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/90/35/9035e9fd6129b4d5bbecd6a8351269cc/9035e9fd6129b4d5bbecd6a8351269cc.jpg", "Prison Break" },
                    { new Guid("2cfab3e0-0b12-4e92-b53e-b6c0605f997d"), "Cillian Murphy, Paul Anderson, Helen McCrory, Sophie Rundle, Joe Cole", "United Kingdom", "A gangster family epic set in England, 1919 Birmingham and predicated on their boss Tommy Shelby, who means to maneuver on earth, along with a gang that sew razor blades from the peaks of their caps.", 60, "Drama, Crime", "Tiger Aspect Productions, BBC Studios, Caryn Mandabach Productions, Screen Yorkshire", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/ea/b4/eab48fa4c71804c00008616715dd3777/eab48fa4c71804c00008616715dd3777.jpg", "Peaky Blinders" },
                    { new Guid("629d0fac-b84f-4db1-8688-17f2921b4686"), "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris, Betsy Brandt", " United States of America", "When a New Mexico chemistry educator, Walter White, has been diagnosed with Stage III cancer and given a prognosis of two years ago to live. He's filled to secure his family's financial future at any cost since he enters the dangerous environment of crime and drugs.", 45, "Drama", "Sony Pictures Television, High Bridge Entertainment, Gran Via Productions", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/7a/78/7a78d2a44e33d64d6c35e1a2c1e2cdc9/7a78d2a44e33d64d6c35e1a2c1e2cdc9.jpg", "Breaking Bad" },
                    { new Guid("766e41bf-316a-4489-a6b5-67cc2a96dc2e"), "Paul Wesley, Ian Somerhalder, Nina Dobrev, Kat Graham, Candice King", "United States of America", "The story of two brothers obsessed with the same girl, that bears a striking resemblance to the beautiful but ruthless vampire they knew and adored from 1864.", 45, "Drama, Fantasy, Horror, Romance", "Warner Bros. Television, Alloy Entertainment, Outerbanks Entertainment, Bonanza Productions, CBS Television Studios", new DateTime(2009, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/9a/2e/9a2e3494b96d12dcaded262e7a5ef061/9a2e3494b96d12dcaded262e7a5ef061.jpg", "The Vampire Diaries" },
                    { new Guid("815d19ee-ccef-4b65-a9bc-deaf45641f6d"), "Blake Lively, Leighton Meester, Penn Badgley, Chace Crawford, Ed Westwick", "United States of America", "A private group of privileged teens out of the prep school on Manhattan's Upper East Side whose lives revolve round the allknowing albeit ultra-secretive Gossip Girl's site.", 45, "Comedy", " Warner Bros. Television, Alloy Entertainment, Fake Empire Productions, CBS Television Studios", new DateTime(2008, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/3c/f4/3cf4de4ae0c57a86347943b8f75ef0e5/3cf4de4ae0c57a86347943b8f75ef0e5.jpg", "Gossip Girl" },
                    { new Guid("a0cd9419-2ffd-4231-8c2f-6adc2795d304"), "Blake Lively, Leighton Meester, Penn Badgley, Chace Crawford, Ed Westwick", "United States of America", "A private group of privileged teens out of the prep school on Manhattan's Upper East Side whose lives revolve round the allknowing albeit ultra-secretive Gossip Girl's site.", 45, "Comedy", " Warner Bros. Television, Alloy Entertainment, Fake Empire Productions, CBS Television Studios", new DateTime(2008, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/3c/f4/3cf4de4ae0c57a86347943b8f75ef0e5/3cf4de4ae0c57a86347943b8f75ef0e5.jpg", "Gossip Girl" },
                    { new Guid("c062f23d-d280-454a-90c0-45680d3ddc39"), "Cillian Murphy, Paul Anderson, Helen McCrory, Sophie Rundle, Joe Cole", "United Kingdom", "A gangster family epic set in England, 1919 Birmingham and predicated on their boss Tommy Shelby, who means to maneuver on earth, along with a gang that sew razor blades from the peaks of their caps.", 60, "Drama, Crime", "Tiger Aspect Productions, BBC Studios, Caryn Mandabach Productions, Screen Yorkshire", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/ea/b4/eab48fa4c71804c00008616715dd3777/eab48fa4c71804c00008616715dd3777.jpg", "Peaky Blinders" },
                    { new Guid("dae87f75-7c1a-450d-a430-f0566594b460"), "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris, Betsy Brandt", " United States of America", "When a New Mexico chemistry educator, Walter White, has been diagnosed with Stage III cancer and given a prognosis of two years ago to live. He's filled to secure his family's financial future at any cost since he enters the dangerous environment of crime and drugs.", 45, "Drama", "Sony Pictures Television, High Bridge Entertainment, Gran Via Productions", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/7a/78/7a78d2a44e33d64d6c35e1a2c1e2cdc9/7a78d2a44e33d64d6c35e1a2c1e2cdc9.jpg", "Breaking Bad" },
                    { new Guid("ea7a0c85-7ca0-423f-b0d0-e93ddd23535b"), "Wentworth Miller, Dominic Purcell, Sarah Wayne Callies, Paul Adelstein, Rockmond Dunbar", "United States of America", "Due to a political warfare, an innocent man has been sent to death row and his only hope is his own brother, who makes it his obligation to deliberately get himself shipped to the identical prison as a way to break both of them out, from the inside out.", 45, "Action & Adventure, Crime, Drama", "Prison Break Productions, Adelstein-Parouse Productions, Original Television, 20th Century Fox Television", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/90/35/9035e9fd6129b4d5bbecd6a8351269cc/9035e9fd6129b4d5bbecd6a8351269cc.jpg", "Prison Break" },
                    { new Guid("f6e72649-0f62-48f1-930a-8eb6fbba6fff"), "Paul Wesley, Ian Somerhalder, Nina Dobrev, Kat Graham, Candice King", "United States of America", "The story of two brothers obsessed with the same girl, that bears a striking resemblance to the beautiful but ruthless vampire they knew and adored from 1864.", 45, "Drama, Fantasy, Horror, Romance", "Warner Bros. Television, Alloy Entertainment, Outerbanks Entertainment, Bonanza Productions, CBS Television Studios", new DateTime(2009, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/9a/2e/9a2e3494b96d12dcaded262e7a5ef061/9a2e3494b96d12dcaded262e7a5ef061.jpg", "The Vampire Diaries" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("3182c2b1-9931-4ab6-9f98-5d3826e2e496"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("35ade5a8-c1cc-4952-a252-8b0410efa01a"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("3fa8e7c6-ac10-406c-972b-3b63004dc7be"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("64b45479-9af6-4a1c-b97d-76c61ad03f97"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("9c820578-2183-4adb-be73-3001fccf848c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6abe811d-e3e1-43e5-9b41-7a51105155c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e059903-757a-408c-9a06-9d5421c2050e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a45e32aa-021d-4975-b246-5a039f17fba5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e028d7a4-4fa4-4ee3-b926-046c340563c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa4111b3-bae8-4308-a3a8-19066c57dabc"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2fa6a099-3e13-4ad4-b048-ba19e3c81d04"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("9a0bd992-5db6-442f-9058-8f7dc64a3dc8"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("a1242fa5-ddb9-403a-9ffe-25511baed6bf"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("cd61f06f-78b6-4dfc-a21a-dc28f615c7dd"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("f757f4e4-efd9-40dd-9886-b37f59212757"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1f8b2889-271e-4494-aea9-c841f2cd1624"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4562be8b-81be-4b76-baf4-6745b49f6dbf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5ac27c8b-c0d8-4c7d-af80-3b7ef1091df9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6a25faff-ab27-434e-839a-3f40e73b7ad4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6a7dc1b3-0f39-41a2-90a5-2b865c0e40e8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8745253a-77f9-4166-bc2b-dd95221114e5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("99fc1ee7-f84b-416c-a40f-bb52d2bc81b7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a58d3f7f-71b7-4f07-a48e-42a131acb997"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a8f0231a-3f36-4c9f-88bb-4037ec7f1966"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dd1b55b1-639f-4dd9-bd35-6a8c5531daaa"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("2c96d396-830e-48da-96fa-32069ff5d17e"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("306398f8-f6c0-4d4f-b93e-ad9f64e2fded"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("5100babc-77b7-4182-b716-6c84d14c804b"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("9bd3fac1-0b29-43bd-898d-46a042e02627"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("c9aae8f1-ff44-4e2f-aa07-a02d14c1bfe5"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("26f4b01e-af42-495d-95d9-5ad9cd7f8467"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("2cfab3e0-0b12-4e92-b53e-b6c0605f997d"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("629d0fac-b84f-4db1-8688-17f2921b4686"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("766e41bf-316a-4489-a6b5-67cc2a96dc2e"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("815d19ee-ccef-4b65-a9bc-deaf45641f6d"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("a0cd9419-2ffd-4231-8c2f-6adc2795d304"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("c062f23d-d280-454a-90c0-45680d3ddc39"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("dae87f75-7c1a-450d-a430-f0566594b460"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("ea7a0c85-7ca0-423f-b0d0-e93ddd23535b"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("f6e72649-0f62-48f1-930a-8eb6fbba6fff"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("5e5bf608-8962-4299-83a0-49f702181465"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("6e192e52-5b77-4bfd-ad1c-54e3f6c2fbc6"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("83d2c085-8ed1-46ee-bf19-d5c71ffb7a09"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("9b1441f3-aec3-4846-b512-db38a0cf542b"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("b852442f-734d-4da9-9531-ba88cb85821f"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5ee2564a-6550-47c2-a239-03404549d0cc"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("a61826dd-696b-4aa9-affc-082502165b3b"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("e03c4d2b-0356-4ac6-a101-8796b1b76302"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("e514030f-2cb2-42e9-81b9-15b24e4c9d91"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" },
                    { new Guid("fa4490ee-e937-4ee7-94d6-ad4a52ca2057"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("2f521184-2e87-445e-95f1-1f2b9c5d84b0"), "Frank Darabont is known for his mastery in adapting emotionally resonant films from Stephen King's works.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)", "Frank", "Darabont" },
                    { new Guid("4938ea2a-0157-4bd8-882a-6745fca3bd84"), "Rajkumar Hirani is a renowned Indian filmmaker celebrated for his ability to blend humor and emotion.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)", "Rajkumar", "Hirani" },
                    { new Guid("5d858aa4-4fa2-44ef-befd-d65939eda58b"), "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)", "Christopher", "Nolan" },
                    { new Guid("67dc4090-a8a0-4dcf-b897-0dd9e80075e9"), "Stanley Kubrick was an iconic filmmaker celebrated for his innovative techniques and cinematic mastery.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)", "Stanley", "Kubrick" },
                    { new Guid("c0094a03-0dd6-475c-b867-7d5fda1acaed"), "Andrei Tarkovsky was a legendary Soviet filmmaker known for his poetic and visually stunning films.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)", "Andrei", "Tarkovsky" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("08e303d6-55b0-4a12-9754-c7c76bc6692f"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("1aaab236-a17f-4058-b8bb-4ced44736777"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("41db85d3-f87e-473a-a28f-69b36ffe94c2"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("778809e3-8d20-4150-8ef6-423a870d6975"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("7c595b5e-99d1-433a-9bf1-8342b50c6eca"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("a9f55139-c0f1-4690-ab6c-cec6e5b6feba"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("af1b9979-de82-4754-92e3-981478b511a9"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("b9f23f44-65d7-42ab-b4b3-0ec183397151"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("cf2ce6a6-a267-4b3e-bda0-33f6c87c4ea7"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("dbca1427-70c6-4908-9639-57283dfc7690"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterImageUrl", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("33c8eec1-1b96-4484-8e24-34172393ac47"), "https://i.pinimg.com/originals/a9/74/12/a97412747c6d13646367d5e5912cee4c.jpg", "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("36c02b3d-d5f9-452f-baf1-be0044314ca1"), "https://upload.wikimedia.org/wikipedia/en/5/50/Tyrion_Lannister-Peter_Dinklage.jpg", "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("7ea8c83a-baf8-4bd2-8f65-d5048302ba04"), "https://i.pinimg.com/736x/1a/2b/b5/1a2bb5bcb59578199ee35f7f03c97876.jpg", "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("aef62a2b-2ed2-4e53-846f-773692734166"), "https://upload.wikimedia.org/wikipedia/en/9/94/Forest_Gump_Character.jpg", "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("f0f43e5b-05f1-4954-bf3e-9258d5310775"), "https://upload.wikimedia.org/wikipedia/en/9/9b/Yoda_Empire_Strikes_Back.png", "Yoda", "“Do, or do not. There is no try.”", "Star Wars" }
                });

            migrationBuilder.InsertData(
                table: "TVShows",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "Production", "ReleaseDate", "TVSeriesImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("04e70663-91f4-4f50-abac-c0577700fe0c"), "Paul Wesley, Ian Somerhalder, Nina Dobrev, Kat Graham, Candice King", "United States of America", "The story of two brothers obsessed with the same girl, that bears a striking resemblance to the beautiful but ruthless vampire they knew and adored from 1864.", 45, "Drama, Fantasy, Horror, Romance", "Warner Bros. Television, Alloy Entertainment, Outerbanks Entertainment, Bonanza Productions, CBS Television Studios", new DateTime(2009, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/9a/2e/9a2e3494b96d12dcaded262e7a5ef061/9a2e3494b96d12dcaded262e7a5ef061.jpg", "The Vampire Diaries" },
                    { new Guid("0c6dcdcd-f094-4379-a47d-d9c2e6066ee7"), "Blake Lively, Leighton Meester, Penn Badgley, Chace Crawford, Ed Westwick", "United States of America", "A private group of privileged teens out of the prep school on Manhattan's Upper East Side whose lives revolve round the allknowing albeit ultra-secretive Gossip Girl's site.", 45, "Comedy", " Warner Bros. Television, Alloy Entertainment, Fake Empire Productions, CBS Television Studios", new DateTime(2008, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/3c/f4/3cf4de4ae0c57a86347943b8f75ef0e5/3cf4de4ae0c57a86347943b8f75ef0e5.jpg", "Gossip Girl" },
                    { new Guid("1598ecea-e220-4508-8c97-f868792aa4c8"), "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris, Betsy Brandt", " United States of America", "When a New Mexico chemistry educator, Walter White, has been diagnosed with Stage III cancer and given a prognosis of two years ago to live. He's filled to secure his family's financial future at any cost since he enters the dangerous environment of crime and drugs.", 45, "Drama", "Sony Pictures Television, High Bridge Entertainment, Gran Via Productions", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/7a/78/7a78d2a44e33d64d6c35e1a2c1e2cdc9/7a78d2a44e33d64d6c35e1a2c1e2cdc9.jpg", "Breaking Bad" },
                    { new Guid("1d80c362-262b-4fe1-9204-e1d596940ec9"), "Blake Lively, Leighton Meester, Penn Badgley, Chace Crawford, Ed Westwick", "United States of America", "A private group of privileged teens out of the prep school on Manhattan's Upper East Side whose lives revolve round the allknowing albeit ultra-secretive Gossip Girl's site.", 45, "Comedy", " Warner Bros. Television, Alloy Entertainment, Fake Empire Productions, CBS Television Studios", new DateTime(2008, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/3c/f4/3cf4de4ae0c57a86347943b8f75ef0e5/3cf4de4ae0c57a86347943b8f75ef0e5.jpg", "Gossip Girl" },
                    { new Guid("3172aa2d-0b63-49f0-8306-83b482f603dd"), "Wentworth Miller, Dominic Purcell, Sarah Wayne Callies, Paul Adelstein, Rockmond Dunbar", "United States of America", "Due to a political warfare, an innocent man has been sent to death row and his only hope is his own brother, who makes it his obligation to deliberately get himself shipped to the identical prison as a way to break both of them out, from the inside out.", 45, "Action & Adventure, Crime, Drama", "Prison Break Productions, Adelstein-Parouse Productions, Original Television, 20th Century Fox Television", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/90/35/9035e9fd6129b4d5bbecd6a8351269cc/9035e9fd6129b4d5bbecd6a8351269cc.jpg", "Prison Break" },
                    { new Guid("9570fb48-9a79-4186-ad9a-c1d3b429d4b3"), "Wentworth Miller, Dominic Purcell, Sarah Wayne Callies, Paul Adelstein, Rockmond Dunbar", "United States of America", "Due to a political warfare, an innocent man has been sent to death row and his only hope is his own brother, who makes it his obligation to deliberately get himself shipped to the identical prison as a way to break both of them out, from the inside out.", 45, "Action & Adventure, Crime, Drama", "Prison Break Productions, Adelstein-Parouse Productions, Original Television, 20th Century Fox Television", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/90/35/9035e9fd6129b4d5bbecd6a8351269cc/9035e9fd6129b4d5bbecd6a8351269cc.jpg", "Prison Break" },
                    { new Guid("dcc12c3e-6bd0-4b81-ae33-e5f6b4cc65d9"), "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris, Betsy Brandt", " United States of America", "When a New Mexico chemistry educator, Walter White, has been diagnosed with Stage III cancer and given a prognosis of two years ago to live. He's filled to secure his family's financial future at any cost since he enters the dangerous environment of crime and drugs.", 45, "Drama", "Sony Pictures Television, High Bridge Entertainment, Gran Via Productions", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/7a/78/7a78d2a44e33d64d6c35e1a2c1e2cdc9/7a78d2a44e33d64d6c35e1a2c1e2cdc9.jpg", "Breaking Bad" },
                    { new Guid("e70dbb34-03a6-4e16-a180-32d7920ef93d"), "Cillian Murphy, Paul Anderson, Helen McCrory, Sophie Rundle, Joe Cole", "United Kingdom", "A gangster family epic set in England, 1919 Birmingham and predicated on their boss Tommy Shelby, who means to maneuver on earth, along with a gang that sew razor blades from the peaks of their caps.", 60, "Drama, Crime", "Tiger Aspect Productions, BBC Studios, Caryn Mandabach Productions, Screen Yorkshire", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/ea/b4/eab48fa4c71804c00008616715dd3777/eab48fa4c71804c00008616715dd3777.jpg", "Peaky Blinders" },
                    { new Guid("f3a290f5-f2c3-4033-ad1d-f542ba0120fa"), "Cillian Murphy, Paul Anderson, Helen McCrory, Sophie Rundle, Joe Cole", "United Kingdom", "A gangster family epic set in England, 1919 Birmingham and predicated on their boss Tommy Shelby, who means to maneuver on earth, along with a gang that sew razor blades from the peaks of their caps.", 60, "Drama, Crime", "Tiger Aspect Productions, BBC Studios, Caryn Mandabach Productions, Screen Yorkshire", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/ea/b4/eab48fa4c71804c00008616715dd3777/eab48fa4c71804c00008616715dd3777.jpg", "Peaky Blinders" },
                    { new Guid("f712fe54-75e7-40f4-bc1a-4e69e35ec605"), "Paul Wesley, Ian Somerhalder, Nina Dobrev, Kat Graham, Candice King", "United States of America", "The story of two brothers obsessed with the same girl, that bears a striking resemblance to the beautiful but ruthless vampire they knew and adored from 1864.", 45, "Drama, Fantasy, Horror, Romance", "Warner Bros. Television, Alloy Entertainment, Outerbanks Entertainment, Bonanza Productions, CBS Television Studios", new DateTime(2009, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/9a/2e/9a2e3494b96d12dcaded262e7a5ef061/9a2e3494b96d12dcaded262e7a5ef061.jpg", "The Vampire Diaries" }
                });
        }
    }
}
