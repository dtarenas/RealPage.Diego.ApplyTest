namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Image DTO
    /// </summary>
    public class ImageDTO
    {
        /// <summary>
        /// Gets or sets the medium.
        /// </summary>
        /// <value>
        /// The medium.
        /// </value>
        [JsonPropertyName("medium")]
        public string Medium { get; set; }

        /// <summary>
        /// Gets or sets the original.
        /// </summary>
        /// <value>
        /// The original.
        /// </value>
        [JsonPropertyName("original")]
        public string Original { get; set; }
    }
}
