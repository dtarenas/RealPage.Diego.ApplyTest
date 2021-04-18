namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Previousepisode DTO
    /// </summary>
    public class PreviousepisodeDTO
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        [JsonPropertyName("href")]
        public string Href { get; set; }
    }
}
