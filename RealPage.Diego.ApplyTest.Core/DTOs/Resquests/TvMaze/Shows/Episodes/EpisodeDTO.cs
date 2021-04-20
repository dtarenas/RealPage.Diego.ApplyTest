namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Episodes
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Episode DTO
    /// </summary>
    public class EpisodeDTO
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
        /// Gets or sets the season.
        /// </summary>
        /// <value>
        /// The season.
        /// </value>
        [JsonPropertyName("season")]
        public int Season { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [JsonPropertyName("number")]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the airdate.
        /// </summary>
        /// <value>
        /// The airdate.
        /// </value>
        [JsonPropertyName("airdate")]
        public string Airdate { get; set; }

        /// <summary>
        /// Gets or sets the airtime.
        /// </summary>
        /// <value>
        /// The airtime.
        /// </value>
        [JsonPropertyName("airtime")]
        public string Airtime { get; set; }

        /// <summary>
        /// Gets or sets the airstamp.
        /// </summary>
        /// <value>
        /// The airstamp.
        /// </value>
        [JsonPropertyName("airstamp")]
        public DateTime Airstamp { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }

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
