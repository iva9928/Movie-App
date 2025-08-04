namespace MovieWebApp.Web.ViewModels.Quote
{
    public class SearchFilterQuoteViewModel
    {
        public string SearchQuery { get; set; } = string.Empty;
        public string CharacterFilter { get; set; } = string.Empty;
        public string MovieOrShowFilter { get; set; } = string.Empty;
    }
}
