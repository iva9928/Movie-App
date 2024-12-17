﻿using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Country;

namespace MovieWebApp.Web.ViewModels.Country
{
    public class CountryAllViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(NameMaxLength, MinimumLength = 2, ErrorMessage = "Country name must be between 2 and {1} characters.")]
        public string Name { get; set; } = null!;

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string CountryImageUrl { get; set; } = null!;
    }
}
