namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    
    /// <summary>
    /// Schedule DTO
    /// </summary>
    public class ScheduleDTO
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the days.
        /// </summary>
        /// <value>
        /// The days.
        /// </value>
        [JsonPropertyName("days")]
        public List<string> Days { get; set; }
    }
}
