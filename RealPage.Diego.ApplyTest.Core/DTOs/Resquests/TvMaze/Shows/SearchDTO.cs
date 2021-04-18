namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Search DTO
    /// </summary>
    public class SearchDTO
    {
        /// <summary>
        /// Gets or sets the score.
        /// </summary>
        /// <value>
        /// The score.
        /// </value>
        [JsonPropertyName("score")]
        public double Score { get; set; }

        /// <summary>
        /// Gets or sets the show.
        /// </summary>
        /// <value>
        /// The show.
        /// </value>
        [JsonPropertyName("show")]
        public ShowDTO Show { get; set; }
    }
}
