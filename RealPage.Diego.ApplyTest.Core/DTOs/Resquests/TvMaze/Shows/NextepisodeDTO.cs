namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Nextepisode DTO
    /// </summary>
    public class NextepisodeDTO
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
