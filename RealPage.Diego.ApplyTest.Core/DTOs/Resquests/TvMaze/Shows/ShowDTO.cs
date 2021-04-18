namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Show DTO
    /// </summary>
    public class ShowDTO
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        [JsonPropertyName("genres")]
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [JsonPropertyName("runtime")]
        public int? Runtime { get; set; }

        /// <summary>
        /// Gets or sets the premiered.
        /// </summary>
        /// <value>
        /// The premiered.
        /// </value>
        [JsonPropertyName("premiered")]
        public string Premiered { get; set; }

        /// <summary>
        /// Gets or sets the official site.
        /// </summary>
        /// <value>
        /// The official site.
        /// </value>
        [JsonPropertyName("officialSite")]
        public string OfficialSite { get; set; }

        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        /// <value>
        /// The schedule.
        /// </value>
        [JsonPropertyName("schedule")]
        public ScheduleDTO Schedule { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        [JsonPropertyName("rating")]
        public RatingDTO Rating { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        [JsonPropertyName("weight")]
        public int Weight { get; set; }

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
        /// Gets or sets the DVD country.
        /// </summary>
        /// <value>
        /// The DVD country.
        /// </value>
        [JsonPropertyName("dvdCountry")]
        public object DvdCountry { get; set; }

        /// <summary>
        /// Gets or sets the externals.
        /// </summary>
        /// <value>
        /// The externals.
        /// </value>
        [JsonPropertyName("externals")]
        public ExternalsDTO Externals { get; set; }

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
        /// Gets or sets the updated.
        /// </summary>
        /// <value>
        /// The updated.
        /// </value>
        [JsonPropertyName("updated")]
        public int Updated { get; set; }

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
