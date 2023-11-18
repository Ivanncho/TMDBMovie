using System.Text.Json.Serialization;

namespace WasmBlazorMovie.Models
{
    public partial class PopularMoviePagedResponse
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }
        [JsonPropertyName("results")]
        public PopularMovie[] Results { get; set; } = Array.Empty<PopularMovie>();
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}