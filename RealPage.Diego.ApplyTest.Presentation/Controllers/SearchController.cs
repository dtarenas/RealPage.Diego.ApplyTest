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
            return this.PartialView(searchResult.ObjResult);
        }
    }
}
