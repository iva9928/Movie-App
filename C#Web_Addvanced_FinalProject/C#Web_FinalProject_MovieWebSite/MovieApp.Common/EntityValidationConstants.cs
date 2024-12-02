using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Movie
        {
            //Movie
            public const int TittleMaxLength = 70;
            public const int GenreMaxLength = 30;
            public const int CastsMaxLength = 350;
            public const int ProductionMaxLength = 210;
            public const int DescriptionMaxLength = 700;
            public const int CountryMaxLength = 50;

            //Actor
            public const int FirstNameMaxLength = 20;
            public const int SurnameMaxLength = 20;

            //Country
            public const int NameMaxLength = 20;

            //Director
            //AsSameConstantsAsActor

            //Quote
            public const int CharacterMaxLength = 200;
            public const int MovieOrShowMaxLength = 100;


        }
        //public static class PopularActor
        //{
        //    public const int FirstNameMaxLength = 20;
        //    public const int SurrnameMaxLength = 20;
        //    public const int DescriptionMaxLength = 700;


        //}


    }
}
