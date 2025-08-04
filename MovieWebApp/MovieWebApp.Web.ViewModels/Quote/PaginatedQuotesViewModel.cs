using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.Quote
{
    public class PaginatedQuotesViewModel
    {
        public IEnumerable<QuoteAllViewModel> Quotes { get; set; } = new List<QuoteAllViewModel>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PageSize { get; set; }
    }
}
