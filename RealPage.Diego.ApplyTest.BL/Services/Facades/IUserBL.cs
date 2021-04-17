namespace RealPage.Diego.ApplyTest.BL.Services.Facades
{
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// User BL Facade
    /// </summary>
    public interface IUserBL
    {
        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns>
        /// Generic Response DTO List of Users
        /// </returns>
        Task<GenericResponseDTO<List<UserDTO>>> GetAsync();

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<GenericResponseDTO<UserDTO>> GetAsync(int userId);

        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userCreateDTO">The user create dto.</param>
        /// <returns>
        /// Generic Response DTO Created User
        /// </returns>
        Task<GenericResponseDTO<UserDTO>> CreateAsync(UserCreateDTO userCreateDTO);
        
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Task<UserDTO> GetAsync(string username, string password);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userDTO">The user dto.</param>
        /// <returns>
        /// Generic Response DTO Updated User
        /// </returns>
        Task<GenericResponseDTO<UserDTO>> UpdateAsync(int userId, UserEditDTO userDTO);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>
        /// Generic Response DTO
        /// </returns>
        Task<GenericResponseDTO<object>> DeleteAsync(int userId);

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        Task<bool> GetAsync(string username);
    }
}
