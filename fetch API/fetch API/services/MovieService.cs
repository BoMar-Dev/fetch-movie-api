using fetch_API.interfaces;
using fetch_API.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace fetch_API.services
{
    public class MovieService
    {


        public async Task<object?> GetMovieByTitleAsync(string title) 
        {
            var httpClient = new HttpClient();
            var movieResponse = await httpClient.GetAsync($"https://www.omdbapi.com/?t={title}&apikey=YourImdbApiKey");


            string json = await movieResponse.Content.ReadAsStringAsync();

            var movie = JsonConvert.DeserializeObject<Movie>(json);


            if (movie.Title is not null) return movie;
            else
            {
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(json);
                return errorResponse;
            }
              
        }
    }
}
