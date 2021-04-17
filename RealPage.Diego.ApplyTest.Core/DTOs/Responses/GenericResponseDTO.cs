namespace RealPage.Diego.ApplyTest.Core.DTOs.Responses
{
    /// <summary>
    /// Generic Response DTO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericResponseDTO<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResponseDTO{T}"/> class.
        /// </summary>
        public GenericResponseDTO()
        {
            this.IsSuccess = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the object result.
        /// </summary>
        /// <value>
        /// The object result.
        /// </value>
        public T ObjResult { get; set; }
    }
}