namespace MovieWebApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Movie
        {
            public const int TitleMaxLength = 70;
            public const int GenreMaxLength = 50;
            public const int CastsMaxLength = 350;
            public const int ProductionMaxLength = 210;
            public const int DescriptionMovieMaxLength = 700;
            public const int CountryMaxLength = 50;
        }

        public static class Actor
        {
            public const int FirstNameMaxLength = 20;
            public const int LastNameMaxLength = 20;
            public const int DescriptionActorMaxLength = 700;

        }

        public static class Country
        {
            public const int NameMaxLength = 256;
            public const int DescriptionCountryeMaxLength = 700;

        }

        public static class Director
        {
            public const int FirstNameMaxLength = 20; // Same as Actor
            public const int LastNameMaxLength = 20;  // Same as Actor
            public const int DescriptionDirectorMaxLength = 700;

        }

        public static class Quote
        {
            public const int CharacterMaxLength = 200;
            public const int MovieOrShowMaxLength = 100;
            public const int DescriptionQuoteMaxLength = 700;

        }

        public static class User
        {
            public const int PasswordMinLength = 8;
            public const int PasswordMaxLength = 100;
            public const int UsernameMinLength = 5;
            public const int UsernameMaxLength = 50;
        }
    }
}
