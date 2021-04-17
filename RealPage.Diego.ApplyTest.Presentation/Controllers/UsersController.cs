namespace RealPage.Diego.ApplyTest.Presentation.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RealPage.Diego.ApplyTest.BL.Services.Facades;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Users Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class UsersController : Controller
    {
        /// <summary>
        /// The user bl
        /// </summary>
        private readonly IUserBL _userBL;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="userBL">The user bl.</param>
        public UsersController(IUserBL userBL)
        {
            this._userBL = userBL;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>Partial View</returns>
        public async Task<IActionResult> Index()
        {
            try
            {
                var usersResponse = await this._userBL.GetAsync();
                if (usersResponse.IsSuccess)
                {
                    return this.PartialView(usersResponse.ObjResult);
                }

                return this.PartialView("_ErrorPartial", usersResponse.Message);
            }
            catch (Exception ex)
            {
                return this.PartialView("_ErrorPartial", ex.Message);
            }
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>Create View</returns>
        public IActionResult Create()
        {
            return this.PartialView();
        }

        /// <summary>
        /// Creates the specified user create dto.
        /// </summary>
        /// <param name="userCreateDTO">The user create dto.</param>
        /// <returns>
        /// Create Result
        /// </returns>
        [HttpPost]
        public async Task<IActionResult> Create(UserCreateDTO userCreateDTO)
        {
            if (!ModelState.IsValid)
            {
                return this.PartialView(userCreateDTO);
            }

            try
            {
                var usersResponse = await this._userBL.CreateAsync(userCreateDTO);
                if (usersResponse.IsSuccess)
                {
                    TempData["CreateOk"] = true;
                    var users = await this._userBL.GetAsync();
                    return this.PartialView(nameof(Index), users.ObjResult);
                }

                return this.PartialView("_ErrorPartial", usersResponse.Message);
            }
            catch (Exception ex)
            {
                return this.PartialView("_ErrorPartial", ex.Message);
            }
        }

        /// <summary>
        /// Edits this instance.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Edit View</returns>
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var usersResponse = await this._userBL.GetAsync(id);
                if (usersResponse.IsSuccess)
                {
                    var userEditDTO = new UserEditDTO(usersResponse.ObjResult);
                    return this.PartialView(userEditDTO);
                }

                return this.PartialView("_ErrorPartial", usersResponse.Message);
            }
            catch (Exception ex)
            {
                return this.PartialView("_ErrorPartial", ex.Message);
            }
        }

        /// <summary>
        /// Creates the specified user create dto.
        /// </summary>
        /// <param name="userEditDTO">The user edit dto.</param>
        /// <returns>
        /// Create Result
        /// </returns>
        [HttpPost]
        public async Task<IActionResult> Edit(UserEditDTO userEditDTO)
        {
            if (!ModelState.IsValid)
            {
                return this.PartialView(userEditDTO);
            }

            try
            {
                var usersResponse = await this._userBL.UpdateAsync(userEditDTO.UserId, userEditDTO);
                if (usersResponse.IsSuccess)
                {
                    TempData["EditOk"] = true;
                    var users = await this._userBL.GetAsync();
                    return this.PartialView(nameof(Index), users.ObjResult);
                }

                return this.PartialView("_ErrorPartial", usersResponse.Message);
            }
            catch (Exception ex)
            {
                return this.PartialView("_ErrorPartial", ex.Message);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete View</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var usersResponse = await this._userBL.DeleteAsync(id);
                if (usersResponse.IsSuccess)
                {
                    TempData["DeleteOk"] = true;
                    var users = await this._userBL.GetAsync();
                    return this.PartialView(nameof(Index), users.ObjResult);
                }

                return this.PartialView("_ErrorPartial", usersResponse.Message);
            }
            catch (Exception ex)
            {
                return this.PartialView("_ErrorPartial", ex.Message);
            }
        }
    }
}
