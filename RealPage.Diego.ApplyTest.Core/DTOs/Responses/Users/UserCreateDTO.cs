namespace RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users
{
    using RealPage.Diego.ApplyTest.Core.Models;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// User Create DTO
    /// </summary>
    /// <seealso cref="RealPage.Diego.ApplyTest.Core.DTOs.Responses.UserDTO" />
    public class UserCreateDTO : UserDTO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateDTO"/> class.
        /// </summary>
        public UserCreateDTO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateDTO"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public UserCreateDTO(User user): base(user)
        {
        }

        /// <summary>
        /// Gets or sets the confirm password.
        /// </summary>
        /// <value>
        /// The confirm password.
        /// </value>
        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6)]
        [Compare(nameof(Password), ErrorMessage = "Password doesn't macth")]
        public string ConfirmPassword { get; set; }
    }
}