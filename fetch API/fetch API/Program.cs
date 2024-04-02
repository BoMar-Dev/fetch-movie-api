// See https://aka.ms/new-console-template for more information
using fetch_API.models;
using fetch_API.services;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Principal;




await GetMovieProgram();

async Task GetMovieProgram()
{
    

    bool runProgram = true;

        while (runProgram)
    {
        try
        {
            Console.Write("Search for a movie by title and press enter : ");
            string titleInput = Console.ReadLine();

            if (string.IsNullOrEmpty(titleInput))
            {
                throw new Exception("Input cannot be empty, pls add value and search again : ......");

              }

            MovieService movieService = new MovieService();

            var response = await movieService.GetMovieByTitleAsync(titleInput);

            if (response is ErrorResponse error) 
            {
                Console.WriteLine(error.Error);
            }

            if (response is Movie movie)
            {
                Console.WriteLine($"The movie '{movie.Title}' plot is : {movie.Plot} ");

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Press s to seartch a new movie, or press q to quit fukking program");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "s":

                        continue;
                    case "q":
                        runProgram = false;
                        break;


                }

                break;

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

  
  

}




