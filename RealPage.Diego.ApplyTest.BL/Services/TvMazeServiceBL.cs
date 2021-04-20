namespace RealPage.Diego.ApplyTest.BL.Services
{
    using RealPage.Diego.ApplyTest.BL.Services.Facades;
    using RealPage.Diego.ApplyTest.Core.Constants;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Cast;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Episodes;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows.Seasons;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// Tv Maze Service BL
    /// </summary>
    /// <seealso cref="RealPage.Diego.ApplyTest.BL.Services.Facades.ITvMazeServiceBL" />
    public class TvMazeServiceBL : ITvMazeServiceBL
    {
        /// <summary>
        /// The HTTP client
        /// </summary>
        private readonly HttpClient _httpClient;

        public TvMazeServiceBL(IHttpClientFactory httpClientFactory)
        {
            this._httpClient = httpClientFactory.CreateClient("TVmaze");
        }

        /// <summary>
        /// Searches the by identifier.
        /// </summary>
        /// <param name="showId">The identifier.</param>
        /// <returns>
        /// Search DTO
        /// </returns>
        public async Task<GenericResponseDTO<ShowDTO>> SearchById(int showId)
        {
            var uriEndpoint = $"shows/{showId}";
            try
            {
                var responseString = await this._httpClient.GetStringAsync(uriEndpoint);
                var response = JsonSerializer.Deserialize<ShowDTO>(responseString);
                return new GenericResponseDTO<ShowDTO>()
                {
                    IsSuccess = true,
                    Message = StaticValues.OkMessage,
                    ObjResult = response
                };
            }
            catch (Exception ex)
            {
                return new GenericResponseDTO<ShowDTO>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ObjResult = null
                };
            }
        }

        /// <summary>
        /// Searches the by keywords.
        /// </summary>
        /// <param name="query">The q.</param>
        /// <returns>Search Result</returns>
        public async Task<GenericResponseDTO<List<SearchDTO>>> SearchByKeywords(string query)
        {
            var uriEndpoint = $"search/shows?q={query}";
            try
            {
                var responseString = await this._httpClient.GetStringAsync(uriEndpoint);
                var response = JsonSerializer.Deserialize<List<SearchDTO>>(responseString);
                return new GenericResponseDTO<List<SearchDTO>>()
                {
                    IsSuccess = true,
                    Message = StaticValues.OkMessage,
                    ObjResult = response
                };
            }
            catch (Exception ex)
            {
                return new GenericResponseDTO<List<SearchDTO>>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ObjResult = null
                };
            }
        }

        /// <summary>
        /// Searches the cast.
        /// </summary>
        /// <param name="showId">The show identifier.</param>
        /// <returns></returns>
        public async Task<GenericResponseDTO<List<CastDTO>>> SearchCast(int showId)
        {
            var uriEndpoint = $"shows/{showId}/cast";
            try
            {
                var responseString = await this._httpClient.GetStringAsync(uriEndpoint);
                var response = JsonSerializer.Deserialize<List<CastDTO>>(responseString);
                return new GenericResponseDTO<List<CastDTO>>()
                {
                    IsSuccess = true,
                    Message = StaticValues.OkMessage,
                    ObjResult = response
                };
            }
            catch (Exception ex)
            {
                return new GenericResponseDTO<List<CastDTO>>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ObjResult = null
                };
            }
        }

        /// <summary>
        /// Searches the episodes.
        /// </summary>
        /// <param name="seasonId">The season identifier.</param>
        /// <returns>
        /// List of Episode DTO
        /// </returns>
        public async Task<GenericResponseDTO<List<EpisodeDTO>>> SearchEpisodes(int seasonId)
        {
            var uriEndpoint = $"seasons/{seasonId}/episodes";
            try
            {
                var responseString = await this._httpClient.GetStringAsync(uriEndpoint);
                var response = JsonSerializer.Deserialize<List<EpisodeDTO>>(responseString);
                return new GenericResponseDTO<List<EpisodeDTO>>()
                {
                    IsSuccess = true,
                    Message = StaticValues.OkMessage,
                    ObjResult = response
                };
            }
            catch (Exception ex)
            {
                return new GenericResponseDTO<List<EpisodeDTO>>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ObjResult = null
                };
            }
        }

        /// <summary>
        /// Searches the episodes.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public async Task<GenericResponseDTO<List<EpisodeDTO>>> SearchEpisodes(int showId, string date)
        {
            var uriEndpoint = $"shows/{showId}/episodesbydate?date={date}";
            try
            {
                var responseString = await this._httpClient.GetStringAsync(uriEndpoint);
                var response = JsonSerializer.Deserialize<List<EpisodeDTO>>(responseString);
                return new GenericResponseDTO<List<EpisodeDTO>>()
                {
                    IsSuccess = true,
                    Message = StaticValues.OkMessage,
                    ObjResult = response
                };
            }
            catch (Exception ex)
            {
                return new GenericResponseDTO<List<EpisodeDTO>>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ObjResult = null
                };
            }
        }

        /// <summary>
        /// Searches the seasons.
        /// </summary>
        /// <param name="showId">The identifier.</param>
        /// <returns>
        /// List Of Seasons DTO
        /// </returns>
        public async Task<GenericResponseDTO<List<SeasonDTO>>> SearchSeasons(int showId)
        {
            var uriEndpoint = $"shows/{showId}/seasons";
            try
            {
                var responseString = await this._httpClient.GetStringAsync(uriEndpoint);
                var response = JsonSerializer.Deserialize<List<SeasonDTO>>(responseString);
                return new GenericResponseDTO<List<SeasonDTO>>()
                {
                    IsSuccess = true,
                    Message = StaticValues.OkMessage,
                    ObjResult = response
                };
            }
            catch (Exception ex)
            {
                return new GenericResponseDTO<List<SeasonDTO>>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ObjResult = null
                };
            }
        }
    }
}
