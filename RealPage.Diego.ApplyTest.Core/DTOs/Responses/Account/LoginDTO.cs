namespace RealPage.Diego.ApplyTest.Core.DTOs.Responses.Account
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Login DTO
    /// </summary>
    public class LoginDTO
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        [Display(Name = "Username")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
