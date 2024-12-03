using MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IQuoteService
    {
        Task<IEnumerable<Quote>> GetAllQuoteAsync();
        Task<IEnumerable<Quote>> GetAllQuoteDetails(string id);
    }
}
