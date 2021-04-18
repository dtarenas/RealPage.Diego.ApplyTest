namespace RealPage.Diego.ApplyTest.BL.Services.Facades
{
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows;
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
        /// <returns></returns>
        Task<GenericResponseDTO<List<SearchDTO>>> SearchByKeywords(string query);
    }
}