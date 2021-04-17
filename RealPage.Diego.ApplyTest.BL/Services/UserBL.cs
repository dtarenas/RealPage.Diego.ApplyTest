namespace RealPage.Diego.ApplyTest.BL.Services
{
    using Microsoft.EntityFrameworkCore;
    using RealPage.Diego.ApplyTest.BL.Exceptions;
    using RealPage.Diego.ApplyTest.BL.Services.Facades;
    using RealPage.Diego.ApplyTest.BL.Utils;
    using RealPage.Diego.ApplyTest.Core.Constants;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses.Users;
    using RealPage.Diego.ApplyTest.Core.Models;
    using RealPage.Diego.ApplyTest.DAL.Repo.Facades;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// User BL
    /// </summary>
    /// <seealso cref="RealPage.Diego.ApplyTest.BL.Services.Facades.IUserBL" />
    public class UserBL : IUserBL
    {
        /// <summary>
        /// The user repo
        /// </summary>
        private readonly IGenericRepo<User> _userRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBL" /> class.
        /// </summary>
        /// <param name="userRepo">The user repo.</param>
        public UserBL(IGenericRepo<User> userRepo)
        {
            this._userRepo = userRepo;
        }

        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userCreateDTO">The user create dto.</param>
        /// <returns>
        /// Generic Response DTO Created User
        /// </returns>
        public async Task<GenericResponseDTO<UserDTO>> CreateAsync(UserCreateDTO userCreateDTO)
        {
            if (await this._userRepo.Get().AnyAsync(x => string.Equals(x.UserName, userCreateDTO.UserName)))
            {
                throw new BLException("Username is already taken");
            }

            userCreateDTO.Password = Encrypt.GetSHA256(userCreateDTO.Password); ////Password Encrypting
            var user = new User(userCreateDTO);
            await this._userRepo.AddAsync(user);
            await this._userRepo.SaveChangesAsync();
            var userDTO = new UserDTO(user);
            return new GenericResponseDTO<UserDTO>()
            {
                Message = StaticValues.OkMessage,
                ObjResult = userDTO
            };
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>
        /// Generic Response DTO
        /// </returns>
        /// <exception cref="RealPage.Diego.ApplyTest.BL.Exceptions.BLException"></exception>
        public async Task<GenericResponseDTO<object>> DeleteAsync(int userId)
        {
            var user = await this._userRepo.Get().FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                throw new BLException(StaticValues.NotFound);
            }

            await this._userRepo.DeleteAsync(userId);
            await this._userRepo.SaveChangesAsync();
            return new GenericResponseDTO<object>()
            {
                IsSuccess = true,
                Message = StaticValues.OkMessage,
                ObjResult = null
            };
        }

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns>
        /// Generic Response DTO List of Users
        /// </returns>
        public async Task<GenericResponseDTO<List<UserDTO>>> GetAsync()
        {
            var userDTOs = await this._userRepo.Get().Select(x => new UserDTO(x)).ToListAsync();
            return new GenericResponseDTO<List<UserDTO>>()
            {
                IsSuccess = true,
                Message = StaticValues.OkMessage,
                ObjResult = userDTOs
            };
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>Generic Response DTO Users</returns>
        public async Task<GenericResponseDTO<UserDTO>> GetAsync(int userId)
        {
            var userDTO = await this._userRepo.Get().FirstOrDefaultAsync(x => x.UserId == userId);
            return new GenericResponseDTO<UserDTO>()
            {
                IsSuccess = true,
                Message = StaticValues.OkMessage,
                ObjResult = new UserDTO(userDTO)
            };
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public async Task<UserDTO> GetAsync(string username, string password)
        {
            var user = await this._userRepo.Get().FirstOrDefaultAsync(x => x.UserName == username && x.Password == Encrypt.GetSHA256(password));
            if (user != null)
            {
                return new UserDTO(user);
            }

            return new UserDTO();
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public async Task<bool> GetAsync(string username)
        {
            return await this._userRepo.Get().AnyAsync(x => x.UserName == username);
        }

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userEditDTO">The user dto.</param>
        /// <returns>
        /// Generic Response DTO Updated User
        /// </returns>
        /// <exception cref="RealPage.Diego.ApplyTest.BL.Exceptions.BLException">
        /// </exception>
        public async Task<GenericResponseDTO<UserDTO>> UpdateAsync(int userId, UserEditDTO userEditDTO)
        {
            if (userId != userEditDTO.UserId)
            {
                throw new BLException(StaticValues.NotFound);
            }

            var user = await this._userRepo.Get().FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                throw new BLException(StaticValues.NotFound);
            }

            if (Encrypt.GetSHA256(userEditDTO.CurrentPassword) != user.Password)
            {
                throw new BLException(StaticValues.SamePass);
            }

            var newPassEncrypted = Encrypt.GetSHA256(userEditDTO.Password);
            if (newPassEncrypted == user.Password)
            {
                throw new BLException(StaticValues.SamePass);
            }

            user.UserId = userEditDTO.UserId;
            user.FirstName = userEditDTO.FirstName;
            user.LastName = userEditDTO.LastName;
            user.UserName = userEditDTO.UserName;
            user.Password = newPassEncrypted;

            this._userRepo.Update(user);
            await this._userRepo.SaveChangesAsync();

            return new GenericResponseDTO<UserDTO>()
            {
                IsSuccess = true,
                Message = StaticValues.OkMessage,
                ObjResult = userEditDTO
            };
        }
    }
}
