using MovieWebApp.Web.ViewModels.Quote;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IQuoteService
    {
        Task<IEnumerable<QuoteAllViewModel>> GetAllQuotesAsync();
        Task<QuoteDetailsViewModel?> GetQuoteDetailsAsync(string id);
        Task AddQuoteAsync(AddQuoteViewModel model);
        Task<bool> DeleteQuoteAsync(string id);
        Task<EditQuoteViewModel?> GetEditModelAsync(string id);
        Task<bool> EditQuoteAsync(EditQuoteViewModel model);
        Task<IEnumerable<QuoteAllViewModel>> GetFilteredQuotesAsync(string searchQuery, string characterFilter, string movieFilter);
    }
}
