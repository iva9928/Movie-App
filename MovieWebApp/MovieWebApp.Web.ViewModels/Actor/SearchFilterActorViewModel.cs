using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.Actor
{
    public class SearchFilterActorViewModel
    {
        public string SearchQuery { get; set; } = string.Empty;
        public string FirstNameFilter { get; set; } = string.Empty;
        public string SurnameFilter { get; set; } = string.Empty;
        public string DescriptionFilter { get; set; } = string.Empty;
    }
}
