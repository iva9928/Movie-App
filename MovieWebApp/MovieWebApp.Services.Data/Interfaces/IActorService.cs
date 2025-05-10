using MovieWebApp.Web.ViewModels.Actor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IActorService
    {
        Task<IEnumerable<ActorAllViewModel>> GetAllActorsAsync();
        Task<IEnumerable<ActorAllViewModel>> GetFilteredActorsAsync(string searchQuery, string firstNameFilter, string surnameFilter, string descriptionFilter);
        Task<ActorDetailsViewModel?> GetActorDetailsAsync(string id);
        Task AddActorAsync(AddActorViewModel model);
        Task<bool> DeleteActorAsync(string id);
        Task<EditActorViewModel?> GetEditModelAsync(string id);
        Task<bool> EditActorAsync(EditActorViewModel model);
    }
}
