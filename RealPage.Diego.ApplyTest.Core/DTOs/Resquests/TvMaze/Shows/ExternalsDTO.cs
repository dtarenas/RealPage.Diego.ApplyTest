namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Externals DTO
    /// </summary>
    public class ExternalsDTO
    {
        /// <summary>
        /// Gets or sets the tvrage.
        /// </summary>
        /// <value>
        /// The tvrage.
        /// </value>
        [JsonPropertyName("tvrage")]
        public int? Tvrage { get; set; }

        /// <summary>
        /// Gets or sets the thetvdb.
        /// </summary>
        /// <value>
        /// The thetvdb.
        /// </value>
        [JsonPropertyName("thetvdb")]
        public int? Thetvdb { get; set; }

        /// <summary>
        /// Gets or sets the imdb.
        /// </summary>
        /// <value>
        /// The imdb.
        /// </value>
        [JsonPropertyName("imdb")]
        public string Imdb { get; set; }
    }
}
