using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Director;

namespace MovieWebApp.Web.ViewModels.Director
{
    public class DirectorAllViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string DirectorImageUrl { get; set; }
        public string Description { get; set; }
    }
}
