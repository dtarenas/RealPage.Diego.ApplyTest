namespace RealPage.Diego.ApplyTest.Presentation.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using RealPage.Diego.ApplyTest.Core.ViewModels;
    using System.Diagnostics;

    /// <summary>
    /// Home Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public HomeController(ILogger<HomeController> logger)
        {
            this._logger = logger;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>Index View</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Errors this instance.
        /// </summary>
        /// <returns>Error View</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}