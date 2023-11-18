using System.Net.Http.Json;
using WasmBlazorMovie.Models;

namespace WasmBlazorMovie.Services{
    public class TMDBClient{
        private readonly HttpClient _httpClient;

        public TMDBClient(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
            string? apiKey = config["BearerKey"];
            _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
        }

        public async Task<PopularMoviePagedResponse?> GetPopularMoviesAsync(){
            return await _httpClient.GetFromJsonAsync<PopularMoviePagedResponse>("movie/popular");
        }
        public async Task<MovieDetails?> GetMovieDetailsAsync(int id){
            return await _httpClient.GetFromJsonAsync<MovieDetails>($"movie/{id}");
        }
    }
}