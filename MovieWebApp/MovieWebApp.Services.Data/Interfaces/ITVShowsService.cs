﻿using MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface ITVShowsService
    {
        Task<IEnumerable<TVShows>> GetAllTVShowsAsync();
        Task<IEnumerable<TVShows>> GetAllTVShowsDetails(string id);
        Task AddTVShowsAsync(TVShows TVshows);
        Task<bool> DeleteTVShowsAsync(string id);
    }
}