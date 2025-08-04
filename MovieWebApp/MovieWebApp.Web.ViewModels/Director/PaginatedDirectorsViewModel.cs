namespace MovieWebApp.Web.ViewModels.Director
{
    using System.Collections.Generic;

    public class PaginatedDirectorsViewModel
    {
        public IEnumerable<DirectorAllViewModel> Directors { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
    }
}
