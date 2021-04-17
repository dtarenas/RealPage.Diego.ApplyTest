#nullable disable
namespace RealPage.Diego.ApplyTest.Core.Models
{
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users;
    using RealPage.Diego.ApplyTest.Core.Enums;
    using RealPage.Diego.ApplyTest.Core.Models.Base;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// User Entity
    /// </summary>
    /// <seealso cref="RealPage.Diego.ApplyTest.Core.Models.Base.BaseEntity" />
    public partial class User : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
            this.RecordStatus = RecordStatus.Enable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="userCreateDTO">The user create dto.</param>
        public User(UserCreateDTO userCreateDTO)
        {
            UserId = userCreateDTO.UserId;
            FirstName = userCreateDTO.FirstName;
            LastName = userCreateDTO.LastName;
            UserName = userCreateDTO.UserName;
            Password = userCreateDTO.Password;
        }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [StringLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [Required]
        [StringLength(120)]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public Roles Role { get; set; }
    }
}
