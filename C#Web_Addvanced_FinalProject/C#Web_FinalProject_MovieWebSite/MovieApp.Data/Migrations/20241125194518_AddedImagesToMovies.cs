using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedImagesToMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("17181166-4c88-44ae-8345-52b1a314afd3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("23dbebf6-fd4f-4485-8606-fa4c7bc6f8d6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3231ef58-8ca5-4cd1-b5bf-b5928b2be94f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d950bd6-13bc-4d99-b6b7-2419d2d607e1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3f08b766-e71c-471f-99e4-60202ba81ae2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4456e730-1d30-42e4-9aad-1b75eab12763"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("70cf2db7-bfc0-4f86-ba52-5eeb89692173"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("87111703-7202-4bf2-8cf6-2a36bcff283e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8ef2367a-3a94-4e43-bcce-d18bce83cb81"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("99c31980-bc8b-4fb7-87b9-3f9b0a140383"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "ImageUrl", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("035be694-cd05-491e-bae5-e1af44d26d3f"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("17576a53-ec60-473e-81f3-3dc2607254ad"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("25a00d17-3da1-4f4f-a8b8-bf43f69aa98f"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("2cfd9146-2707-442c-9308-497b7c7bc3fb"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("35a94bc2-31c0-4dd6-b587-b2e27693f31c"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("5584d41a-85a0-4d1d-ac8f-c976d42e9692"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("5c7a9412-2fdf-49be-9123-21b8108b54da"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("9498da59-5b31-4d33-bbbc-82c2e8311919"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("a6cc5169-c227-489b-92e6-ef0fb7fd1b11"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" },
                    { new Guid("d7b7a9fa-c08f-44ea-be09-258350abd11b"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "https://i.pinimg.com/736x/ce/3c/20/ce3c20c88f5ab3d0376bc40602b90f7b.jpg", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("035be694-cd05-491e-bae5-e1af44d26d3f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("17576a53-ec60-473e-81f3-3dc2607254ad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("25a00d17-3da1-4f4f-a8b8-bf43f69aa98f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2cfd9146-2707-442c-9308-497b7c7bc3fb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("35a94bc2-31c0-4dd6-b587-b2e27693f31c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5584d41a-85a0-4d1d-ac8f-c976d42e9692"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5c7a9412-2fdf-49be-9123-21b8108b54da"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9498da59-5b31-4d33-bbbc-82c2e8311919"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a6cc5169-c227-489b-92e6-ef0fb7fd1b11"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d7b7a9fa-c08f-44ea-be09-258350abd11b"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "Production", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("17181166-4c88-44ae-8345-52b1a314afd3"), "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson", "United Kingdom, United States of America", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within.", 144, "Horror", "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" },
                    { new Guid("23dbebf6-fd4f-4485-8606-fa4c7bc6f8d6"), "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe", "United States of America", "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee.", 101, "Horror", "Two Flints, Northern Lights Films, Animal Kingdom", new DateTime(2014, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Follows" },
                    { new Guid("3231ef58-8ca5-4cd1-b5bf-b5928b2be94f"), "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander", "Japan, United States of America", "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring.", 115, "Horror", "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks", new DateTime(2002, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ring" },
                    { new Guid("3d950bd6-13bc-4d99-b6b7-2419d2d607e1"), "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West", "Canada, Australia", "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all.", 94, "Horror", "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Babadook" },
                    { new Guid("3f08b766-e71c-471f-99e4-60202ba81ae2"), "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch", "United States of America", "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned.", 96, "Horror", "New Line Cinema, Atomic Monster, The Safran Company", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nun" },
                    { new Guid("4456e730-1d30-42e4-9aad-1b75eab12763"), "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb", "United States of America", "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras.", 122, "Horror", "Hoya Productions, Warner Bros. Pictures", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { new Guid("70cf2db7-bfc0-4f86-ba52-5eeb89692173"), "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy", "United States of America", "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.", 112, "Horror", "New Line Cinema, The Safran Company, Evergreen Media Group", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" },
                    { new Guid("87111703-7202-4bf2-8cf6-2a36bcff283e"), "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn", "United States of America", "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country", 83, "Horror", "New Line Cinema, Vortex", new DateTime(1974, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Texas Chain Saw Massacre" },
                    { new Guid("8ef2367a-3a94-4e43-bcce-d18bce83cb81"), "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes", "Spain, United States of America, France, Italy", "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies.", 101, "Horror", " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Others" },
                    { new Guid("99c31980-bc8b-4fb7-87b9-3f9b0a140383"), "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson", "United States of America", "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family.", 110, "Horror", "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" }
                });
        }
    }
}
