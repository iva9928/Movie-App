using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Web.ViewModels.Actor
{
    public class PaginatedActorsViewModel
    {
        public IEnumerable<ActorAllViewModel> Actors { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
    }
}
