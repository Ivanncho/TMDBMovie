using System.Text.Json.Serialization;

namespace WasmBlazorMovie.Models{
        public class Genre
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
    public class MovieCollection
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = string.Empty;
        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = string.Empty;
    }

    public class ProductionCompany
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("logo_path")]
        public string LogoPath { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("origin_country")]
        public string OriginCountry { get; set; } = string.Empty;
    }

    public class ProductionCountry
    {
        [JsonPropertyName("iso_3166_1")]
        public string Iso31661 { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public class MovieDetails
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }
        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = string.Empty;
        [JsonPropertyName("belongs_to_collection")]
        public MovieCollection? BelongsToCollection { get; set; }
        [JsonPropertyName("budget")]
        public int Budget { get; set; }
        [JsonPropertyName("genres")]
        public Genre[] Genres { get; set; } = {};
        [JsonPropertyName("homepage")]
        public string Homepage { get; set; } = string.Empty;
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; } = string.Empty;
        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; } = string.Empty;
        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = string.Empty;
        [JsonPropertyName("overview")]
        public string Overview { get; set; } = string.Empty;
        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }
        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = string.Empty;
        [JsonPropertyName("production_companies")]
        public ProductionCompany[] ProductionCompanies { get; set; } = {}; 
        [JsonPropertyName("production_countries")]
        public ProductionCountry[] ProductionCountries { get; set; } = {};
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; } = string.Empty;
        [JsonPropertyName("revenue")]
        public int Revenue { get; set; }
        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }
        [JsonPropertyName("spoken_languages")]
        public SpokenLanguage[] SpokenLanguages { get; set; } = {};
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
        [JsonPropertyName("tagline")]
        public string Tagline { get; set; } = string.Empty;
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        [JsonPropertyName("video")]
        public bool Video { get; set; }
        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }
        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }

    public class SpokenLanguage
    {
        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; } = string.Empty;
        [JsonPropertyName("iso_639_1")]
        public string Iso6391 { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }


}