using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeededDirector4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("6fb97c94-407e-4f2d-87aa-3374cfd8aa86"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("7caabdf8-3e3e-467f-a6ec-2536ecd974d8"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("85fb8611-6ec4-4f7b-bc2f-ee958c7caa12"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("a082cc32-c860-44ee-a538-380b0441c5dd"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b7771af3-23ef-4bd3-9316-f3d906b7c376"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd059468-7094-4933-8686-c96a7fe1af64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d183fd11-6e4f-4bea-8795-79b479e6dcf4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3a9f2b6-86d5-474e-b1f5-cd0617ff6e0e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df078226-92ab-4336-b928-0562a9ad56ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e69a6a92-05bc-43cb-b23b-21536b250c2e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("0f1a5321-cc6d-4eaf-ae57-ebcb41ce49d6"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("46a23ca5-cbe6-4fd2-8b3a-3409b3be6d19"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("46b852dc-b9d8-4f2e-a422-9d891e97920e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b9f76a01-f545-452f-8532-9662c7859c5d"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("bbc53dfd-df68-4d63-82e3-d0f320a94e13"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("47d3051b-c9a4-4bd5-8a02-4554add1a0d3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("49d08a34-4a7d-4a81-ad37-28dd0a6bcf60"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("68eea93c-ab23-48b0-bcd6-b56fb5878a43"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7c86acbb-40ff-43d9-aea7-af7955144b20"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("99f80b53-dd21-443b-b625-ade19d74678a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ba1a0b02-cd0a-4961-8d42-d940fb220a96"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d5165433-648b-431f-866f-65d1d681eec7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dad92977-3e9f-4496-a404-cf55f3ab77a3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e252724e-8955-4427-8765-4ec8f98dd3a0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eb2df1ed-4090-4c34-b10f-eec1148e6803"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("2310a54a-a66d-4869-98d0-f9c5db538cd8"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("2c6efb15-bfd8-4ae6-8e15-2ad56731e849"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("38133634-8b30-4e74-96ce-663e5c3908ed"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("5e7f6bb9-2625-4136-aea8-d41a9afdbedf"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("a845e762-7461-42b9-af77-b9079f74b92e"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("810e72c6-a40a-4850-af4f-94d34fd0e261"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("8734f6d3-2ab9-4024-966b-6c3b2fdc861d"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("950ef68b-c487-473e-bc6a-7ccd095fee57"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("a9480718-13e2-4bda-b135-60bdd1bb0718"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("b0465a2a-d031-4ae9-970c-15bb6d6c59bd"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("922e910f-2472-4815-8590-64ee267e9b69"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("c16a7dc3-bdca-4bd5-86be-6fd93c624d74"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("c40e5d48-0965-4622-b892-4e289116dacf"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" },
                    { new Guid("ed414e90-c459-4ce2-b766-993b70d24a19"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("fe53304d-7d20-4985-b89c-8342d60f61fd"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("4d811966-5bcd-44dc-aec0-b25a9bcf0e1d"), "Andrei Tarkovsky was a legendary Soviet filmmaker known for his poetic and visually stunning films.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)", "Andrei", "Tarkovsky" },
                    { new Guid("66e5bdca-4a9f-486f-89ed-655402feb17b"), "Frank Darabont is known for his mastery in adapting emotionally resonant films from Stephen King's works.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)", "Frank", "Darabont" },
                    { new Guid("938d6de6-3470-4c16-9e97-296942b63010"), "Rajkumar Hirani is a renowned Indian filmmaker celebrated for his ability to blend humor and emotion.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)", "Rajkumar", "Hirani" },
                    { new Guid("c3893758-b7b4-45e6-9d6a-aa603fa41927"), "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)", "Christopher", "Nolan" },
                    { new Guid("ef5a2579-eee2-4c5f-b3b4-c34b3d1fae76"), "Stanley Kubrick was an iconic filmmaker celebrated for his innovative techniques and cinematic mastery.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)", "Stanley", "Kubrick" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1a630173-d2c4-42ac-9d5d-c18bc03bea31"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("1c04ee38-4f39-4ad6-b44d-f8841a742d2d"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("1ddc4aa4-9d04-4926-80c3-b4c00cce2ace"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("213eac21-3e9c-4bbc-94f8-2b484ff07590"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("497fa8b1-b98e-4a9d-964b-54e8ea9eb865"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("639ddf28-5b7b-4ea1-9f3b-cbb0035b3919"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("86f9151f-956f-4864-a593-fcc5b1890c5a"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("c3afd87d-3dd7-4de1-94c7-a026b406f982"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("c69d0086-2383-4666-8830-fd5bd3b4c966"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("ed9bc2cc-98cb-4703-818f-934e49ef6638"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("15b1046d-64a8-4db6-a306-ff43f5308a0c"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("728c9e8a-fd88-459a-9cc9-8f69171c3adc"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("7740dd35-ebb3-46e8-98e0-e2320e9c9656"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("b5438dfd-5bb3-4fdd-a165-52f3b875e86b"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("e19083c8-e0cf-4046-8d42-1323e634832d"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("810e72c6-a40a-4850-af4f-94d34fd0e261"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("8734f6d3-2ab9-4024-966b-6c3b2fdc861d"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("950ef68b-c487-473e-bc6a-7ccd095fee57"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("a9480718-13e2-4bda-b135-60bdd1bb0718"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b0465a2a-d031-4ae9-970c-15bb6d6c59bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("922e910f-2472-4815-8590-64ee267e9b69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c16a7dc3-bdca-4bd5-86be-6fd93c624d74"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c40e5d48-0965-4622-b892-4e289116dacf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed414e90-c459-4ce2-b766-993b70d24a19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe53304d-7d20-4985-b89c-8342d60f61fd"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("4d811966-5bcd-44dc-aec0-b25a9bcf0e1d"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("66e5bdca-4a9f-486f-89ed-655402feb17b"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("938d6de6-3470-4c16-9e97-296942b63010"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("c3893758-b7b4-45e6-9d6a-aa603fa41927"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("ef5a2579-eee2-4c5f-b3b4-c34b3d1fae76"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1a630173-d2c4-42ac-9d5d-c18bc03bea31"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1c04ee38-4f39-4ad6-b44d-f8841a742d2d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1ddc4aa4-9d04-4926-80c3-b4c00cce2ace"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("213eac21-3e9c-4bbc-94f8-2b484ff07590"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("497fa8b1-b98e-4a9d-964b-54e8ea9eb865"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("639ddf28-5b7b-4ea1-9f3b-cbb0035b3919"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("86f9151f-956f-4864-a593-fcc5b1890c5a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c3afd87d-3dd7-4de1-94c7-a026b406f982"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c69d0086-2383-4666-8830-fd5bd3b4c966"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ed9bc2cc-98cb-4703-818f-934e49ef6638"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("15b1046d-64a8-4db6-a306-ff43f5308a0c"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("728c9e8a-fd88-459a-9cc9-8f69171c3adc"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("7740dd35-ebb3-46e8-98e0-e2320e9c9656"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("b5438dfd-5bb3-4fdd-a165-52f3b875e86b"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("e19083c8-e0cf-4046-8d42-1323e634832d"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("6fb97c94-407e-4f2d-87aa-3374cfd8aa86"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("7caabdf8-3e3e-467f-a6ec-2536ecd974d8"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("85fb8611-6ec4-4f7b-bc2f-ee958c7caa12"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("a082cc32-c860-44ee-a538-380b0441c5dd"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("b7771af3-23ef-4bd3-9316-f3d906b7c376"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("bd059468-7094-4933-8686-c96a7fe1af64"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("d183fd11-6e4f-4bea-8795-79b479e6dcf4"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" },
                    { new Guid("d3a9f2b6-86d5-474e-b1f5-cd0617ff6e0e"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("df078226-92ab-4336-b928-0562a9ad56ef"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("e69a6a92-05bc-43cb-b23b-21536b250c2e"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("0f1a5321-cc6d-4eaf-ae57-ebcb41ce49d6"), "Rajkumar Hirani (born November 20, 1962) is a renowned Indian filmmaker celebrated for his ability to blend humor, emotion, and social commentary.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)", "Rajkumar", "Hirani" },
                    { new Guid("46a23ca5-cbe6-4fd2-8b3a-3409b3be6d19"), "Stanley Kubrick (July 26, 1928 – March 7, 1999) was an iconic filmmaker known for his innovative techniques and mastery across genres.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)", "Stanley", "Kubrick" },
                    { new Guid("46b852dc-b9d8-4f2e-a422-9d891e97920e"), "Christopher Nolan (born July 30, 1970) is a visionary British-American filmmaker celebrated for his innovative storytelling, complex narratives, and technical mastery.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)", "Christopher", "Nolan" },
                    { new Guid("b9f76a01-f545-452f-8532-9662c7859c5d"), "Frank Darabont (born January 28, 1959) is an acclaimed American filmmaker known for adapting emotionally resonant films, particularly from Stephen King's works.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)", "Frank", "Darabont" },
                    { new Guid("bbc53dfd-df68-4d63-82e3-d0f320a94e13"), "Andrei Tarkovsky (April 4, 1932 – December 29, 1986) was a legendary Soviet filmmaker known for his poetic and visually stunning films.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)", "Andrei", "Tarkovsky" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "MovieImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("47d3051b-c9a4-4bd5-8a02-4554add1a0d3"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("49d08a34-4a7d-4a81-ad37-28dd0a6bcf60"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("68eea93c-ab23-48b0-bcd6-b56fb5878a43"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("7c86acbb-40ff-43d9-aea7-af7955144b20"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("99f80b53-dd21-443b-b625-ade19d74678a"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("ba1a0b02-cd0a-4961-8d42-d940fb220a96"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("d5165433-648b-431f-866f-65d1d681eec7"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("dad92977-3e9f-4496-a404-cf55f3ab77a3"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("e252724e-8955-4427-8765-4ec8f98dd3a0"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("eb2df1ed-4090-4c34-b10f-eec1148e6803"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("2310a54a-a66d-4869-98d0-f9c5db538cd8"), "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("2c6efb15-bfd8-4ae6-8e15-2ad56731e849"), "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("38133634-8b30-4e74-96ce-663e5c3908ed"), "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("5e7f6bb9-2625-4136-aea8-d41a9afdbedf"), "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("a845e762-7461-42b9-af77-b9079f74b92e"), "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" }
                });
        }
    }
}
