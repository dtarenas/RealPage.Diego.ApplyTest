namespace RealPage.Diego.ApplyTest.Presentation.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using RealPage.Diego.ApplyTest.BL.Services.Facades;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Account;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Account Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class AccountController : Controller
    {
        /// <summary>
        /// The account service bl
        /// </summary>
        private readonly IAccountBL _accountBL;

        /// <summary>
        /// The HTTP context
        /// </summary>
        private readonly IHttpContextAccessor _httpContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController" /> class.
        /// </summary>
        /// <param name="accountBL">The account service bl.</param>
        /// <param name="httpContext">The HTTP context.</param>
        public AccountController(IAccountBL accountBL, IHttpContextAccessor httpContext)
        {
            this._accountBL = accountBL;
            this._httpContext = httpContext;
        }

        /// <summary>
        /// Logins the specified login dto.
        /// </summary>
        /// <param name="loginDTO">The login dto.</param>
        /// <returns>Login control</returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            try
            {
                var loginControl = await this._accountBL.LoginAsync(loginDTO);
                if (loginControl)
                {
                    return this.RedirectToAction("Index", "Home");
                }
                else
                {
                    return this.BadRequest();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Registers the specified client register dto.
        /// </summary>
        /// <param name="userCreateDTO">The user create dto.</param>
        /// <returns>
        /// Register Control
        /// </returns>
        public async Task<IActionResult> Register(UserCreateDTO userCreateDTO)
        {
            if (await this._accountBL.UserExistsAsync(userCreateDTO.UserName))
            {
                return this.BadRequest();
            }

            try
            {
                var newclient = await this._accountBL.RegisterNewUserAsync(userCreateDTO);
                return this.Ok(true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        /// <returns>Void</returns>
        public IActionResult Logout()
        {
            try
            {
                this._accountBL.Logout();
                return this.RedirectToAction(nameof(Index), "Home");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
