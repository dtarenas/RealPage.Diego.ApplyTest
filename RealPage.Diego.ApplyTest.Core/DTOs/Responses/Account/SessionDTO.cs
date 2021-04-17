namespace RealPage.Diego.ApplyTest.Core.DTOs.Responses.Account
{
    using RealPage.Diego.ApplyTest.Core.Enums;

    /// <summary>
    /// Session DTO
    /// </summary>
    public class SessionDTO
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public Roles Role { get; set; }
    }
}
