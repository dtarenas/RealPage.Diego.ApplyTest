namespace RealPage.Diego.ApplyTest.BL.Services.Facades
{
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Account;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users;
    using System.Threading.Tasks;

    /// <summary>
    /// Account BL
    /// </summary>
    public interface IAccountBL
    {
        /// <summary>
        /// Users the exists asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>
        /// Bool control
        /// </returns>
        Task<bool> UserExistsAsync(string username);

        /// <summary>
        /// Registers the new client.
        /// </summary>
        /// <param name="userCreateDTO">The user create dto.</param>
        /// <returns>
        /// New Client Entity
        /// </returns>
        Task<UserDTO> RegisterNewUserAsync(UserCreateDTO userCreateDTO);

        /// <summary>
        /// Logins the specified user identifier.
        /// </summary>
        /// <param name="loginDTO">The login dto.</param>
        /// <returns>
        /// Bool control
        /// </returns>
        Task<bool> LoginAsync(LoginDTO loginDTO);

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        void Logout();
    }
}
