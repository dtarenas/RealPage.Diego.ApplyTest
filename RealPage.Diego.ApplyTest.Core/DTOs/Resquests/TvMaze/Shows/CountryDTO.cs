namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Country DTO
    /// </summary>
    public class CountryDTO
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        /// <value>
        /// The timezone.
        /// </value>
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}
