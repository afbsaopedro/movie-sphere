using System.Text.Json.Serialization;

namespace MovieSphere.Dto
{
    public class MoviesResponse
    {
        [JsonPropertyName("results")]
        public IEnumerable<Movie> Movies { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }
    }
}
