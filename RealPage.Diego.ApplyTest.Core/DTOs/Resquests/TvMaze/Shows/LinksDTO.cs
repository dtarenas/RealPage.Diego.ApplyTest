using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows
{
    /// <summary>
    /// Links DTO
    /// </summary>
    public class LinksDTO
    {
        /// <summary>
        /// Gets or sets the self.
        /// </summary>
        /// <value>
        /// The self.
        /// </value>
        [JsonPropertyName("self")]
        public SelfDTO Self { get; set; }

        /// <summary>
        /// Gets or sets the previousepisode.
        /// </summary>
        /// <value>
        /// The previousepisode.
        /// </value>
        [JsonPropertyName("previousepisode")]
        public PreviousepisodeDTO Previousepisode { get; set; }

        /// <summary>
        /// Gets or sets the nextepisode.
        /// </summary>
        /// <value>
        /// The nextepisode.
        /// </value>
        [JsonPropertyName("nextepisode")]
        public NextepisodeDTO Nextepisode { get; set; }
    }
}
