namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Cast
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Character DTO
    /// </summary>
    public class CharacterDTO
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
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [JsonPropertyName("image")]
        public ImageDTO Image { get; set; }

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