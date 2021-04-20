namespace RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Cast
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Cast DTO
    /// </summary>
    public class CastDTO
    {
        /// <summary>
        /// Gets or sets the person.
        /// </summary>
        /// <value>
        /// The person.
        /// </value>
        [JsonPropertyName("person")]
        public PersonDTO Person { get; set; }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>
        /// The character.
        /// </value>
        [JsonPropertyName("character")]
        public CharacterDTO Character { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CastDTO"/> is self.
        /// </summary>
        /// <value>
        ///   <c>true</c> if self; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("self")]
        public bool Self { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CastDTO"/> is voice.
        /// </summary>
        /// <value>
        ///   <c>true</c> if voice; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("voice")]
        public bool Voice { get; set; }
    }
}
