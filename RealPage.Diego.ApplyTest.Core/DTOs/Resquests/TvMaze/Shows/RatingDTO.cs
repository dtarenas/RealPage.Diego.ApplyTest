namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Rating DTO
    /// </summary>
    public class RatingDTO
    {
        /// <summary>
        /// Gets or sets the average.
        /// </summary>
        /// <value>
        /// The average.
        /// </value>
        [JsonPropertyName("average")]
        public double? Average { get; set; }
    }
}
