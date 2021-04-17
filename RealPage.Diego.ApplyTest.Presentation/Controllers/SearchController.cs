namespace RealPage.Diego.ApplyTest.Presentation.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Search Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
