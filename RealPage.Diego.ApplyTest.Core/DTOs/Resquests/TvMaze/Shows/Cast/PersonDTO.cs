namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Cast
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Person DTO
    /// </summary>
    public class PersonDTO
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
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [JsonPropertyName("country")]
        public CountryDTO Country { get; set; }

        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        /// <value>
        /// The birthday.
        /// </value>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// Gets or sets the deathday.
        /// </summary>
        /// <value>
        /// The deathday.
        /// </value>
        [JsonPropertyName("deathday")]
        public string Deathday { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

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