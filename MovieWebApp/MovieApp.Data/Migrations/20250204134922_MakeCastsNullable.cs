using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeCastsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("5c745bdd-70c1-4312-b5db-010875f7eef9"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("86803841-d18c-4310-ae4e-407b81e64aaf"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("a23181cc-bfda-402e-aa88-08bb73cbf547"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("c05a9af4-1cf1-45cf-ac3d-24fc5f8e5db5"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("dfcc5aeb-019f-4a09-a20a-63800c84443b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0ea96116-6ad3-4ae2-bf79-107456eb2832"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78ed5d62-9a65-4efa-a1fe-977918d6d0be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cacd583-4cd2-47c9-9bfa-b68ac0f01b40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f552ef83-dc43-478d-ab34-7ea41e439d61"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffe73b12-8fd3-44ab-9688-d889f680754d"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("13b92d0f-fa92-4921-ad77-e54a08d1e541"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("16569a83-5845-46bc-b3a2-4c613e17f4ea"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("1b060870-a9ad-4627-9bc3-ab5389b4338d"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("6bf6a31b-202e-4402-b3d4-8a8a4a8fbdb5"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("e7b5c88e-25a4-4d45-8d78-15b06e6dd348"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3372360b-93e7-4d9d-96a6-21b4ab916cd2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3e04e7b4-e1a6-456b-af9b-b0aa6c76c783"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("46c2c8f2-6008-4da8-9653-97d79e3cf772"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("50683360-1871-44f9-96d5-29943dee8aa5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5acc23a1-2412-4756-b19f-2146a906d67d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6393103a-386b-426f-9340-daf1dbde7c70"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8c418114-f8ce-4479-9b8e-1ef3f4392c8e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ae01bbb5-27da-4228-805a-1465b4e2d6cf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f061fe4c-fa23-4ebc-b3ec-264b4ecfb17f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f310d360-9044-4018-9c94-091bb504978a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("380b4cdc-4308-4c55-8c34-e98269cb9a4a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("3def880f-fc1a-484a-98b1-a65de95b9912"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("8d1014a1-5445-4d2f-b365-c698ec1698e1"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("9f0aa006-f59d-438c-bade-42b33c2341fb"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("a3a7e922-daba-407c-bb24-d3efca61d04f"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("3cdff1a0-2803-40eb-aa6a-b584f3ef9673"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("44cc82da-56c8-4e4f-bab5-0c6912527caf"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("5e8e7066-f40e-4c4c-ae79-15a4b28d3b6a"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("93cbabaa-8fcb-4b15-9839-7372e5fb2e0f"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("9caa61c7-6465-4d57-9088-5286643fc318"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("25d20e3e-c0b4-436e-af25-6fb594083d51"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("26579a75-efe9-459f-92c0-9b756d3aa6e5"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" },
                    { new Guid("74e65031-59fb-4dc0-90e4-7ce289f4beba"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("7ac649b1-5e5b-4fed-ae0b-555c30bde239"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("cd592f2c-b583-45ed-8f77-508c0f6c0786"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("73e0e6b1-fcad-4ede-b643-ff637725e1d7"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("7e5b4881-6546-4e1b-aec2-83bdedd03045"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("a9ecb5f4-d975-4caf-80cf-9f22a4088398"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" },
                    { new Guid("d8341f9d-c9ad-4997-bc1c-01b5fa8037fc"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("e9e164c5-f640-4443-986b-3f51fb255bde"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("26fbee2f-5563-4402-a43a-42a4f4dde96f"), "Frank Darabont is known for his mastery in adapting emotionally resonant films from Stephen King's works.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)", "Frank", "Darabont" },
                    { new Guid("2a341174-5a2e-499b-9347-ea88484e0691"), "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)", "Christopher", "Nolan" },
                    { new Guid("746df2e4-c271-4092-a3f1-7baa87588f01"), "Rajkumar Hirani is a renowned Indian filmmaker celebrated for his ability to blend humor and emotion.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)", "Rajkumar", "Hirani" },
                    { new Guid("8fe059d9-edd1-4495-9828-7e217f9845f8"), "Stanley Kubrick was an iconic filmmaker celebrated for his innovative techniques and cinematic mastery.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)", "Stanley", "Kubrick" },
                    { new Guid("c8ef3317-86e3-460a-a638-404825b1cca5"), "Andrei Tarkovsky was a legendary Soviet filmmaker known for his poetic and visually stunning films.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)", "Andrei", "Tarkovsky" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "ImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("336e3a75-51a5-4da5-860c-ab8d55a9e8a5"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("53f751ca-fcc6-4d3e-97b5-697dabed6d21"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("61eea9d0-4f87-45b6-bd09-b233fa4a5160"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("b36a1170-f581-4236-90a9-19a983adebd6"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("c51d7e56-30c3-402f-b65f-eef3f913cbe6"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("c9f98e0c-f9a2-485c-8afc-4dc9ae0c879c"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("d2ded31c-1144-4451-af0b-932a598b2419"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("d3153c91-cca4-45dc-bc3f-6d376240b625"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("e08e63e9-57ef-4e49-8a4c-07873016ddf1"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("e233a5d7-62c1-41cb-8596-0815d32a663f"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterImageUrl", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("41cf36d7-5c68-484d-9536-11dc47d7f48a"), "https://upload.wikimedia.org/wikipedia/en/5/50/Tyrion_Lannister-Peter_Dinklage.jpg", "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("6a9f3469-d0ca-4050-9543-5a97070b1d5d"), "https://upload.wikimedia.org/wikipedia/en/9/9b/Yoda_Empire_Strikes_Back.png", "Yoda", "“Do, or do not. There is no try.”", "Star Wars" },
                    { new Guid("7d8515d1-1ee3-4bc0-8130-3f749f5085c8"), "https://upload.wikimedia.org/wikipedia/en/9/94/Forest_Gump_Character.jpg", "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("8f90e9fd-fba7-48b6-9fd1-114b3124412a"), "https://i.pinimg.com/736x/1a/2b/b5/1a2bb5bcb59578199ee35f7f03c97876.jpg", "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("a2cc62ff-66fa-41df-b1e3-e354bedcfad2"), "https://i.pinimg.com/originals/a9/74/12/a97412747c6d13646367d5e5912cee4c.jpg", "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" }
                });

            migrationBuilder.InsertData(
                table: "TVShows",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "Production", "ReleaseDate", "TVSeriesImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("0a79a0f5-1479-4fb5-88b0-6f94d901357a"), "Blake Lively, Leighton Meester, Penn Badgley, Chace Crawford, Ed Westwick", "United States of America", "A private group of privileged teens out of the prep school on Manhattan's Upper East Side whose lives revolve round the allknowing albeit ultra-secretive Gossip Girl's site.", 45, "Comedy", " Warner Bros. Television, Alloy Entertainment, Fake Empire Productions, CBS Television Studios", new DateTime(2008, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/3c/f4/3cf4de4ae0c57a86347943b8f75ef0e5/3cf4de4ae0c57a86347943b8f75ef0e5.jpg", "Gossip Girl" },
                    { new Guid("30c5f192-107a-4a36-acdb-1e28109100c3"), "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris, Betsy Brandt", " United States of America", "When a New Mexico chemistry educator, Walter White, has been diagnosed with Stage III cancer and given a prognosis of two years ago to live. He's filled to secure his family's financial future at any cost since he enters the dangerous environment of crime and drugs.", 45, "Drama", "Sony Pictures Television, High Bridge Entertainment, Gran Via Productions", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/7a/78/7a78d2a44e33d64d6c35e1a2c1e2cdc9/7a78d2a44e33d64d6c35e1a2c1e2cdc9.jpg", "Breaking Bad" },
                    { new Guid("9d537d85-82b9-4933-bab3-96891c1eb747"), "Cillian Murphy, Paul Anderson, Helen McCrory, Sophie Rundle, Joe Cole", "United Kingdom", "A gangster family epic set in England, 1919 Birmingham and predicated on their boss Tommy Shelby, who means to maneuver on earth, along with a gang that sew razor blades from the peaks of their caps.", 60, "Drama, Crime", "Tiger Aspect Productions, BBC Studios, Caryn Mandabach Productions, Screen Yorkshire", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/ea/b4/eab48fa4c71804c00008616715dd3777/eab48fa4c71804c00008616715dd3777.jpg", "Peaky Blinders" },
                    { new Guid("d6263773-9274-4931-90f8-19603dcd2b11"), "Paul Wesley, Ian Somerhalder, Nina Dobrev, Kat Graham, Candice King", "United States of America", "The story of two brothers obsessed with the same girl, that bears a striking resemblance to the beautiful but ruthless vampire they knew and adored from 1864.", 45, "Drama, Fantasy, Horror, Romance", "Warner Bros. Television, Alloy Entertainment, Outerbanks Entertainment, Bonanza Productions, CBS Television Studios", new DateTime(2009, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/9a/2e/9a2e3494b96d12dcaded262e7a5ef061/9a2e3494b96d12dcaded262e7a5ef061.jpg", "The Vampire Diaries" },
                    { new Guid("ebae60a7-02d9-4060-984d-58c3ea859c5f"), "Wentworth Miller, Dominic Purcell, Sarah Wayne Callies, Paul Adelstein, Rockmond Dunbar", "United States of America", "Due to a political warfare, an innocent man has been sent to death row and his only hope is his own brother, who makes it his obligation to deliberately get himself shipped to the identical prison as a way to break both of them out, from the inside out.", 45, "Action & Adventure, Crime, Drama", "Prison Break Productions, Adelstein-Parouse Productions, Original Television, 20th Century Fox Television", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/90/35/9035e9fd6129b4d5bbecd6a8351269cc/9035e9fd6129b4d5bbecd6a8351269cc.jpg", "Prison Break" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("25d20e3e-c0b4-436e-af25-6fb594083d51"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("26579a75-efe9-459f-92c0-9b756d3aa6e5"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("74e65031-59fb-4dc0-90e4-7ce289f4beba"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("7ac649b1-5e5b-4fed-ae0b-555c30bde239"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("cd592f2c-b583-45ed-8f77-508c0f6c0786"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73e0e6b1-fcad-4ede-b643-ff637725e1d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e5b4881-6546-4e1b-aec2-83bdedd03045"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9ecb5f4-d975-4caf-80cf-9f22a4088398"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8341f9d-c9ad-4997-bc1c-01b5fa8037fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e9e164c5-f640-4443-986b-3f51fb255bde"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("26fbee2f-5563-4402-a43a-42a4f4dde96f"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2a341174-5a2e-499b-9347-ea88484e0691"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("746df2e4-c271-4092-a3f1-7baa87588f01"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("8fe059d9-edd1-4495-9828-7e217f9845f8"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("c8ef3317-86e3-460a-a638-404825b1cca5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("336e3a75-51a5-4da5-860c-ab8d55a9e8a5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("53f751ca-fcc6-4d3e-97b5-697dabed6d21"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("61eea9d0-4f87-45b6-bd09-b233fa4a5160"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b36a1170-f581-4236-90a9-19a983adebd6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c51d7e56-30c3-402f-b65f-eef3f913cbe6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c9f98e0c-f9a2-485c-8afc-4dc9ae0c879c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d2ded31c-1144-4451-af0b-932a598b2419"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d3153c91-cca4-45dc-bc3f-6d376240b625"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e08e63e9-57ef-4e49-8a4c-07873016ddf1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e233a5d7-62c1-41cb-8596-0815d32a663f"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("41cf36d7-5c68-484d-9536-11dc47d7f48a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6a9f3469-d0ca-4050-9543-5a97070b1d5d"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("7d8515d1-1ee3-4bc0-8130-3f749f5085c8"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("8f90e9fd-fba7-48b6-9fd1-114b3124412a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("a2cc62ff-66fa-41df-b1e3-e354bedcfad2"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("0a79a0f5-1479-4fb5-88b0-6f94d901357a"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("30c5f192-107a-4a36-acdb-1e28109100c3"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("9d537d85-82b9-4933-bab3-96891c1eb747"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("d6263773-9274-4931-90f8-19603dcd2b11"));

            migrationBuilder.DeleteData(
                table: "TVShows",
                keyColumn: "Id",
                keyValue: new Guid("ebae60a7-02d9-4060-984d-58c3ea859c5f"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("5c745bdd-70c1-4312-b5db-010875f7eef9"), "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg", "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.", "Bradley", "Cooper" },
                    { new Guid("86803841-d18c-4310-ae4e-407b81e64aaf"), "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg", "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.", "Colman", "Domingo" },
                    { new Guid("a23181cc-bfda-402e-aa88-08bb73cbf547"), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.", "Paul", "Giamatti" },
                    { new Guid("c05a9af4-1cf1-45cf-ac3d-24fc5f8e5db5"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg", "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.", "Scarlett", "Johansson" },
                    { new Guid("dfcc5aeb-019f-4a09-a20a-63800c84443b"), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.", "Cillian", "Murphy" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryImageUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0ea96116-6ad3-4ae2-bf79-107456eb2832"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png", "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.", "United Kingdom" },
                    { new Guid("78ed5d62-9a65-4efa-a1fe-977918d6d0be"), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png", "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.", "India" },
                    { new Guid("8cacd583-4cd2-47c9-9bfa-b68ac0f01b40"), "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png", "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.", "China" },
                    { new Guid("f552ef83-dc43-478d-ab34-7ea41e439d61"), "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg", "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.", "United States" },
                    { new Guid("ffe73b12-8fd3-44ab-9688-d889f680754d"), "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg", "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.", "France" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Description", "DirectorImageUrl", "FamousMovies", "FirstName", "Surname" },
                values: new object[,]
                {
                    { new Guid("13b92d0f-fa92-4921-ad77-e54a08d1e541"), "Frank Darabont is known for his mastery in adapting emotionally resonant films from Stephen King's works.", "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)", "Frank", "Darabont" },
                    { new Guid("16569a83-5845-46bc-b3a2-4c613e17f4ea"), "Stanley Kubrick was an iconic filmmaker celebrated for his innovative techniques and cinematic mastery.", "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg", "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)", "Stanley", "Kubrick" },
                    { new Guid("1b060870-a9ad-4627-9bc3-ab5389b4338d"), "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg", "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)", "Christopher", "Nolan" },
                    { new Guid("6bf6a31b-202e-4402-b3d4-8a8a4a8fbdb5"), "Andrei Tarkovsky was a legendary Soviet filmmaker known for his poetic and visually stunning films.", "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg", "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)", "Andrei", "Tarkovsky" },
                    { new Guid("e7b5c88e-25a4-4d45-8d78-15b06e6dd348"), "Rajkumar Hirani is a renowned Indian filmmaker celebrated for his ability to blend humor and emotion.", "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg", "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)", "Rajkumar", "Hirani" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "ImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("3372360b-93e7-4d9d-96a6-21b4ab916cd2"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("3e04e7b4-e1a6-456b-af9b-b0aa6c76c783"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("46c2c8f2-6008-4da8-9653-97d79e3cf772"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("50683360-1871-44f9-96d5-29943dee8aa5"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("5acc23a1-2412-4756-b19f-2146a906d67d"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("6393103a-386b-426f-9340-daf1dbde7c70"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("8c418114-f8ce-4479-9b8e-1ef3f4392c8e"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("ae01bbb5-27da-4228-805a-1465b4e2d6cf"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("f061fe4c-fa23-4ebc-b3ec-264b4ecfb17f"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("f310d360-9044-4018-9c94-091bb504978a"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CharacterImageUrl", "CharacterName", "Description", "MovieOrShow" },
                values: new object[,]
                {
                    { new Guid("380b4cdc-4308-4c55-8c34-e98269cb9a4a"), "https://i.pinimg.com/736x/1a/2b/b5/1a2bb5bcb59578199ee35f7f03c97876.jpg", "Michael Scofield", "'Sometimes, the only way to truly escape the past is to keep moving forward.'", "Prison Break" },
                    { new Guid("3def880f-fc1a-484a-98b1-a65de95b9912"), "https://i.pinimg.com/originals/a9/74/12/a97412747c6d13646367d5e5912cee4c.jpg", "Fernando Sucre", "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”", "Prison Break" },
                    { new Guid("8d1014a1-5445-4d2f-b365-c698ec1698e1"), "https://upload.wikimedia.org/wikipedia/en/9/94/Forest_Gump_Character.jpg", "Forest Gump", "“Life is like a box of chocolates. You never know what you’re gonna get.”", "Forest Gump" },
                    { new Guid("9f0aa006-f59d-438c-bade-42b33c2341fb"), "https://upload.wikimedia.org/wikipedia/en/5/50/Tyrion_Lannister-Peter_Dinklage.jpg", "Tyrion Lannister", "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”", "Game og Thrones" },
                    { new Guid("a3a7e922-daba-407c-bb24-d3efca61d04f"), "https://upload.wikimedia.org/wikipedia/en/9/9b/Yoda_Empire_Strikes_Back.png", "Yoda", "“Do, or do not. There is no try.”", "Star Wars" }
                });

            migrationBuilder.InsertData(
                table: "TVShows",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "Production", "ReleaseDate", "TVSeriesImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("3cdff1a0-2803-40eb-aa6a-b584f3ef9673"), "Wentworth Miller, Dominic Purcell, Sarah Wayne Callies, Paul Adelstein, Rockmond Dunbar", "United States of America", "Due to a political warfare, an innocent man has been sent to death row and his only hope is his own brother, who makes it his obligation to deliberately get himself shipped to the identical prison as a way to break both of them out, from the inside out.", 45, "Action & Adventure, Crime, Drama", "Prison Break Productions, Adelstein-Parouse Productions, Original Television, 20th Century Fox Television", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/90/35/9035e9fd6129b4d5bbecd6a8351269cc/9035e9fd6129b4d5bbecd6a8351269cc.jpg", "Prison Break" },
                    { new Guid("44cc82da-56c8-4e4f-bab5-0c6912527caf"), "Blake Lively, Leighton Meester, Penn Badgley, Chace Crawford, Ed Westwick", "United States of America", "A private group of privileged teens out of the prep school on Manhattan's Upper East Side whose lives revolve round the allknowing albeit ultra-secretive Gossip Girl's site.", 45, "Comedy", " Warner Bros. Television, Alloy Entertainment, Fake Empire Productions, CBS Television Studios", new DateTime(2008, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/3c/f4/3cf4de4ae0c57a86347943b8f75ef0e5/3cf4de4ae0c57a86347943b8f75ef0e5.jpg", "Gossip Girl" },
                    { new Guid("5e8e7066-f40e-4c4c-ae79-15a4b28d3b6a"), "Paul Wesley, Ian Somerhalder, Nina Dobrev, Kat Graham, Candice King", "United States of America", "The story of two brothers obsessed with the same girl, that bears a striking resemblance to the beautiful but ruthless vampire they knew and adored from 1864.", 45, "Drama, Fantasy, Horror, Romance", "Warner Bros. Television, Alloy Entertainment, Outerbanks Entertainment, Bonanza Productions, CBS Television Studios", new DateTime(2009, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/9a/2e/9a2e3494b96d12dcaded262e7a5ef061/9a2e3494b96d12dcaded262e7a5ef061.jpg", "The Vampire Diaries" },
                    { new Guid("93cbabaa-8fcb-4b15-9839-7372e5fb2e0f"), "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris, Betsy Brandt", " United States of America", "When a New Mexico chemistry educator, Walter White, has been diagnosed with Stage III cancer and given a prognosis of two years ago to live. He's filled to secure his family's financial future at any cost since he enters the dangerous environment of crime and drugs.", 45, "Drama", "Sony Pictures Television, High Bridge Entertainment, Gran Via Productions", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/7a/78/7a78d2a44e33d64d6c35e1a2c1e2cdc9/7a78d2a44e33d64d6c35e1a2c1e2cdc9.jpg", "Breaking Bad" },
                    { new Guid("9caa61c7-6465-4d57-9088-5286643fc318"), "Cillian Murphy, Paul Anderson, Helen McCrory, Sophie Rundle, Joe Cole", "United Kingdom", "A gangster family epic set in England, 1919 Birmingham and predicated on their boss Tommy Shelby, who means to maneuver on earth, along with a gang that sew razor blades from the peaks of their caps.", 60, "Drama, Crime", "Tiger Aspect Productions, BBC Studios, Caryn Mandabach Productions, Screen Yorkshire", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://f.woowoowoowoo.net/resize/250x400/ea/b4/eab48fa4c71804c00008616715dd3777/eab48fa4c71804c00008616715dd3777.jpg", "Peaky Blinders" }
                });
        }
    }
}
