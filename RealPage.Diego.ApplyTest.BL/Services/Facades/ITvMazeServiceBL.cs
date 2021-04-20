namespace RealPage.Diego.ApplyTest.BL.Services.Facades
{
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Cast;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Episodes;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Seasons;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Tv Maze Service BL
    /// </summary>
    public interface ITvMazeServiceBL
    {
        /// <summary>
        /// Searches the by keywords.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>List Of Search DTO</returns>
        Task<GenericResponseDTO<List<SearchDTO>>> SearchByKeywords(string query);

        /// <summary>
        /// Searches the by identifier.
        /// </summary>
        /// <param name="showId">The show identifier.</param>
        /// <returns>
        /// Show DTO
        /// </returns>
        Task<GenericResponseDTO<ShowDTO>> SearchById(int showId);

        /// <summary>
        /// Searches the episodes.
        /// </summary>
        /// <param name="seasonId">The identifier.</param>
        /// <returns>
        /// List of Episode DTO
        /// </returns>
        Task<GenericResponseDTO<List<EpisodeDTO>>> SearchEpisodes(int seasonId);

        /// <summary>
        /// Searches the episodes.
        /// </summary>
        /// <param name="showId">The show identifier.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        Task<GenericResponseDTO<List<EpisodeDTO>>> SearchEpisodes(int showId, string date);

        /// <summary>
        /// Searches the seasons.
        /// </summary>
        /// <param name="showId">The identifier.</param>
        /// <returns>
        /// List Of Seasons DTO
        /// </returns>
        Task<GenericResponseDTO<List<SeasonDTO>>> SearchSeasons(int showId);

        /// <summary>
        /// Searches the cast.
        /// </summary>
        /// <param name="showId">The show identifier.</param>
        /// <returns></returns>
        Task<GenericResponseDTO<List<CastDTO>>> SearchCast(int showId);
    }
}