using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.Director
{
    public class SearchFilterDirectorViewModel
    {
        public string SearchQuery { get; set; } = string.Empty;
        public string FirstNameFilter { get; set; } = string.Empty;
        public string SurnameFilter { get; set; } = string.Empty;
    }
}
