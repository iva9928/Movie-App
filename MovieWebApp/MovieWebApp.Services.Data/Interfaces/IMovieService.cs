﻿using MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<IEnumerable<Movie>> GetAllMoviesDetails(string id);
        Task AddMovieAsync(Movie movie);
        Task<bool> DeleteMovieAsync(string id);
    }
}