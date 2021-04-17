namespace RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users
{
    using RealPage.Diego.ApplyTest.Core.Models;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// User Edit DTO
    /// </summary>
    /// <seealso cref="RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users.UserCreateDTO" />
    public class UserEditDTO : UserCreateDTO
    {
        public UserEditDTO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEditDTO"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public UserEditDTO(User user) : base(user)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEditDTO"/> class.
        /// </summary>
        /// <param name="userDTO">The user dto.</param>
        public UserEditDTO(UserDTO userDTO)
        {
            UserId = userDTO.UserId;
            FirstName = userDTO.FirstName;
            LastName = userDTO.LastName;
            UserName = userDTO.UserName;
            Password = userDTO.Password;
            Role = userDTO.Role;
        }

        /// <summary>
        /// Gets or sets the current password.
        /// </summary>
        /// <value>
        /// The current password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }
    }
}
