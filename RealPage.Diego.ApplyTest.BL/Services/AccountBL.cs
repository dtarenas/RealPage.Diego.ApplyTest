namespace RealPage.Diego.ApplyTest.BL.Services
{
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;
    using RealPage.Diego.ApplyTest.BL.Exceptions;
    using RealPage.Diego.ApplyTest.BL.Services.Facades;
    using RealPage.Diego.ApplyTest.BL.Utils;
    using RealPage.Diego.ApplyTest.Core.Constants;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Account;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users;
    using RealPage.Diego.ApplyTest.Core.Enums;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Account BL
    /// </summary>
    /// <seealso cref="IAccountBL" />
    public class AccountBL : IAccountBL
    {
        /// <summary>
        /// The HTTP context
        /// </summary>
        private readonly IHttpContextAccessor _httpContext;

        /// <summary>
        /// The user bl
        /// </summary>
        private readonly IUserBL _userBL;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBL" /> class.
        /// </summary>
        /// <param name="userBL">The user bl.</param>
        /// <param name="httpContext">The HTTP context.</param>
        public AccountBL(IUserBL userBL, IHttpContextAccessor httpContext)
        {
            this._httpContext = httpContext;
            this._userBL = userBL;
        }

        /// <summary>
        /// Logins the specified user identifier.
        /// </summary>
        /// <param name="loginDTO">The login dto.</param>
        /// <returns>
        /// Bool control
        /// </returns>
        public async Task<bool> LoginAsync(LoginDTO loginDTO)
        {
            var userDTO = await this._userBL.GetAsync(loginDTO.Username, loginDTO.Password);
            if (userDTO.UserId > 0)
            {
                this._httpContext.HttpContext.Session.SetString("Username", Encrypt.Base64Encode(userDTO.UserName)); //Creates Session
                this._httpContext.HttpContext.Session.SetString("Role", Encrypt.Base64Encode(userDTO.Role.ToString()));

                return true;
            }

            return false;
        }

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        public void Logout()
        {
            this._httpContext.HttpContext.Session.Remove("Username");
            this._httpContext.HttpContext.Session.Remove("Role");
        }

        /// <summary>
        /// Registers the new client.
        /// </summary>
        /// <param name="userCreateDTO">The user create dto.</param>
        /// <returns>
        /// New Client Entity
        /// </returns>
        /// <exception cref="RealPage.Diego.ApplyTest.BL.Exceptions.BLException"></exception>
        public async Task<UserDTO> RegisterNewUserAsync(UserCreateDTO userCreateDTO)
        {
            var client = await this._userBL.CreateAsync(userCreateDTO);
            if (client.IsSuccess)
            {
                return client.ObjResult;
            }

            throw new BLException(StaticValues.ErrorMessage);
        }

        /// <summary>
        /// Users the exists asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>
        /// Bool control
        /// </returns>
        public async Task<bool> UserExistsAsync(string username)
        {
            return await this._userBL.GetAsync(username);
        }
    }
}
