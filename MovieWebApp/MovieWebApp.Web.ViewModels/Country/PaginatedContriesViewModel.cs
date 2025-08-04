using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.Country
{
    public class PaginatedCountriesViewModel
    {
        public IEnumerable<CountryAllViewModel> Countries { get; set; } = new List<CountryAllViewModel>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PageSize { get; set; }
    }
}
