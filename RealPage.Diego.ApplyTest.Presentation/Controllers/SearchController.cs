namespace RealPage.Diego.ApplyTest.Presentation.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RealPage.Diego.ApplyTest.BL.Services.Facades;
    using System.Threading.Tasks;

    /// <summary>
    /// Search Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class SearchController : Controller
    {
        /// <summary>
        /// The tv maze service bl
        /// </summary>
        private readonly ITvMazeServiceBL _tvMazeServiceBL;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchController"/> class.
        /// </summary>
        /// <param name="tvMazeServiceBL">The tv maze service bl.</param>
        public SearchController(ITvMazeServiceBL tvMazeServiceBL)
        {
            this._tvMazeServiceBL = tvMazeServiceBL;
        }

        /// <summary>
        /// Indexes the specified query.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<IActionResult> Index(string id)
        {
            var searchResult = await this._tvMazeServiceBL.SearchByKeywords(id);
            if (searchResult.IsSuccess)
            { 
                return this.PartialView(searchResult.ObjResult);
            }
            else
            {
                return this.BadRequest(searchResult.Message);
            }
        }

        /// <summary>
        /// Detailses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int id)
        {
            var searchResult = await this._tvMazeServiceBL.SearchById(id);
            if (searchResult.IsSuccess)
            {
                TempData["ShowId"] = searchResult.ObjResult.Id;
                return this.PartialView(searchResult.ObjResult);
            }
            else
            {
                return this.BadRequest(searchResult.Message);
            }
        }

        /// <summary>
        /// Seasonses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<IActionResult> Seasons(int id)
        {
            var searchResult = await this._tvMazeServiceBL.SearchSeasons(id);
            if (searchResult.IsSuccess)
            {
                return this.PartialView(searchResult.ObjResult);
            }
            else
            {
                return this.BadRequest(searchResult.Message);
            }
        }

        /// <summary>
        /// Episodeses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<IActionResult> Episodes(int id)
        {
            var searchResult = await this._tvMazeServiceBL.SearchEpisodes(id);
            if (searchResult.IsSuccess)
            {
                return this.PartialView(searchResult.ObjResult);
            }
            else
            {
                return this.BadRequest(searchResult.Message);
            }
        }

        /// <summary>
        /// Episodeses the by date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public async Task<IActionResult> EpisodesByDate(int id, string date)
        {
            var searchResult = await this._tvMazeServiceBL.SearchEpisodes(id, date);
            if (searchResult.IsSuccess)
            {
                return this.PartialView(nameof(Episodes), searchResult.ObjResult);
            }
            else
            {
                return this.BadRequest(searchResult.Message);
            }
        }

        /// <summary>
        /// Casts the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<IActionResult> Cast(int id)
        {
            var searchResult = await this._tvMazeServiceBL.SearchCast(id);
            if (searchResult.IsSuccess)
            {
                return this.PartialView(searchResult.ObjResult);
            }
            else
            {
                return this.BadRequest(searchResult.Message);
            }
        }
    }
}
