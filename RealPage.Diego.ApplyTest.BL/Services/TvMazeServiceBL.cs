namespace RealPage.Diego.ApplyTest.BL.Services
{
    using RealPage.Diego.ApplyTest.BL.Services.Facades;
    using RealPage.Diego.ApplyTest.Core.Constants;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses;
    using RealPage.Diego.ApplyTest.Core.DTOs.Resquests.TvMaze.Shows;
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
    }
}
