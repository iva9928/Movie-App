using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.Country
{
    public class SearchFilterCountryViewModel
    {
        public string SearchQuery { get; set; } = string.Empty;
        public string NameFilter { get; set; } = string.Empty;
        public string DescriptionFilter { get; set; } = string.Empty;
    }
}
