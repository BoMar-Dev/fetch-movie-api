# Movie Fetch API

This project is a small C#/.NET application that fetches movie information from the OMDB API based on user input and displays it in the console.

## Overview

The project consists of several components:

### Interfaces

- `IResponse`: An interface defining a common structure for API responses.

### Models

- `ErrorResponse`: A model representing error responses from the API.
- `Movie`: A model representing movie information fetched from the API.
- `ratingSources`: A model representing rating sources for movies.

### Services

- `MovieService`: A service responsible for fetching movie data from the OMDB API.

### Program

- The main program that interacts with the user, prompts for a movie title, and displays movie information fetched from the API.

## Usage

To use the program, follow these steps:

1. Run the program.
2. Enter the title of the movie you want to search for.
3. The program will display the plot of the movie if found.
4. You can choose to search for another movie or exit the program.

## Note

Please note that this project relies on a free version of the OMDB API, which may have limitations or occasional downtimes. If the API is not responding, you may experience issues fetching movie information.

## Dependencies

- Newtonsoft.Json: A popular JSON framework for .NET.

## Getting Started

To get started with the project, clone the repository and open it in your preferred C#/.NET development environment.
Get your API key [here](https://developer.imdb.com/documentation/api-documentation/getting-access/).



