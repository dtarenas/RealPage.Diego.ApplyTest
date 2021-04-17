namespace RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users
{
    using RealPage.Diego.ApplyTest.Core.Enums;
    using RealPage.Diego.ApplyTest.Core.Models;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// User DTO
    /// </summary>
    public class UserDTO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDTO"/> class.
        /// </summary>
        public UserDTO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDTO" /> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public UserDTO(User user)
        {
            this.UserId = user.UserId;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.UserName = user.UserName;
            this.Password = user.Password;
            this.Role = user.Role;
        }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Required]
        [Display(Name = "Id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [Required]
        [StringLength(120)]
        [Display(Name = "Username")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,20}$", ErrorMessage = "{0} must be stronger (trying using special caracteres and uppercase letters)")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public Roles Role { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        [Display(Name = "Full Name")]
        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}