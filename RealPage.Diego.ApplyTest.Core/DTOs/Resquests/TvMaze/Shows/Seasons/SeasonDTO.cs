
namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Seasons
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Season DTO
    /// </summary>
    public class SeasonDTO
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the episode order.
        /// </summary>
        /// <value>
        /// The episode order.
        /// </value>
        [JsonPropertyName("episodeOrder")]
        public int? EpisodeOrder { get; set; }

        /// <summary>
        /// Gets or sets the premiere date.
        /// </summary>
        /// <value>
        /// The premiere date.
        /// </value>
        [JsonPropertyName("premiereDate")]
        public string PremiereDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets the network.
        /// </summary>
        /// <value>
        /// The network.
        /// </value>
        [JsonPropertyName("network")]
        public NetworkDTO Network { get; set; }

        /// <summary>
        /// Gets or sets the web channel.
        /// </summary>
        /// <value>
        /// The web channel.
        /// </value>
        [JsonPropertyName("webChannel")]
        public WebChannelDTO WebChannel { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [JsonPropertyName("image")]
        public ImageDTO Image { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        /// <value>
        /// The summary.
        /// </value>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        [JsonPropertyName("_links")]
        public LinksDTO Links { get; set; }
    }
}
