namespace RealPage.Diego.ApplyTest.Presentation.Controllers
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using RealPage.Diego.ApplyTest.Core.Constants;
    using System.IO;
    using System.Net;

    /// <summary>
    /// Log Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class DownloadsController : Controller
    {
        /// <summary>
        /// The log path
        /// </summary>
        private readonly string _logPath;

        /// <summary>
        /// The scripts path
        /// </summary>
        private readonly string _scriptsPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadsController" /> class.
        /// </summary>
        /// <param name="hostEnvironment">The host environment.</param>
        public DownloadsController(IWebHostEnvironment hostEnvironment)
        {
            this._logPath = Path.Combine(hostEnvironment.WebRootPath, "Logs", StaticValues.LogFileName);
            this._scriptsPath = Path.Combine(hostEnvironment.WebRootPath, "assets", StaticValues.ScriptFileName);
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Log()
        {
            var net = new WebClient();
            var data = net.DownloadData(this._logPath);
            var content = new MemoryStream(data);
            return File(content, "text/*", "Log.txt");
        }

        /// <summary>
        /// Logs this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Scripts()
        {
            var net = new WebClient();
            var data = net.DownloadData(this._scriptsPath);
            var content = new MemoryStream(data);
            return File(content, "text/*", "scripts.sql");
        }
    }
}
